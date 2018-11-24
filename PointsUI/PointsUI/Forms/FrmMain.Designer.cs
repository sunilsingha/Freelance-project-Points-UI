namespace PointsUI
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSDetialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pendingPointsApprovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingContractorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblUser = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem,
            this.contractorToolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.reportsToolStripMenuItem});
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = global::PointsUI.Properties.Resources.Database_Table_icon;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.newToolStripMenuItem1.Text = "Manage Points";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = global::PointsUI.Properties.Resources.report_icon;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // contractorToolStripMenuItem
            // 
            this.contractorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.contractorToolStripMenuItem.Name = "contractorToolStripMenuItem";
            this.contractorToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.contractorToolStripMenuItem.Text = "Contractor";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Image = global::PointsUI.Properties.Resources.view_icon;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.modifyToolStripMenuItem.Text = "View";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem1});
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.supervisorToolStripMenuItem.Text = "Supervisor";
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.Image = global::PointsUI.Properties.Resources.profile;
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.modifyToolStripMenuItem1.Text = "View";
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyToolStripMenuItem1_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.sMSDetialsToolStripMenuItem,
            this.toolStripSeparator1,
            this.pendingPointsApprovalToolStripMenuItem,
            this.pendingContractorsToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Image = global::PointsUI.Properties.Resources.profile;
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // sMSDetialsToolStripMenuItem
            // 
            this.sMSDetialsToolStripMenuItem.Name = "sMSDetialsToolStripMenuItem";
            this.sMSDetialsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.sMSDetialsToolStripMenuItem.Text = "SMS Detials";
            this.sMSDetialsToolStripMenuItem.Click += new System.EventHandler(this.sMSDetialsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // pendingPointsApprovalToolStripMenuItem
            // 
            this.pendingPointsApprovalToolStripMenuItem.Image = global::PointsUI.Properties.Resources.Business_Approve_icon__1_;
            this.pendingPointsApprovalToolStripMenuItem.Name = "pendingPointsApprovalToolStripMenuItem";
            this.pendingPointsApprovalToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.pendingPointsApprovalToolStripMenuItem.Text = "Pending Points Approval";
            this.pendingPointsApprovalToolStripMenuItem.Click += new System.EventHandler(this.pendingPointsApprovalToolStripMenuItem_Click);
            // 
            // pendingContractorsToolStripMenuItem
            // 
            this.pendingContractorsToolStripMenuItem.Image = global::PointsUI.Properties.Resources.Business_Approve_icon;
            this.pendingContractorsToolStripMenuItem.Name = "pendingContractorsToolStripMenuItem";
            this.pendingContractorsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.pendingContractorsToolStripMenuItem.Text = "Pending Contractors Approval";
            this.pendingContractorsToolStripMenuItem.Click += new System.EventHandler(this.pendingContractorsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem.Text = "Exit";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LblUser
            // 
            this.LblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUser.AutoSize = true;
            this.LblUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblUser.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblUser.Location = new System.Drawing.Point(1378, 32);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(133, 25);
            this.LblUser.TabIndex = 3;
            this.LblUser.Text = "User Logged In";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Manage Points Transaction Ver0.9";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingPointsApprovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingContractorsToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel LblUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSDetialsToolStripMenuItem;
    }
}

