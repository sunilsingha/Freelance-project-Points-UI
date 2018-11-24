using PointsUI.DBOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using PointsUI.Classes;
using PointsUI.Forms;

namespace PointsUI
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        FrmContractor frmContractor;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBPoints.getPoints();

            if (frmContractor == null)
            {
                frmContractor = new FrmContractor(-1);
                frmContractor.MdiParent = this;
                frmContractor.FormClosed += FrmContractor_FormClosed;
                frmContractor.Show();
            }
            else
            {
                frmContractor.Activate();
            }

        }

        private void FrmContractor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmContractor = null;
        }

        FrmListContractors frmListContractors;
        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListContractors == null)
            {
                frmListContractors = new FrmListContractors();
                frmListContractors.MdiParent = this;
                frmListContractors.FormClosed += FrmListContractors_FormClosed;
                frmListContractors.Show();
            }
            else
            {
                frmListContractors.Activate();
            }
        }

        private void FrmListContractors_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmListContractors = null;
        }

        FrmPointsNew frmPoints;
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmPoints == null)
            {
                frmPoints = new FrmPointsNew();
                frmPoints.MdiParent = this;
                frmPoints.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
                frmPoints.FormClosed += FrmPoints_FormClosed;
                frmPoints.Show();
            }
            else
            {
                frmPoints.Activate();
            }
        }

        private void FrmPoints_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPoints = null;
        }

        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        FrmSupervisor frmSupervisor;
        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmSupervisor == null)
            {
                frmSupervisor = new FrmSupervisor();
                frmSupervisor.MdiParent = this;
                frmSupervisor.FormClosed += FrmSupervisor_FormClosed;
                frmSupervisor.Show();
            }
            else
            {
                frmSupervisor.Activate();
            }
        }

        private void FrmSupervisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSupervisor = null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string DB = PointsUI.Properties.Settings.Default.connnection.ToString();
            int iStart = DB.IndexOf("Source=") + 7;
            string sDB = DB.Substring(iStart, DB.Length - iStart);

            if (!System.IO.File.Exists(sDB))
            {
                MessageBox.Show("Database not found!" + Environment.NewLine + "Please select Database", "Error finding DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmDBSelection frmDBSelection = new FrmDBSelection();
                if (frmDBSelection.ShowDialog() == DialogResult.OK)
                {
                    BindDB(frmDBSelection.DBpath);
                    MessageBox.Show("Setting Database Path. Please Re-Open the Application again...", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Environment.Exit(1);
                }
            }           

            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                System.Environment.Exit(1);
            }

            LblUser.Text = UserLoggedIn.Instance().UserName + " logged in.";
            EnableAdminControls();
        }

        void BindDB(string DBpath)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["PointsUI.Properties.Settings.connnection"].ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBpath;
            config.Save(ConfigurationSaveMode.Modified);
            config.SaveAs("app.config", ConfigurationSaveMode.Modified, true);
        }

        void EnableAdminControls()
        {
            if (UserLoggedIn.Instance().IsAdmin)
            {
                adminToolStripMenuItem.Enabled = true;
            }
            else
            {
                adminToolStripMenuItem.Enabled = false;
            }
        }

        FrmContractorPending frmContractorPending;
        private void pendingContractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmContractorPending == null)
            {
                frmContractorPending = new FrmContractorPending();
                frmContractorPending.MdiParent = this;
                frmContractorPending.FormClosed += FrmContractorPending_FormClosed;
                frmContractorPending.Show();
            }
            else
            {
                frmSupervisor.Activate();
            }
        }

        private void FrmContractorPending_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmContractorPending = null;
        }

        FrmPointsTransactionPending frmPointsTransactionPending;
        private void pendingPointsApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPointsTransactionPending == null)
            {
                frmPointsTransactionPending = new FrmPointsTransactionPending();
                frmPointsTransactionPending.MdiParent = this;
                frmPointsTransactionPending.FormClosed += FrmPointsTransactionPending_FormClosed;
                frmPointsTransactionPending.Show();
            }
            else
            {
                frmPointsTransactionPending.Activate();
            }
        }

        private void FrmPointsTransactionPending_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPointsTransactionPending = null;
        }


        FrmManageUsers frmManageUsers;
        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageUsers == null)
            {
                frmManageUsers = new FrmManageUsers();
                frmManageUsers.MdiParent = this;
                frmManageUsers.FormClosed += FrmManageUsers_FormClosed;
                frmManageUsers.Show();
            }
            else
            {
                frmManageUsers.Activate();
            }
        }

        private void FrmManageUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmManageUsers = null;
        }

        public void OnMax()
        {         
          //  this.WindowState = FormWindowState.Normal;
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        FrmReportFilter frmReport;
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReport == null)
            {
                frmReport = new FrmReportFilter();
                frmReport.FormClosed += FrmReport_FormClosed;
                frmReport.MdiParent = this;
                frmReport.Show();
            }
            else
            {
                frmReport.Activate();
            }
        }

        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReport = null;
        }

        FrmSMSCredentials frmSMS;
        private void sMSDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSMS == null)
            {
                frmSMS = new FrmSMSCredentials();
                frmSMS.FormClosed += FrmSMS_FormClosed;
                frmSMS.MdiParent = this;
                frmSMS.Show();
            }
            else
            {
                frmSMS.Activate();
            }
        }

        private void FrmSMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSMS = null;
        }
    }
}
