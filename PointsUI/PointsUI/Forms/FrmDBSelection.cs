using System;
using System.Windows.Forms;

namespace PointsUI
{
    public partial class FrmDBSelection : MetroFramework.Forms.MetroForm
    {
        public FrmDBSelection()
        {
            InitializeComponent();
        }

        public string DBpath = string.Empty;
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DBpath = openFileDialog1.FileName;
                TxtBxDBPath.Text = DBpath;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (DBpath == string.Empty)
            {
                DialogResult = DialogResult.None;
            }
        }

        private void FrmDBSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DBpath == string.Empty)
            {
                DialogResult = DialogResult.None;
                System.Environment.Exit(1);
            }
          
        }
    }
}
