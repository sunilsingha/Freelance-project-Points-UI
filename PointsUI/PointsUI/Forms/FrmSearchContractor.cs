using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointsUI
{
    public partial class FrmSearchContractor : MetroFramework.Forms.MetroForm
    {

        public Contractor contractor { get; set; }

      
        public FrmSearchContractor()
        {
            InitializeComponent();
           
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtBxContractor.Text == string.Empty && TxtBxPhoneNo.Text == string.Empty && TxtBxUniqueId.Text == string.Empty)
            {
                ShowWarningMessage("Please enter any one field to make search!");
                this.DialogResult = DialogResult.None;
                return;
            }

            if (TxtBxContractor.Text.ToLower() != "akash")
            {
                ShowWarningMessage("Contractor not found!");
                this.DialogResult = DialogResult.None;
                return;
            }

            //if (!Helper.IsPhoneNumber(TxtBxPhoneNo.Text))
            //{
            //    ShowWarningMessage("Please check phone number!");
            //    TxtBxPhoneNo.Focus();
            //    this.DialogResult = DialogResult.None;
            //    return;
            //}

            contractor = new Contractor { Name = "Akash", ID = 1, SupervisorId = 1, MobileNumber = "9632919420", ContractorNo = "ABC1111" };
        }


        void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Error Validating Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum FocusControlType
        {
            Name,Id,Phone
        }

        public FocusControlType FT { get; set; }

        void FocusControl()
        {
            switch (FT)
            {
                case FocusControlType.Name:
                    TxtBxContractor.Focus();
                    this.ActiveControl = TxtBxContractor;
                    break;
                case FocusControlType.Id:
                    TxtBxUniqueId.Focus();
                    this.ActiveControl = TxtBxUniqueId;
                    break;
                case FocusControlType.Phone:
                    TxtBxPhoneNo.Focus();
                    this.ActiveControl = TxtBxPhoneNo;
                    break;
                default:
                    break;
            }
        }

        private void FrmSearchContractor_Load(object sender, EventArgs e)
        {
            FocusControl();
        }
    }
}