using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.Data;

namespace PointsUI.DBOperations
{
    class DBPoints
    {
        public static List<PointsTransaction> getPoints()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryPointsTransactions; ";

            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<PointsTransaction> lstPointsTransactions = new List<PointsTransaction>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstPointsTransactions.Add(getPointsTransactionObject(row));
            }

            sqlModel.CloseConnection();
            return lstPointsTransactions;
        }

        public static List<PointsTable> getPointsTale()
        {
            List<PointsTable> pointsTables = new List<PointsTable>();

            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryTotalPoints; ";

            DataSet ds = sqlModel.getDataset(sqlQuery);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                pointsTables.Add(getTotalPointsObject(row));
            }

            sqlModel.CloseConnection();
            return pointsTables;
        }



        public static PointsTransaction getPointsTransactionById(int PointsTransactionId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryPointsTransactions WHERE(((qryPointsTransactions.ID) = " + PointsTransactionId + ")); ";
            DataSet ds = sqlModel.getDataset(sqlQuery);

            sqlModel.CloseConnection();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            return getPointsTransactionObject(ds.Tables[0].Rows[0]);
        }

        public static List<PointsTransaction> getPointsTransactionPendingForApproval()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryPointsTransactions ";
            sqlQuery += "WHERE (((qryPointsTransactions.IsCreatedByAdmin) = False) AND((qryPointsTransactions.IsApprovedByAdmin) = False));";

            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<PointsTransaction> lstPointsTransactions = new List<PointsTransaction>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstPointsTransactions.Add(getPointsTransactionObject(row));
            }

            sqlModel.CloseConnection();
            return lstPointsTransactions;
        }

        public static List<PointsTransaction> getApprovedPointsTransactions()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryPointsTransactions ";
            sqlQuery += "WHERE (((qryPointsTransactions.IsApprovedByAdmin) = True)) OR(((qryPointsTransactions.IsCreatedByAdmin) = True));";

            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<PointsTransaction> lstPointsTransactions = new List<PointsTransaction>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstPointsTransactions.Add(getPointsTransactionObject(row));
            }

            sqlModel.CloseConnection();
            return lstPointsTransactions;
        }

        /// <summary>
        /// Returns totalpoints
        /// </summary>
        /// <param name="ContractorNo">Contractor ID</param>
        /// <returns></returns>
        public static int GetTotalPointsbyName(string ContractorNo)
        {
            int totalPoints = 0;
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryTotalPoints where ContractorNo = '" + ContractorNo + "'";

            DataSet ds = sqlModel.getDataset(sqlQuery);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                totalPoints  = int.Parse(row["InPoints"].ToString());
            }
            return totalPoints;
        }

        public static PointsTable getTotalPointsObject(DataRow row)
        {
            PointsTable pointsTable = new PointsTable();
            foreach (DataColumn column in row.Table.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            pointsTable.ContractorId = int.Parse(row["ContractorID"].ToString());
            pointsTable.ContractorNo = row["ContractorNo"].ToString();
            pointsTable.ContractorName = row["ContractorName"].ToString();
            pointsTable.PhoneNo = row["PhoneNo"].ToString();
            pointsTable.TotalAsiaLitres = int.Parse(row["TotalAsianLitres"].ToString());
            pointsTable.TotalAppoloLitres = int.Parse(row["TotalApolloLitres"].ToString());
            pointsTable.TotalKgs = int.Parse(row["TotalKgs"].ToString());
            pointsTable.Points = int.Parse(row["Points"].ToString());
            pointsTable.InPoints = int.Parse(row["InPoints"].ToString());
          
            return pointsTable;
        }

        public static PointsTransaction getPointsTransactionObject(DataRow row)
        {
            PointsTransaction pointsTransaction = new PointsTransaction();
            foreach (DataColumn column in row.Table.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            pointsTransaction.ID = int.Parse(row["ID"].ToString());
            pointsTransaction.CreatedOn = Convert.ToDateTime(row["CreatedOn"].ToString());
            pointsTransaction.CreatedById = int.Parse(row["CreatedByUserId"].ToString());
            pointsTransaction.CreatedByUserName = row["CreatedByUserName"].ToString();
            pointsTransaction.UpdatedOn = Convert.ToDateTime(row["UpdatedOn"].ToString());
            pointsTransaction.UpdatedById = int.Parse(row["UpdatedById"].ToString());
            pointsTransaction.UpdatedByUserName = row["UpdatedByUserName"].ToString();
            pointsTransaction.TransactionDate = Convert.ToDateTime(row["TransactionDate"].ToString());
            pointsTransaction.VoucherNo = row["VoucherNo"].ToString();
            pointsTransaction.Kgs = double.Parse(row["Kgs"].ToString());
            pointsTransaction.AsianLitres = double.Parse(row["AsianLitres"].ToString());
            pointsTransaction.ApolloLitres = double.Parse(row["ApolloLitres"].ToString());
            pointsTransaction.ContractorId = int.Parse(row["ContractorID"].ToString());

            if (row["IsCreatedByUser"].ToString() == "True")
            {
                pointsTransaction.IsCreatedByUser = true;
            }
            else
            {
                pointsTransaction.IsCreatedByUser = false;
            }

            if (row["IsCreatedByAdmin"].ToString() == "True")
            {
                pointsTransaction.IsCreatedByAdmin = true;
            }
            else
            {
                pointsTransaction.IsCreatedByAdmin = false;
            }

            if (row["IsApprovedByAdmin"].ToString() == "True")
            {
                pointsTransaction.IsApprovedByAdmin = true;
            }
            else
            {
                pointsTransaction.IsApprovedByAdmin = false;
            }

            pointsTransaction.ApprovedUserName = row["ApprovedUserName"].ToString();
            pointsTransaction.ContractorName = row["ContractorName"].ToString();
            pointsTransaction.SupervisorName = row["SupervisorName"].ToString();
            pointsTransaction.ContractorPhoneNumber = row["ContractorMobileNumber"].ToString();
            pointsTransaction.ContractorNo = row["ContractorNo"].ToString();
            pointsTransaction.Status = row["Status"].ToString();

            return pointsTransaction;
        }

        public static void AddPoint(PointsTransaction pointsTransaction, int UserId)
        {
            bool blAdmin = UserLoggedIn.Instance().IsAdmin;

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

            sqlFields += "TransactionDate, ";
            sqlValues += "Now(), ";

            sqlFields += "VoucherNo, ";
            sqlValues += "'" + pointsTransaction.VoucherNo + "', ";

            sqlFields += "Kgs, ";
            sqlValues += pointsTransaction.Kgs + ", ";

            sqlFields += "AsianLitres, ";
            sqlValues += pointsTransaction.AsianLitres + ", ";

            sqlFields += "ApolloLitres, ";
            sqlValues += pointsTransaction.ApolloLitres + ", ";

            sqlFields += "ContractorID, ";
            sqlValues += pointsTransaction.ContractorId + ", ";

            if (blAdmin == false)
            {
                sqlFields += "IsCreatedByUser ";
                sqlValues += "True ";
            }
            else
            {
                sqlFields += "IsCreatedByAdmin ";
                sqlValues += "True ";
            }

            //Fields
            string sqlQuery = "INSERT INTO PointsTransactions ( " + sqlFields + ") Values(" + sqlValues + ");";
            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void UpdatePoint(PointsTransaction pointsTransaction, int UserId)
        {
            SqlModel sqlModel = new SqlModel();

            string sqlQuery = "UPDATE PointsTransactions SET ";
            sqlQuery += "PointsTransactions.VoucherNo = '" + pointsTransaction.VoucherNo + "', ";
            sqlQuery += "PointsTransactions.Kgs = " + pointsTransaction.Kgs + ", ";
            sqlQuery += "PointsTransactions.AsianLitres = " + pointsTransaction.AsianLitres + ", ";
            sqlQuery += "PointsTransactions.ApolloLitres = " + pointsTransaction.ApolloLitres + ", ";
            sqlQuery += "PointsTransactions.UpdatedOn = Now(), ";
            sqlQuery += "PointsTransactions.UpdatedById = " + UserId + " ";
            sqlQuery += "WHERE (((PointsTransactions.ID) = " + pointsTransaction.ID + "));";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void ApprovePoint(int PointsTransactionId, int UserId)
        {
            SqlModel sqlModel = new SqlModel();

            string sqlQuery = "UPDATE PointsTransactions SET ";
            sqlQuery += "PointsTransactions.ApprovedOn = Now(), ";
            sqlQuery += "PointsTransactions.ApprovedByUserId = " + UserId + ", ";
            sqlQuery += "PointsTransactions.IsApprovedByAdmin = True, ";
            sqlQuery += "PointsTransactions.UpdatedOn = Now(), ";
            sqlQuery += "PointsTransactions.UpdatedById = " + UserId + " ";
            sqlQuery += "WHERE(((PointsTransactions.ID) = " + PointsTransactionId + ")); ";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void DeletePoint(int PointsTransactionId)
        {
            SqlModel sqlModel = new SqlModel();

            string sqlQuery = "DELETE FROM PointsTransactions WHERE(((PointsTransactions.ID) = " + PointsTransactionId + ")); ";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }
    }
}
