using PointsUI.Classes;
using PointsUI.DBOperations;
using System;
using System.Collections.Generic;

namespace PointsUI.Forms
{
    public partial class FrmReportFilter : MetroFramework.Forms.MetroForm
    {
        List<Supervisor> supervisors;

        List<Contractor> contractors;

        public FrmReportFilter()
        {
            InitializeComponent();

            supervisors = DBSupervisor.getSupervisors();
            supervisors.Insert(0, new Supervisor()
            {
                Id = -1,
                Name = "-Select-"
            });

            CmbBxSupervisor.DataSource = supervisors;
            CmbBxSupervisor.DisplayMember = "Name";
            CmbBxSupervisor.ValueMember = "Id";
            CmbBxSupervisor.SelectedValue = -1;

            contractors = DBContractor.getContractors();
            contractors.Insert(0, new Contractor()
            {
                ID = -1,
                Name = "-Select-"
            });

            CmbBxContractor.DataSource = contractors;
            CmbBxContractor.DisplayMember = "Name";
            CmbBxContractor.ValueMember = "ID";
            CmbBxContractor.SelectedValue = -1;
        }

        private void FrmReportFilter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetTransactions.qryPointsTransactions' table. You can move, or remove it, as needed.
            //this.qryPointsTransactionsBindingSource.Filter = "ContractorName = 'Raghu'"; 
            this.qryPointsTransactionsTableAdapter.Fill(this.DataSetTransactions.qryPointsTransactions);



            ApplyFilters();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void CmbBxSupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string strFilters = "";

            Contractor contractor = (Contractor)CmbBxContractor.SelectedItem;
            if (contractor != null)
            {
                if (contractor.ID != -1)
                {
                    strFilters += "ContractorID = " + int.Parse(CmbBxContractor.SelectedValue.ToString());
                }
            }

            Supervisor supervisor = (Supervisor)CmbBxSupervisor.SelectedItem;
            if (supervisor.Id != -1)
            {
                if (strFilters != "")
                {
                    strFilters += " and ";
                }
                strFilters += "SupervisorId = " + int.Parse(CmbBxSupervisor.SelectedValue.ToString());
            }

            if(dtStart.Value < dtEnd.Value)
            {
                if(strFilters != "")
                {
                    strFilters += " and ";
                }

                dtStart.Value  = new DateTime(dtStart.Value.Year ,dtStart.Value.Month , dtStart.Value.Day, 0, 0, 0, 0);
                dtEnd.Value = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, dtEnd.Value.Day, 23,59, 59, 999);

                strFilters += "TransactionDate >='" + dtStart.Value.ToString() + "' AND TransactionDate <= '" + dtEnd.Value.ToString() + "'";
            }
            else
            {
                if (strFilters != "")
                {
                    strFilters += " and ";
                }

                dtEnd.Value = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, dtEnd.Value.Day, 0, 0, 0, 0);
                dtStart.Value = new DateTime(dtStart.Value.Year, dtStart.Value.Month, dtStart.Value.Day, 23, 59, 59, 999);

                strFilters += "TransactionDate >='" + dtEnd.Value.ToString() + "' AND TransactionDate <='" + dtStart.Value.ToString() + "'";
            }

            
            this.qryPointsTransactionsBindingSource.Filter = strFilters;
            this.reportViewer1.RefreshReport();
        }

        private string getSqlDate(DateTime date)
        {
            string year = "" + date.Year;
            string month = (date.Month < 10) ? "0" + date.Month : "" + date.Month;
            string day = (date.Day < 10) ? "0" + date.Day : "" + date.Day;

            return year + "-" + month + "-" + day + " 00:00:00";
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


    }
}
