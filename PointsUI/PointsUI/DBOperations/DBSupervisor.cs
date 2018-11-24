using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.Data;

namespace PointsUI.DBOperations
{
    class DBSupervisor
    {
        public static List<Supervisor> getSupervisors()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qrySupervisors;";
            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<Supervisor> lstSupervisor = new List<Supervisor>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstSupervisor.Add(getSupervisorObject(row));
            }

            sqlModel.CloseConnection();

            return lstSupervisor;
        }

        public static Supervisor getSupervisorById(int SupervisorId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qrySupervisors WHERE (((qrySupervisors.ID)=" + SupervisorId + "));;";
            DataSet ds = sqlModel.getDataset(sqlQuery);

            sqlModel.CloseConnection();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            return getSupervisorObject(ds.Tables[0].Rows[0]);
        }

        public static Supervisor getSupervisorObject(DataRow row)
        {
            Supervisor supervisor = new Supervisor();

            supervisor.Id = int.Parse(row["ID"].ToString());
            supervisor.Name = row["SupervisorName"].ToString();

            supervisor.CreatedOn = Convert.ToDateTime(row["CreatedOn"].ToString());
            supervisor.CreatedById = int.Parse(row["CreatedByUserId"].ToString());
            supervisor.CreatedByUserName = row["CreatedByUserName"].ToString();

            supervisor.UpdatedOn = Convert.ToDateTime(row["UpdatedOn"].ToString());
            supervisor.UpdatedById = int.Parse(row["UpdatedById"].ToString());
            supervisor.UpdatedByUserName = row["UpdatedUserName"].ToString();

            return supervisor;
        }

        public static bool IsSupervisorNameUnique(string SupervisorName)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT Count(*) AS [Count] FROM Supervisors ";
            sqlQuery += "WHERE LCase(Trim((Supervisors.SupervisorName))) = LCase(Trim('" + SupervisorName + "'));";
            DataSet ds = sqlModel.getDataset(sqlQuery);

            sqlModel.CloseConnection();

            if (ds.Tables[0].Rows[0]["Count"].ToString() != "0")
            {
                return true;
            }

            return false;
        }

        public static void AddSupervisor(Supervisor supervisor, int UserId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlFields = "";
            string sqlValues = "";

            sqlFields = "CreatedOn, ";
            sqlValues = "Now(), ";

            sqlFields += "CreatedByUserId, ";
            sqlValues += UserId + ", ";

            sqlFields += "UpdatedOn, ";
            sqlValues += "Now(), ";

            sqlFields += "UpdatedById, ";
            sqlValues += UserId + ", ";

            sqlFields += "SupervisorName";
            sqlValues += "'" + supervisor.Name + "' ";


            string sqlQuery = "INSERT INTO Supervisors(" + sqlFields + ") Values(" + sqlValues + ");";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void UpdateSupervisor(Supervisor supervisor, int UserId)
        {
            SqlModel sqlModel = new SqlModel();

            string sqlQuery = "UPDATE Supervisors SET ";
            sqlQuery += "Supervisors.SupervisorName = '" + supervisor.Name + "', ";
            sqlQuery += "Supervisors.UpdatedOn = Now(), Supervisors.UpdatedById = " + UserId + " ";
            sqlQuery += "WHERE(((Supervisors.ID) = " + supervisor.Id + "));";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void DeleteSupervisor(int UserId, int SupervisorId)
        {
            SqlModel sqlModel = new SqlModel();

            string sqlQuery = "DELETE FROM Supervisors WHERE(((Supervisors.ID) = " + SupervisorId + "));";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

    }
}
