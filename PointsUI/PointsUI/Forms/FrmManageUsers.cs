using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PointsUI.DBOperations;
using PointsUI.Classes;

namespace PointsUI.Forms
{
    public partial class FrmManageUsers : MetroFramework.Forms.MetroForm
    {
        public FrmManageUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private int UserId = -1;

        void LoadUsers()
        {
            List<User> users = DBOperations.DBUser.GetUsers();
            GV.Rows.Clear();
            foreach (User user in users)
            {
                if (user.ID != UserLoggedIn.Instance().UserId && user.UserName.ToLower() != "admin")
                {
                    GV.Rows.Add(
                    "Delete", "Modify", user.UserName, user.IsAdmin, user.IsSuperUser, user.CreatedByUserName, user.CreatedOn, user.ID
                    );
                }                
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtBxUserName.Text.Trim() == string.Empty)
            {
                ShowWarningMessage("Enter user name!");
                return;
            }

            if (TxtBxPass.Text.Trim() == string.Empty)
            {
                ShowWarningMessage("Enter Password field!");
                return;
            }

            if (TxtBxConfirmPass.Text.Trim() == string.Empty)
            {
                ShowWarningMessage("Enter Confirm Password field!");
                return;
            }

            if (TxtBxPass.Text.Trim().ToLower() != TxtBxConfirmPass.Text.Trim().ToLower())
            {
                ShowWarningMessage("Password and Confirm Password doesn't match!");
                return;
            }



            if (UserId == -1)//add
            {
                if (!DBOperations.DBUser.IsUserNameUnique(TxtBxUserName.Text, UserLoggedIn.Instance().UserId))
                {
                    ShowWarningMessage("UserName present already!");
                    return;
                }

                User user = new User
                {
                    UserName = TxtBxUserName.Text,
                    Password = TxtBxPass.Text,
                    CreatedOn = DateTime.Now,
                    CreatedById = UserLoggedIn.Instance().UserId,
                    UpdatedOn = DateTime.Now,
                    UpdatedById = UserLoggedIn.Instance().UserId,
                    IsAdmin = ChkAdmin.Checked,
                    IsSuperUser = chkSuperUser.Checked
                };
                DBUser.InsertUser(user, UserLoggedIn.Instance().UserId);
                MessageBox.Show("User created successfully!", "Created User!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadUsers();
            }
            else
            {      
                User user = new User
                {
                    UserName = TxtBxUserName.Text,
                    Password = TxtBxPass.Text,
                    CreatedOn = DateTime.Now,
                    CreatedById = UserLoggedIn.Instance().UserId,
                    UpdatedOn = DateTime.Now,
                    UpdatedById = UserLoggedIn.Instance().UserId,
                    ID = UserId,
                    IsAdmin = ChkAdmin.Checked,
                    IsSuperUser = chkSuperUser.Checked
                };
                DBOperations.DBUser.UpdateUser(user, UserLoggedIn.Instance().UserId);
                UserId = -1;
                MessageBox.Show("User Upated successfully!", "Updated User!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadUsers();
            }
        }

        void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Error Validating Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.Columns[e.ColumnIndex].Name == "ColModify")
            {
                DataGridViewRow row = GV.Rows[e.RowIndex];
                TxtBxUserName.Text = row.Cells[2].Value.ToString();
                ChkAdmin.Checked = bool.Parse(row.Cells[3].Value.ToString());
                chkSuperUser.Checked = bool.Parse(row.Cells[4].Value.ToString());
                UserId = int.Parse(row.Cells[7].Value.ToString());               
            }
            else if (GV.Columns[e.ColumnIndex].Name == "ColDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this User?", "Delete User!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UserId = int.Parse(GV.Rows[e.RowIndex].Cells[6].Value.ToString());
                    try
                    {
                        DBUser.DeleteUser(UserId,UserLoggedIn.Instance().UserId);
                        GV.Rows.RemoveAt(e.RowIndex);
                        UserId = -1;
                        ClearControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete this record as related record exists!" + Environment.NewLine +  ex.Message, "Delete User!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        void ClearControls()
        {
            TxtBxConfirmPass.Clear();
            TxtBxPass.Clear();
            TxtBxUserName.Clear();
        }
    }
}
