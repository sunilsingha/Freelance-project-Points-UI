using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using PointsUI.Classes;

namespace PointsUI
{
    public partial class FrmSupervisor : MetroFramework.Forms.MetroForm
    {
        public FrmSupervisor()
        {
            InitializeComponent();
        }

      
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtBxSupervisorName.Text.Trim().Length == 0)
            {
                TxtBxSupervisorName.Focus();
                MessageBox.Show("Enter Supervisor Name", "Supervisor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Regex r = new Regex("^[a-zA-Z0-9 ]*$");
            if (!r.IsMatch(TxtBxSupervisorName.Text))
            {
                TxtBxSupervisorName.Focus();
                MessageBox.Show("Supervisor Name should not contain special characters", "Supervisor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Supervisor supervisor = new Supervisor
            {
                Name = TxtBxSupervisorName.Text,
                CreatedById = UserLoggedIn.Instance().UserId,
                CreatedOn = DateTime.Now,
                UpdatedById = UserLoggedIn.Instance().UserId,
                UpdatedOn = DateTime.Now

            };

            DBOperations.DBSupervisor.AddSupervisor(supervisor, UserLoggedIn.Instance().UserId);

            loadSupervisors();

            MessageBox.Show("Supervisor added", "Supervisor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmSupervisor_Load(object sender, EventArgs e)
        {
            loadSupervisors();
        }

        void loadSupervisors()
        {
            List<Supervisor> supervisors =  DBOperations.DBSupervisor.getSupervisors();
            GV.Rows.Clear();
            foreach (Supervisor supervisor in supervisors)
            {
                GV.Rows.Add("Delete", supervisor.Name, supervisor.CreatedByUserName, supervisor.CreatedOn,supervisor.Id);
            }
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.Columns[e.ColumnIndex].Name == "ColModify")
            {

            }
            else if (GV.Columns[e.ColumnIndex].Name == "ColDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this User?", "Delete User!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                    
                    try
                    {
                        int id = int.Parse( GV.Rows[e.RowIndex].Cells[4].Value.ToString());
                        DBOperations.DBSupervisor.DeleteSupervisor(UserLoggedIn.Instance().UserId, id);
                        GV.Rows.RemoveAt(e.RowIndex);                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete this record as related record exists!" + Environment.NewLine + ex.Message, "Delete User!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
