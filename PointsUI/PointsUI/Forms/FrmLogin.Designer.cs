namespace PointsUI.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.CmbBxUsers = new MetroFramework.Controls.MetroComboBox();
            this.TxtBxPass = new MetroFramework.Controls.MetroTextBox();
            this.ChkRememberLogin = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hotKey1 = new SmartHotKey.HotKey();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBxUsers
            // 
            this.CmbBxUsers.FormattingEnabled = true;
            this.CmbBxUsers.ItemHeight = 23;
            this.CmbBxUsers.Location = new System.Drawing.Point(282, 110);
            this.CmbBxUsers.Name = "CmbBxUsers";
            this.CmbBxUsers.Size = new System.Drawing.Size(252, 29);
            this.CmbBxUsers.TabIndex = 1;
            this.CmbBxUsers.UseSelectable = true;
            // 
            // TxtBxPass
            // 
            // 
            // 
            // 
            this.TxtBxPass.CustomButton.Image = null;
            this.TxtBxPass.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.TxtBxPass.CustomButton.Name = "";
            this.TxtBxPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxPass.CustomButton.TabIndex = 1;
            this.TxtBxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxPass.CustomButton.UseSelectable = true;
            this.TxtBxPass.CustomButton.Visible = false;
            this.TxtBxPass.Lines = new string[0];
            this.TxtBxPass.Location = new System.Drawing.Point(282, 160);
            this.TxtBxPass.MaxLength = 32767;
            this.TxtBxPass.Name = "TxtBxPass";
            this.TxtBxPass.PasswordChar = '*';
            this.TxtBxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxPass.SelectedText = "";
            this.TxtBxPass.SelectionLength = 0;
            this.TxtBxPass.SelectionStart = 0;
            this.TxtBxPass.ShortcutsEnabled = true;
            this.TxtBxPass.Size = new System.Drawing.Size(252, 23);
            this.TxtBxPass.TabIndex = 2;
            this.TxtBxPass.UseSelectable = true;
            this.TxtBxPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChkRememberLogin
            // 
            this.ChkRememberLogin.AutoSize = true;
            this.ChkRememberLogin.Location = new System.Drawing.Point(254, 201);
            this.ChkRememberLogin.Name = "ChkRememberLogin";
            this.ChkRememberLogin.Size = new System.Drawing.Size(134, 15);
            this.ChkRememberLogin.TabIndex = 3;
            this.ChkRememberLogin.Text = "Remember my Login";
            this.ChkRememberLogin.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(189, 164);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(175, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "User Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(161, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Welcome";
            // 
            // BtnLogin
            // 
            this.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnLogin.Location = new System.Drawing.Point(149, 231);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(288, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PointsUI.Properties.Resources.login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(34, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 98);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // hotKey1
            // 
            this.hotKey1.Location = new System.Drawing.Point(459, 201);
            this.hotKey1.Name = "hotKey1";
            this.hotKey1.Size = new System.Drawing.Size(75, 23);
            this.hotKey1.TabIndex = 22;
            this.hotKey1.Text = "hotKey1";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 300);
            this.Controls.Add(this.hotKey1);
            this.Controls.Add(this.CmbBxUsers);
            this.Controls.Add(this.TxtBxPass);
            this.Controls.Add(this.ChkRememberLogin);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CmbBxUsers;
        private MetroFramework.Controls.MetroTextBox TxtBxPass;
        private MetroFramework.Controls.MetroCheckBox ChkRememberLogin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private SmartHotKey.HotKey hotKey1;
    }
}