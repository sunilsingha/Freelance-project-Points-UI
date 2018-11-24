using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace PointsUI.DBOperations
{
    class DBContractor
    {
        public static List<Contractor> getContractors()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryContractors;";

            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<Contractor> lstContractor = new List<Contractor>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstContractor.Add(getContractorObject(row));
            }

            sqlModel.CloseConnection();
            return lstContractor;
        }

        public static Contractor getContractorbyId(int ContractorId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryContractors WHERE(((qryContractors.Id) = " + ContractorId + "));";
            DataSet ds = sqlModel.getDataset(sqlQuery);

            sqlModel.CloseConnection();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            return getContractorObject(ds.Tables[0].Rows[0]);
        }

        public static List<Contractor> getPendingApprovalContractors()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT  * FROM qryContractors ";
            sqlQuery += "WHERE (((IsCreatedByAdmin) = False) AND ((IsApprovedByAdmin) = False)); ";

            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<Contractor> lstContractor = new List<Contractor>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstContractor.Add(getContractorObject(row));
            }

            sqlModel.CloseConnection();
            return lstContractor;
        }

        public static List<Contractor> getApprovedContractors()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryContractors ";
            sqlQuery += "WHERE (((qryContractors.IsApprovedByAdmin) = True)) OR(((qryContractors.IsCreatedByAdmin) = True));";

            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<Contractor> lstContractor = new List<Contractor>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstContractor.Add(getContractorObject(row));
            }

            sqlModel.CloseConnection();
            return lstContractor;
        }

        public static Contractor getContractorObject(DataRow row)
        {
            Contractor contractor = new Contractor();
            foreach (DataColumn column in row.Table.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            contractor.ID = int.Parse(row["Id"].ToString());
            contractor.CreatedOn = Convert.ToDateTime(row["CreatedOn"].ToString());
            contractor.CreatedById = int.Parse(row["CreatedByUserId"].ToString());
            contractor.CreatedByUserName = row["CreatedUserName"].ToString();
            contractor.UpdatedOn = Convert.ToDateTime(row["UpdatedOn"].ToString());
            contractor.UpdatedById = int.Parse(row["UpdatedByUserId"].ToString());
            contractor.UpdatedByUserName = row["UpdatedUserName"].ToString();
            contractor.ContractorNo = row["ContractorNo"].ToString();
            contractor.Name = row["ContractorName"].ToString();
            contractor.MobileNumber = row["MobileNumber"].ToString();
            contractor.Address = row["Address"].ToString();
            contractor.IdType = row["IdType"].ToString();
            contractor.SupervisorId = int.Parse(row["SupervisorId"].ToString());
            contractor.SupervisorName = row["SupervisorName"].ToString();
            //contractor.ImageFileDataInBytes = (byte[])(row["myImage"]) ;

            contractor.ImageBase64 = row["myNewImage"].ToString();

            if (row["IsCreatedByUser"].ToString() == "True")
            {
                contractor.IsCreatedByUser = true;
            }
            else
            {
                contractor.IsCreatedByUser = false;
            }

            if (row["IsCreatedByAdmin"].ToString() == "True")
            {
                contractor.IsCreatedByAdmin = true;
            }
            else
            {
                contractor.IsCreatedByAdmin = false;
            }

            if (row["IsApprovedByAdmin"].ToString() == "True")
            {
                contractor.IsApprovedByAdmin = true;
            }
            else
            {
                contractor.IsApprovedByAdmin = false;
            }

            if (row["ApprovedByUserId"].ToString() != "")
            {
                contractor.ApprovedByUserId = int.Parse(row["ApprovedByUserId"].ToString());
            }
            if (row["ApprovedOn"].ToString() != "")
            {
                contractor.ApprovedOn = Convert.ToDateTime(row["ApprovedOn"].ToString());
            }

            contractor.ApprovedUserName = row["ApprovedUserName"].ToString();
            //contractor.ImageFileDataInBytes = (byte[])row["ImageFileData"];
            contractor.ImageFileName = row["ImageFileName"].ToString();
            contractor.ImageFileType = row["ImageFileType"].ToString();
            contractor.Status = row["Status"].ToString();

            return contractor;
        }

        public static bool ContractorIdExists(int ContractorId)
        {
            SqlModel sqlmodel = new SqlModel();

            string sqlQuery = "SELECT Count(*) AS [Count] ";
            sqlQuery += "FROM qryContractors ";
            sqlQuery += "WHERE (((qryContractors.Id) = " + ContractorId + ")); ";

            DataSet ds = sqlmodel.getDataset(sqlQuery);
            int count = int.Parse(ds.Tables[0].Rows[0]["Count"].ToString());

            sqlmodel.CloseConnection();

            if (count > 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsContractorApproved(int ContractorId)
        {
            SqlModel sqlmodel = new SqlModel();

            string sqlQuery = "SELECT Count(*) AS [Count] ";
            sqlQuery += "FROM qryContractors ";
            sqlQuery += "WHERE (((Contractors.Id)=" + ContractorId + ") AND  ((Contractors.IsCreatedByAdmin)=True) OR ((Contractors.IsApprovedByAdmin)=True))); ";

            DataSet ds = sqlmodel.getDataset(sqlQuery);
            int count = int.Parse(ds.Tables[0].Rows[0]["Count"].ToString());

            sqlmodel.CloseConnection();

            if (count > 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsContractorMobileNumberUnique(string MobileNumber, int ContractorId)
        {
            SqlModel sqlModel = new SqlModel();

            string sqlQuery = "SELECT Count(*) as Count ";
            sqlQuery += "FROM qryContractors ";
            sqlQuery += "WHERE (((qryContractors.MobileNumber) = '" + MobileNumber.Trim() + "') AND((qryContractors.Id) <> " + ContractorId + "));";
            DataSet ds = sqlModel.getDataset(sqlQuery);

            sqlModel.CloseConnection();

            if (ds.Tables[0].Rows[0]["Count"].ToString() != "0")
            {
                return true;
            }

            return false;
        }

        public static string AddContractor(Contractor contractor, int UserId, FileInfo fileInfo = null)
        {
            bool blAdmin = DBUser.IsUserAdmin(UserId);

            SqlModel sqlmodel = new SqlModel();

            string sqlFields = "";
            string sqlValues = "";

            sqlFields = "CreatedOn, ";
            sqlValues = "Now(), ";

            sqlFields += "CreatedByUserId, ";
            sqlValues += UserId + ", ";

            sqlFields += "UpdatedOn, ";
            sqlValues += "Now(), ";

            sqlFields += "UpdatedByUserId, ";
            sqlValues += UserId + ", ";

            sqlFields += "ContractorNo, ";
            sqlValues += "'" + Guid.NewGuid().ToString() + "', ";   //Modify this value

            sqlFields += "ContractorName, ";
            sqlValues += "'" + contractor.Name + "', ";

            sqlFields += "MobileNumber, ";
            sqlValues += "'" + contractor.MobileNumber + "', ";

            sqlFields += "Address, ";
            sqlValues += "'" + contractor.Address + "', ";

            sqlFields += "IdType, ";
            sqlValues += "'" + contractor.IdType + "', ";

            sqlFields += "myNewImage, ";
            sqlValues += "'" + contractor.ImageBase64 + "', ";

            sqlFields += "SupervisorId, ";
            sqlValues += contractor.SupervisorId + ", ";

            if (blAdmin == false)
            {
                sqlFields += "IsCreatedByUser";
                sqlValues += "True";
            }
            else
            {
                sqlFields += "IsCreatedByAdmin";
                sqlValues += "True";
            }

            //Add contractor details
            string sqlQuery = "INSERT INTO Contractors ( " + sqlFields + ") Values(" + sqlValues + ");";

            int ContractorId = sqlmodel.QryCommand(sqlQuery, true, true);

            string strContractorNo = getContractorNo(ContractorId);

            sqlQuery = "UPDATE Contractors SET ";
            sqlQuery += "Contractors.ContractorNo = '" + strContractorNo + "', ";
            sqlQuery += "Contractors.UpdatedOn = Now(), ";
            sqlQuery += "Contractors.UpdatedByUserId = " + UserId + " ";
            sqlQuery += "WHERE (((Contractors.Id) = " + ContractorId + ")); ";

            sqlmodel.QryCommand(sqlQuery, false, true);

            if (fileInfo != null)
            {
                sqlmodel.QryUpdateContractorAttachment(ContractorId, fileInfo);
            }

            sqlmodel.CommitTransaction();
            sqlmodel.CloseConnection();

            return "Added";
        }

        public static string UpdateContractor(Contractor contractor, int UserId, FileInfo fileInfo = null)
        {
            SqlModel sqlmodel = new SqlModel();

            string sqlQuery = "UPDATE Contractors SET ";

            sqlQuery += "Contractors.UpdatedOn = Now(), ";
            sqlQuery += "Contractors.UpdatedByUserId = " + UserId + ", ";

            sqlQuery += "Contractors.ContractorName = '" + contractor.Name + "', ";
            sqlQuery += "Contractors.MobileNumber = '" + contractor.MobileNumber + "', ";
            sqlQuery += "Contractors.Address = '" + contractor.Address + "', ";
            sqlQuery += "Contractors.IdType = '" + contractor.IdType + "', ";
            sqlQuery += "Contractors.SupervisorId = " + contractor.SupervisorId + ", ";
            sqlQuery += "Contractors.myNewImage = '" + contractor.ImageBase64 + "' ";

       

            sqlQuery += "WHERE (((Contractors.Id) = " + contractor.ID + "));";

            sqlmodel.QryCommand(sqlQuery, true, true);

            if (fileInfo != null)
            {
                sqlmodel.QryUpdateContractorAttachment(contractor.ID, fileInfo);
            }

            sqlmodel.CommitTransaction();
            sqlmodel.CloseConnection();

            return "Updated";
        }

        public static void ApproveContractor(int ContractorId, int UserId)
        {
            SqlModel sqlmodel = new SqlModel();

            string sqlQuery = "UPDATE Contractors SET ";
            sqlQuery += "Contractors.IsApprovedByAdmin= True, ";
            sqlQuery += "Contractors.ApprovedOn = Now(), ";
            sqlQuery += "Contractors.UpdatedOn = Now(), ";
            sqlQuery += "Contractors.UpdatedByUserId = " + UserId + ", ";
            sqlQuery += "Contractors.ApprovedByUserId = " + UserId + " ";
            sqlQuery += "WHERE(((Contractors.Id) = " + ContractorId + ")); ";

            sqlmodel.QryCommand(sqlQuery, true);
            sqlmodel.CloseConnection();
        }

        public static void DeleteContractor(int ContractorId)
        {
            SqlModel sqlmodel = new SqlModel();

            string sqlQuery = "DELETE FROM Contractors WHERE (((Contractors.Id) = " + ContractorId + "));";

            sqlmodel.QryCommand(sqlQuery, true);
            sqlmodel.CloseConnection();
        }

        public static List<Contractor> SearchContractor(string ContractorName, string MobileNumber, string ContractorNo, string SupervisorName)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlConditions = "";
            string sqlQuery = "SELECT * FROM qryContractors ";

            if (ContractorName != "")
            {
                if (sqlConditions == "")
                {
                    sqlConditions = "Where ";
                }
                else
                {
                    sqlConditions += "OR ";
                }
                sqlConditions += "((qryContractors.ContractorName) Like '%" + ContractorName + "%') ";
            }

            if (MobileNumber != "")
            {
                if (sqlConditions == "")
                {
                    sqlConditions = "Where ";
                }
                else
                {
                    sqlConditions += "OR ";
                }
                sqlConditions += "((qryContractors.MobileNumber) = '" + MobileNumber + "') ";
            }

            if (ContractorNo != "")
            {
                if (sqlConditions == "")
                {
                    sqlConditions = "Where ";
                }
                else
                {
                    sqlConditions += "OR ";
                }
                sqlConditions += "((qryContractors.ContractorNo) = '" + ContractorNo + "') ";
            }

            if (SupervisorName != "")
            {
                if (sqlConditions == "")
                {
                    sqlConditions = "Where ";
                }
                else
                {
                    sqlConditions += "OR ";
                }
                sqlConditions += "((qryContractors.SupervisorName) Like '%" + SupervisorName + "%') ";
            }

            sqlQuery += sqlConditions;

            DataSet ds = sqlModel.getDataset(sqlQuery);

            List<Contractor> lstContractor = new List<Contractor>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstContractor.Add(getContractorObject(row));
            }

            sqlModel.CloseConnection();
            return lstContractor;
        }

        private static string getContractorNo(int ContractorId)
        {
            string strContractor = "";
            string strContractorId = ContractorId.ToString();
            int times = 6 - strContractorId.Length;

            for (int i = 0; i < times; i++)
            {
                strContractor += "0";
            }
            strContractor += strContractorId;

            return strContractor;
        }
    }
}
