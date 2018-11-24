using PointsUI.Classes;
using PointsUI.DBOperations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PointsUI
{
    public partial class FrmContractorPending : MetroFramework.Forms.MetroForm
    {
        public FrmContractorPending()
        {
            InitializeComponent();
        }

        private void FrmContractorPending_Load(object sender, EventArgs e)
        {
            RefreshContractorPending();
        }

        private void RefreshContractorPending()
        {
            GV.Rows.Clear();

            List<Contractor> lstContractor = DBContractor.getPendingApprovalContractors();

            foreach(Contractor contractor in lstContractor)
            {
                GV.Rows.Add(
                    contractor.ID,
                    "Approve", 
                    "Reject",
                    contractor.Name,
                    contractor.MobileNumber,
                    contractor.Address,
                    contractor.IdType,
                    contractor.SupervisorName,
                    contractor.Status);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshContractorPending();
            if (GV.Rows.Count == 0)
            {
                MessageBox.Show("No pending approvals!", "Pending Approvals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.Columns[e.ColumnIndex].Name == "ColApprove")
            {
                DataGridViewRow row = GV.Rows[e.RowIndex];
                int ContractorId = int.Parse(row.Cells[0].Value.ToString());
                DBContractor.ApproveContractor(ContractorId, UserLoggedIn.Instance().UserId);
                //row.Cells[1].Style.

                //RefreshContractorPending();
                               

                MessageBox.Show("Contractor Approved!", "Add Contractor!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GV.Rows.RemoveAt(e.RowIndex);
            }
            else if (GV.Columns[e.ColumnIndex].Name == "ColReject")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Reject Contractor!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ContractorId = int.Parse(GV.Rows[e.RowIndex].Cells[0].Value.ToString());

                    try
                    {
                        DBContractor.DeleteContractor(ContractorId);
                        GV.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show("Contractor Deleted!", "Delete Contractor!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete this record as related record exists!", "Delete Contractor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
