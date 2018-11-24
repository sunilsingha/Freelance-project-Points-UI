using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using PointsUI.Classes;

namespace PointsUI
{
    public partial class FrmPointsNew : MetroFramework.Forms.MetroForm
    {
        public FrmPointsNew()
        {
            InitializeComponent();
        }

        private int contractorId = -1;
        private int pointsID = -1;

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtBxContractor.Text == string.Empty
                && TxtBxPhoneNo.Text == string.Empty
                && TxtBxUniqueId.Text == string.Empty
                && TxtBxSupervisorName.Text == string.Empty)
            {
                ShowWarningMessage("Please enter any one field to make search!");
                this.DialogResult = DialogResult.None;
                return;
            }

            List<Contractor> contractors = DBOperations.DBContractor.SearchContractor(TxtBxContractor.Text, TxtBxPhoneNo.Text, TxtBxUniqueId.Text, TxtBxSupervisorName.Text);
            GVContractors.Rows.Clear();
            foreach (Contractor cont in contractors)
            {
                GVContractors.Rows.Add(
                    "New Points",
                    cont.Name,
                    cont.ContractorNo,
                    cont.MobileNumber,
                    cont.SupervisorName,
                    cont.CreatedByUserName,
                    cont.CreatedOn,
                    cont.Address,
                    cont.SupervisorId,
                    cont.ID
                );
            }

        }

        void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Error Validating Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void ClearSearchControls()
        {
            TxtBxContractor.Clear();
            TxtBxSupervisorName.Clear();
            TxtBxPhoneNo.Clear();
            TxtBxUniqueId.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearSearchControls();
        }

        void ClearPointsControls()
        {
            TxtBxPointsContractorNo.Clear();
            TxtBxPointPhoneNumber.Clear();
            TxtBxPointsContractorName.Clear();
            TxtBxPointSupervisor.Clear();
            TxtBxApolloLiters.Text = "0";
            TxtBxAsianLiters.Text = "0";
            TxtBxKgs.Text = "0";
            TxtBxVouchers.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ClearPointsControls();
        }


        private void GVContractors_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearPointsControls();
            DataGridViewRow row = GVContractors.Rows[e.RowIndex];
            TxtBxPointsContractorName.Text = row.Cells[1].Value.ToString();
            TxtBxPointPhoneNumber.Text = row.Cells[3].Value.ToString();
            TxtBxPointsContractorNo.Text = row.Cells[2].Value.ToString();
            TxtBxPointSupervisor.Text = row.Cells[4].Value.ToString();
            contractorId = int.Parse(row.Cells[9].Value.ToString());
        }

        private void GVContractors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearPointsControls();
            DataGridViewRow row = GVContractors.Rows[e.RowIndex];
            if (GVContractors.Columns[e.ColumnIndex].Name == "ColPoints")
            {
                ClearPointsControls();
                TxtBxPointsContractorName.Text = row.Cells[1].Value.ToString();
                TxtBxPointPhoneNumber.Text = row.Cells[3].Value.ToString();
                TxtBxPointsContractorNo.Text = row.Cells[2].Value.ToString();
                TxtBxPointSupervisor.Text = row.Cells[4].Value.ToString();
                contractorId = int.Parse(row.Cells[9].Value.ToString());
                TxtBxAsianLiters.Text = "0";
                TxtBxApolloLiters.Text = "0";
                TxtBxKgs.Text = "0";
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtBxPointsContractorNo.Text == string.Empty)
            {
                ShowWarningMessage("Contractor Name not entered!");
                return;
            }

            if (TxtBxKgs.Text == string.Empty)
            {
                ShowWarningMessage("Kgs not entered!");
                return;
            }

            if (TxtBxAsianLiters.Text == string.Empty)
            {
                ShowWarningMessage("Asian Litres not entered!");
                return;
            }

            if (TxtBxApolloLiters.Text == string.Empty)
            {
                ShowWarningMessage("Apollo Litres not entered!");
                return;
            }

            double lts;
            if (!double.TryParse(TxtBxAsianLiters.Text, out lts))
            {
                ShowWarningMessage("Asian Litres should be numeric value!");
                return;
            }

            if (!double.TryParse(TxtBxApolloLiters.Text, out lts))
            {
                ShowWarningMessage("Apollo Litres should be numeric value!");
                return;
            }

            double Kgs;
            if (!double.TryParse(TxtBxKgs.Text, out Kgs))
            {
                ShowWarningMessage("Kgs should be numeric value!");
                return;
            }


            PointsTransaction pointsTransaction = new PointsTransaction
            {
                ContractorId = contractorId,
                Kgs = double.Parse(TxtBxKgs.Text),
                AsianLitres = double.Parse(TxtBxAsianLiters.Text),
                ApolloLitres = double.Parse(TxtBxApolloLiters.Text),
                VoucherNo = TxtBxVouchers.Text

            };

            try
            {
                if (pointsID == -1)
                {

                    DBOperations.DBPoints.AddPoint(pointsTransaction, UserLoggedIn.Instance().UserId);

                    int totalpoints = DBOperations.DBPoints.GetTotalPointsbyName(TxtBxPointsContractorNo.Text);

                    if (UserLoggedIn.Instance().IsAdmin || UserLoggedIn.Instance().IsSuperUser)
                    {
                        try
                        {
                            SendSMS(TxtBxPointsContractorName.Text, TxtBxPointsContractorNo.Text, TxtBxPointPhoneNumber.Text, totalpoints);
                            MessageBox.Show("SMS has been sent!", "SMS Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was an error sending SMS!" + Environment.NewLine + ex.Message, "SMS failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    ClearPointsControls();
                }
                else
                {
                    pointsTransaction.ID = pointsID;
                    DBOperations.DBPoints.UpdatePoint(pointsTransaction, UserLoggedIn.Instance().UserId);
                    pointsID = -1;
                    MessageBox.Show("Points Updated Successfully", "Points Entry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPointsControls();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            ClearPointsControls();
            contractorId = -1;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            List<PointsTransaction> pointsTransactions = DBOperations.DBPoints.getPoints();

            GVPoints.Rows.Clear();

            foreach (PointsTransaction PT in pointsTransactions)
            {
                GVPoints.Rows.Add(

                    "Modify",
                    "Delete",
                    PT.Status,
                    PT.AsianLitres,
                    PT.ApolloLitres,
                    PT.Kgs,
                    PT.VoucherNo,
                    PT.ContractorName,
                    PT.SupervisorName,
                    PT.CreatedByUserName,
                    PT.CreatedOn,
                    PT.ID,
                    PT.ContractorId,
                    PT.ContractorPhoneNumber,
                    PT.ContractorNo
                    );
            }

        }

        private void GVPoints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GVPoints.Rows[e.RowIndex];
            if (GVPoints.Columns[e.ColumnIndex].Name == "ColModify")
            {
                ClearPointsControls();
                groupPoints.Text = "Modify points";
                TxtBxPointsContractorName.Text = row.Cells[8].Value.ToString();
                TxtBxPointsContractorNo.Text = row.Cells[14].Value.ToString();
                TxtBxPointPhoneNumber.Text = row.Cells[13].Value.ToString();
                TxtBxPointSupervisor.Text = row.Cells[8].Value.ToString();
                TxtBxKgs.Text = row.Cells[5].Value.ToString();
                TxtBxAsianLiters.Text = row.Cells[3].Value.ToString();
                TxtBxApolloLiters.Text = row.Cells[4].Value.ToString();
                TxtBxVouchers.Text = row.Cells[6].Value.ToString();
                pointsID = int.Parse(row.Cells[11].Value.ToString());
            }
            else if (GVPoints.Columns[e.ColumnIndex].Name == "ColDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Contractor!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pointsID = int.Parse(row.Cells[11].Value.ToString());
                    DBOperations.DBPoints.DeletePoint(pointsID);
                    GVPoints.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void FrmPointsNew_ResizeEnd1(object sender, EventArgs e)
        {


        }

        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                ((FrmMain)MdiParent).OnMax();
                frmloaded = false;
            }
        }
        bool frmloaded = false;
        private void FrmPointsNew_Load(object sender, EventArgs e)
        {
            frmloaded = true;
        }

        private void FrmPointsNew_Load1(object sender, EventArgs e)
        {
            frmloaded = true;
        }

        private void BtnRefreshPoints_Click(object sender, EventArgs e)
        {
            List<PointsTable> pointsTables = DBOperations.DBPoints.getPointsTale();

            GVTotalPoints.Rows.Clear();

            foreach (PointsTable PT in pointsTables)
            {
                GVTotalPoints.Rows.Add(
                    PT.ContractorId,
                    PT.ContractorNo,
                    PT.ContractorName,
                    PT.PhoneNo,
                    PT.TotalAsiaLitres,
                    PT.TotalAppoloLitres,
                    PT.TotalKgs,
                    PT.InPoints,
                    PT.Points
                    );
            }
        }

        private void BtnSendSMS_Click(object sender, EventArgs e)
        {
            if (GVTotalPoints.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                List<PointsTransaction> contractors = new List<PointsTransaction>();
                string error = string.Empty;
                if (UserLoggedIn.Instance().IsAdmin || UserLoggedIn.Instance().IsSuperUser)
                {
                    foreach (DataGridViewRow gvrow in GVTotalPoints.SelectedRows)
                    {
                        string contractorName = gvrow.Cells[2].Value.ToString();
                        string contractorPhoneNo = gvrow.Cells[3].Value.ToString();
                        int totalPoints = int.Parse(gvrow.Cells[7].Value.ToString());
                        string contractorId = gvrow.Cells[1].Value.ToString();

                        try
                        {
                            if (!SendSMS(contractorName, contractorId, contractorPhoneNo, totalPoints))
                            {
                                PointsTransaction contractor = new PointsTransaction
                                {
                                    ContractorName = contractorName,
                                    ContractorId = int.Parse(contractorId),
                                    Points = totalPoints
                                };
                                contractors.Add(contractor);
                            }
                        }
                        catch (Exception ex)
                        {
                            PointsTransaction contractor = new PointsTransaction
                            {
                                ContractorName = contractorName,
                                ContractorId = int.Parse(contractorId),
                                Points = totalPoints
                            };
                            contractors.Add(contractor);
                            error = ex.Message;
                        }
                    }

                    if (contractors.Count > 0)
                    {
                        string message = error + Environment.NewLine + "SMS sending failed for below mentioned contractors!" + Environment.NewLine;
                        foreach (PointsTransaction c in contractors)
                        {
                            message += string.Format("ContractorName(Id) = {0}({1}) ------ Points = {2}", c.ContractorName, "0000" + c.ContractorId, c.Points) + Environment.NewLine;
                        }
                        string logerrorfile = writeAndReturnFile(message);
                        string msg = "There was an issue sending SMS!" + Environment.NewLine + "Do you want to see the log?";
                        if (MessageBox.Show(msg, "SMS failed!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start(logerrorfile);
                        }
                    }
                    else
                    {
                        MessageBox.Show("SMS has been sent!", "SMS Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Sorry you are not authorized to send SMS!", "Points Entry!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error sending SMS!" + Environment.NewLine + ex.Message, "SMS failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool SendSMS(string ContractorName, string ContractorId, string PhoneNo, int totalPoints)
        {
            try
            {
                string smsMessage = string.Format("Dear {0}({2}) Congrats, you just earned a total of {1} points. Thank you, Visit again!", ContractorName, totalPoints, ContractorId);

                if (SMS.SendSms(PointsUI.Properties.Settings.Default.smsUserName,
                PointsUI.Properties.Settings.Default.smsPass,
                PointsUI.Properties.Settings.Default.smsSenderId,
                PhoneNo, smsMessage))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Writes error message only when SMS sending is failed in bulk
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        string writeAndReturnFile(string msg)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string fileName = System.IO.Path.Combine(appdata, string.Format("Error_{0}.txt", DateTime.Now.ToLongDateString()));

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName))
            {
                writer.Write(msg);
            }

            return fileName;
        }

    }
}
