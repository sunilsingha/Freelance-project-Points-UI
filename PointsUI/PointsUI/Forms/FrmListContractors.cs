using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PointsUI.DBOperations;

namespace PointsUI
{
    public partial class FrmListContractors : MetroFramework.Forms.MetroForm
    {
        public FrmListContractors()
        {
            InitializeComponent();

            RefreshContractors();
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.Columns[e.ColumnIndex].Name == "ColModify")
            {
                DataGridViewRow row = GV.Rows[e.RowIndex];
                FrmContractor frmContractor = new FrmContractor(int.Parse(row.Cells
                    [0].Value.ToString()));
                frmContractor.MdiParent = (FrmMain)MdiParent;
                frmContractor.Show();
                               
            }
            else if (GV.Columns[e.ColumnIndex].Name == "ColDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Contractor!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ContractorId = int.Parse(GV.Rows[e.RowIndex].Cells[0].Value.ToString());

                    try
                    {
                        DBContractor.DeleteContractor(ContractorId);
                        GV.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete this record as related record exists!", "Delete Contractor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshContractors();
        }

        private void RefreshContractors()
        {
            List<Contractor> contractors = DBContractor.getContractors();

            GV.Rows.Clear();

            foreach (Contractor contractor in contractors)
            {
                GV.Rows.Add(
                    contractor.ID,
                    "Modify",
                    "Delete",
                    contractor.ContractorNo,
                    contractor.Name,
                    contractor.MobileNumber,
                    contractor.SupervisorName,
                    contractor.CreatedByUserName,
                    contractor.CreatedOn,
                    null,
                    contractor.Address,
                    contractor.SupervisorId
                    );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmContractor frmContractor = new FrmContractor(-1);
            frmContractor.ShowDialog();
            RefreshContractors();
        }
    }
}
