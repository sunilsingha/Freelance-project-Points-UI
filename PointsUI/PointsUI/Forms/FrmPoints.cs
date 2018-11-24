using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PointsUI
{
    public partial class FrmPoints : MetroFramework.Forms.MetroForm
    {

        List<Supervisor> supervisors;

        public FrmPoints()
        {
            InitializeComponent();

            supervisors = new List<Supervisor>
            {
                new Supervisor{Name = "-SELECT-", Id = -1},
                new Supervisor{Name = "Mike",Id = 1},
                new Supervisor{Name = "Mary", Id=2},
                new Supervisor{Name = "John", Id = 3}
            };

            CmbBxSupervisor.DataSource = supervisors;
            CmbBxSupervisor.DisplayMember = "Name";
            CmbBxSupervisor.ValueMember = "Id";
            CmbBxSupervisor.SelectedIndex = 0;
        }

        private void FrmPoints_Load(object sender, EventArgs e)
        {

        }

        FrmSearchContractor searchContractor;
        private void LinkContractor_Click(object sender, EventArgs e)
        {
            searchContractor = new FrmSearchContractor();
            searchContractor.FT = FrmSearchContractor.FocusControlType.Name;
            if (searchContractor.ShowDialog() == DialogResult.OK)
            {
                UpdateContractor(searchContractor.contractor);
            }
        }

        private void LinkPhone_Click(object sender, EventArgs e)
        {
            searchContractor = new FrmSearchContractor();
            searchContractor.FT = FrmSearchContractor.FocusControlType.Phone;
            if (searchContractor.ShowDialog() == DialogResult.OK)
            {
                UpdateContractor(searchContractor.contractor);
            }
        }

        private void LinkUniqueId_Click(object sender, EventArgs e)
        {
            searchContractor = new FrmSearchContractor();
            searchContractor.FT = FrmSearchContractor.FocusControlType.Id;
            if (searchContractor.ShowDialog() == DialogResult.OK)
            {
                UpdateContractor(searchContractor.contractor);
            }
        }

        void UpdateContractor(Contractor contractor)
        {
            TxtBxContracotrName.Text = contractor.Name;
            TxtBxPhoneNo.Text = contractor.MobileNumber;
            CmbBxSupervisor.SelectedValue = contractor.SupervisorId;
            TxtBxUniqueId.Text = contractor.ContractorNo;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtBxContracotrName.Text == string.Empty)
            {
                ShowWarningMessage("Contractor Name is empty!");
                return;
            }

            if (TxtBxPhoneNo.Text == string.Empty)
            {
                ShowWarningMessage("Phone Number is empty!");
                return;
            }

            if (TxtBxUniqueId.Text == string.Empty)
            {
                ShowWarningMessage("Unique Id is empty!");
                return;
            }

            if (!IsNumeric(TxtBxLiters.Text))
            {
                ShowWarningMessage("liters should be in numerica value!");
                return;
            }

            if (!IsNumeric(TxtBxKgs.Text))
            {
                ShowWarningMessage("Kgs should be in numerica value!");
                return;
            }

        }

        void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Error Validating Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        bool IsNumeric(string input)
        {
            float output;
            return float.TryParse(input, out output);
        }

    }
}
