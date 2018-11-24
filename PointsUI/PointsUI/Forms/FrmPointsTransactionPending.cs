using PointsUI.Classes;
using PointsUI.DBOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointsUI.Forms
{
    public partial class FrmPointsTransactionPending : MetroFramework.Forms.MetroForm
    {
        public FrmPointsTransactionPending()
        {
            InitializeComponent();
        }

        private void RefreshPointsTransactionPending()
        {
            GV.Rows.Clear();

            List<PointsTransaction> lstPointsTransaction = DBPoints.getPointsTransactionPendingForApproval();

            foreach (PointsTransaction pointsTranction in lstPointsTransaction)
            {
                GV.Rows.Add(
                    pointsTranction.ID,
                    "Approve",
                    "Reject",
                    pointsTranction.TransactionDate,
                    pointsTranction.Kgs,
                    pointsTranction.AsianLitres,
                    pointsTranction.ApolloLitres,
                    pointsTranction.VoucherNo,
                    pointsTranction.ContractorName,
                    pointsTranction.Status);
            }

            if (GV.Rows.Count == 0)
            {
                MessageBox.Show("No pending approvals!", "Pending Approvals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPointsTransactionPending();

           
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.Columns[e.ColumnIndex].Name == "ColApprove")
            {
                DataGridViewRow row = GV.Rows[e.RowIndex];
                int PointsTransactionId = int.Parse(row.Cells[0].Value.ToString());
                DBPoints.ApprovePoint(PointsTransactionId, UserLoggedIn.Instance().UserId);
                //row.Cells[1].Style.

                //RefreshContractorPending();

                MessageBox.Show("Points Transaction Approved!", "Pending Approvals!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GV.Rows.RemoveAt(e.RowIndex);
            }
            else if (GV.Columns[e.ColumnIndex].Name == "ColReject")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Reject Points Transaction!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int PointsTransactionId = int.Parse(GV.Rows[e.RowIndex].Cells[0].Value.ToString());

                    try
                    {
                        DBPoints.DeletePoint(PointsTransactionId);
                        GV.Rows.RemoveAt(e.RowIndex);
                                                
                        MessageBox.Show("Points Transaction deleted!", "Delete Approvals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete this record as related record exists!", "Delete Points Transaction!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FrmPointsTransactionPending_Load(object sender, EventArgs e)
        {
            RefreshPointsTransactionPending();
        }

        private void BtnApproveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GV.Rows)
            {              
                int PointsTransactionId = int.Parse(row.Cells[0].Value.ToString());
                DBPoints.ApprovePoint(PointsTransactionId, UserLoggedIn.Instance().UserId);      
            }

            MessageBox.Show("Points Transaction Approved!", "Pending Approvals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshPointsTransactionPending();

           
        }
    }
}
