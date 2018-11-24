namespace PointsUI
{
    partial class FrmDBSelection
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBxDBPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnBrowse = new MetroFramework.Controls.MetroButton();
            this.BtnOk = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PointsUI.Properties.Resources.DB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBxDBPath
            // 
            // 
            // 
            // 
            this.TxtBxDBPath.CustomButton.Image = null;
            this.TxtBxDBPath.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.TxtBxDBPath.CustomButton.Name = "";
            this.TxtBxDBPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxDBPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxDBPath.CustomButton.TabIndex = 1;
            this.TxtBxDBPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxDBPath.CustomButton.UseSelectable = true;
            this.TxtBxDBPath.CustomButton.Visible = false;
            this.TxtBxDBPath.Enabled = false;
            this.TxtBxDBPath.Lines = new string[0];
            this.TxtBxDBPath.Location = new System.Drawing.Point(246, 96);
            this.TxtBxDBPath.MaxLength = 32767;
            this.TxtBxDBPath.Name = "TxtBxDBPath";
            this.TxtBxDBPath.PasswordChar = '\0';
            this.TxtBxDBPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxDBPath.SelectedText = "";
            this.TxtBxDBPath.SelectionLength = 0;
            this.TxtBxDBPath.SelectionStart = 0;
            this.TxtBxDBPath.ShortcutsEnabled = true;
            this.TxtBxDBPath.Size = new System.Drawing.Size(327, 23);
            this.TxtBxDBPath.TabIndex = 1;
            this.TxtBxDBPath.UseSelectable = true;
            this.TxtBxDBPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxDBPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(147, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Database path";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowse.Location = new System.Drawing.Point(579, 96);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(26, 23);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseSelectable = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(176, 146);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(292, 23);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseSelectable = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select Database file";
            this.openFileDialog1.Filter = "\"MS Access (*.accdb)|*accdb";
            // 
            // FrmDBSelection
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 201);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtBxDBPath);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDBSelection";
            this.Text = "Select Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDBSelection_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox TxtBxDBPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnBrowse;
        private MetroFramework.Controls.MetroButton BtnOk;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}