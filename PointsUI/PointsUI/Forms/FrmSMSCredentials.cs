using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;

namespace PointsUI.Forms
{
    public partial class FrmSMSCredentials : MetroFramework.Forms.MetroForm
    {
        public FrmSMSCredentials()
        {
            InitializeComponent();
        }

        private void TxtBxUserName_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (TxtBxUserName.Text == string.Empty || TxtBxPass.Text == string.Empty || TxtBxSenderId.Text == string.Empty)
            {

                MessageBox.Show("Please enter necessary details to save!", "SMS Detials", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            PointsUI.Properties.Settings.Default.smsUserName =  TxtBxUserName.Text;
            PointsUI.Properties.Settings.Default.smsPass = TxtBxPass.Text;
            PointsUI.Properties.Settings.Default.smsSenderId = TxtBxSenderId.Text;
            PointsUI.Properties.Settings.Default.Save();

            MessageBox.Show("Saved successfully!", "SMS Detials", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmSMSCredentials_Load(object sender, EventArgs e)
        {
            TxtBxUserName.Text = PointsUI.Properties.Settings.Default.smsUserName;
            TxtBxPass.Text = PointsUI.Properties.Settings.Default.smsPass;
            TxtBxSenderId.Text = PointsUI.Properties.Settings.Default.smsSenderId;
        }
    }
}
