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
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            LoadUsers();
            
        }      

        private void BtnLogin_Click(object sender, EventArgs e)
        { 
            Login();
        }

        void Login()
        {
            if (CmbBxUsers.SelectedValue.ToString() == "-1" || TxtBxPass.Text == string.Empty)
            {
                MessageBox.Show("Username is empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            if (!DBUser.checkPasswordMatched(int.Parse(CmbBxUsers.SelectedValue.ToString()), TxtBxPass.Text) == true)
            {
                MessageBox.Show("Password is not matching!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            UserLoggedIn.Instance().UserId = int.Parse(CmbBxUsers.SelectedValue.ToString());
            UserLoggedIn.Instance().IsAdmin = DBUser.IsUserAdmin(int.Parse(CmbBxUsers.SelectedValue.ToString()));
            UserLoggedIn.Instance().IsSuperUser = DBUser.IsUserSuperUser(int.Parse(CmbBxUsers.SelectedValue.ToString()));
            UserLoggedIn.Instance().UserName = CmbBxUsers.Text;

            if (ChkRememberLogin.Checked)
            {
                PointsUI.Properties.Settings.Default.UserName = CmbBxUsers.Text;
                PointsUI.Properties.Settings.Default.isRememberUserChecked = ChkRememberLogin.Checked;
                PointsUI.Properties.Settings.Default.Save();
            }
        }

        void LoadUsers()
        {
            List<User> users =  DBUser.GetUsers();
            users.Insert(0, new User()
            {
                UserName = "-Select-",
                ID = -1
            });

            CmbBxUsers.DataSource = users;
            CmbBxUsers.DisplayMember = "UserName";
            CmbBxUsers.ValueMember = "ID";
            CmbBxUsers.SelectedValue = -1;

            ChkRememberLogin.Checked = PointsUI.Properties.Settings.Default.isRememberUserChecked;

            if (ChkRememberLogin.Checked)
            {
                CmbBxUsers.Text = PointsUI.Properties.Settings.Default.UserName;
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.hotKey1.HotKeyPressed += new SmartHotKey.HotKey.HotKeyEventHandler(hotKey1_HotKeyPressed);
            this.hotKey1.AddHotKey("Escape");
            this.hotKey1.AddHotKey("Enter");
        }

        void hotKey1_HotKeyPressed(object sender, SmartHotKey.HotKeyEventArgs e)
        {
            if (e.HotKey == "Escape")
            {
                this.Close();
            }
            if (e.HotKey == "Enter")
            {
                Login();
            }
        }
    }
}
