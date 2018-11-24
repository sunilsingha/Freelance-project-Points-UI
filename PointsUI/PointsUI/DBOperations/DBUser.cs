using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.Data;

namespace PointsUI.DBOperations
{
    class DBUser
    {
        public static List<User> GetUsers()
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryUsers WHERE (((qryUsers.DeletedOn) Is Null));";

            List<User> lstUsers = new List<User>();
            DataSet ds = sqlModel.getDataset(sqlQuery);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstUsers.Add(getUserObject(row));
            }

            sqlModel.CloseConnection();
            return lstUsers;
        }

        public static User getUserById(int UserId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "SELECT * FROM qryUsers ";
            sqlQuery += "WHERE (((qryUsers.DeletedOn)Is Null) AND((qryUsers.ID) = " + UserId + ")); ";
            DataSet ds = sqlModel.getDataset(sqlQuery);

            sqlModel.CloseConnection();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            return getUserObject(ds.Tables[0].Rows[0]);
        }

        public static User getUserObject(DataRow row)
        {
            User user = new User();

            user.ID = int.Parse(row["ID"].ToString());
            user.UserName = row["UserName"].ToString();

            user.IsAdmin = false;
            if (row["IsAdmin"].ToString() == "True")
            {
                user.IsAdmin = true;
            }
            
            user.IsSuperUser = false;
            if (row["IsSuperUser"].ToString() == "True")
            {
                user.IsSuperUser = true;
            }        

            user.CreatedOn = Convert.ToDateTime(row["CreatedOn"].ToString());
            user.CreatedById = int.Parse(row["CreatedById"].ToString());
            user.UpdatedOn = Convert.ToDateTime(row["UpdatedOn"].ToString());
            user.UpdatedById = int.Parse(row["UpdatedById"].ToString());

            user.CreatedByUserName = row["CreatedUserName"].ToString();
            user.UpdatedByUserName = row["UpdatedUserName"].ToString();

            return user;
        }

        public static bool IsUserNameUnique(string UserName,int UserId)
        {
            SqlModel sqlModel = new SqlModel();

            bool blUnique = true;
            string sqlQuery = "SELECT Count(*) AS [Count] FROM Users ";
            sqlQuery += "WHERE (((Trim(LCase([Users].[UserName]))) = LCase(Trim('" + UserName  + "'))) ";
            sqlQuery += " AND ((Users.DeletedOn) Is Null) AND ";
            sqlQuery += " ((Users.ID) <> " + UserId + "));";

            DataSet ds = sqlModel.getDataset(sqlQuery);
            if (int.Parse(ds.Tables[0].Rows[0]["Count"].ToString()) > 0)
            {
                blUnique = false;
            }

            sqlModel.CloseConnection();

            return blUnique;
        }

        public static bool checkPasswordMatched(int userId, string password)
        {
            SqlModel sqlModel = new SqlModel();
            

            string sqlQuery = "SELECT Count(*) as [Count] FROM Users ";
            sqlQuery += "WHERE(((Users.Password) = '" + password + "') AND ";
            sqlQuery += "((Users.ID) = " + userId + ")  AND ";
            sqlQuery += "((Users.DeletedOn) Is Null)); ";

            DataSet ds = sqlModel.getDataset(sqlQuery);

            sqlModel.CloseConnection();

            if (ds.Tables[0].Rows[0]["Count"].ToString() == "0")
            {
                return false;
            }
            return true;
        }

        public static void InsertUser(User user, int UserId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlFields = "";
            string sqlValues = "";

            sqlFields = "CreatedOn, ";
            sqlValues = "Now(), ";

            sqlFields += "CreatedById, ";
            sqlValues += UserId + ", ";

            sqlFields += "UpdatedOn, ";
            sqlValues += "Now(), ";

            sqlFields += "UpdatedById, ";
            sqlValues += UserId + ", ";

            sqlFields += "UserName, ";
            sqlValues += "'" + user.UserName + "', ";

            sqlFields += "[Password], ";
            sqlValues += "'" + user.Password + "', ";

            sqlFields += "IsAdmin, ";
            if (user.IsAdmin)
            {
                sqlValues += "True, ";
            }
            else
            {
                sqlValues += "False, ";
            }

            sqlFields += "IsSuperUser ";
            if (user.IsSuperUser)
            {
                sqlValues += "True ";
            }
            else
            {
                sqlValues += "False ";
            }

            string sqlQuery = "INSERT INTO Users (" + sqlFields + ") Values(" + sqlValues + ");";
            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void UpdateUser(User user, int UserId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "UPDATE Users SET Users.UserName = '" + user.UserName + "', ";
            sqlQuery += "Users.IsAdmin = "+ user.IsAdmin.ToString() + ", Users.IsSuperUser = " + user.IsSuperUser.ToString() + ", Users.UpdatedOn = Now(), Users.UpdatedById = " + UserId + " ";
            sqlQuery += "WHERE(((Users.ID) = " + user.ID + "));";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void UpdatePasswordForUser(User user, int UserId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "UPDATE Users SET Users.[Password] = '" + user.Password + "', ";
            sqlQuery += "Users.UpdatedOn = Now(), Users.UpdatedById = " + UserId + " ";
            sqlQuery += "WHERE(((Users.ID) = " + user.ID + ")); ";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static void DeleteUser(int DeleteUserId, int UserId)
        {
            SqlModel sqlModel = new SqlModel();
            string sqlQuery = "UPDATE Users SET Users.DeletedOn = Now(), Users.DeletedById = " + UserId + " ";
            sqlQuery += "WHERE(((Users.ID) = " + DeleteUserId + "));";

            sqlModel.QryCommand(sqlQuery, true);
            sqlModel.CloseConnection();
        }

        public static string getUserType(int UserId, bool CheckSuperUser = false)
        {
            SqlModel sqlmodel = new SqlModel();

            //Get user type
            string sqlQuery = "SELECT qryUsers.IsAdmin ";
            if (CheckSuperUser)
            {
                sqlQuery = "SELECT qryUsers.IsSuperUser ";
            }
            sqlQuery += "FROM qryUsers ";
            sqlQuery += "WHERE(((qryUsers.ID) = " + UserId + ") AND((qryUsers.DeletedOn)Is Null)); ";
            DataSet ds = sqlmodel.getDataset(sqlQuery);

            if (ds.Tables[0].Rows.Count == 0)
            {
                sqlmodel.CloseConnection();
                throw new Exception("User data not found");
            }

            //Check user type
            bool blAdmin = false;
            bool blSuperUser = false;

            if (CheckSuperUser)
            {
                if (ds.Tables[0].Rows[0]["IsSuperUser"].ToString() == "True")
                {
                    blSuperUser = true;
                }

            }
            else
            {
                if (ds.Tables[0].Rows[0]["IsAdmin"].ToString() == "True")
                {
                    blAdmin = true;
                }
            }
            
            sqlmodel.CloseConnection();

            if (blAdmin)
            {
                return "Admin";
            }
            else if (blSuperUser)
            {
                return "SuperUser";
            }
            else
            {
                return "User";
            }
        }

        public static bool IsUserAdmin(int UserId)
        {
            string strUserType = getUserType(UserId);

            if (strUserType == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsUserSuperUser(int UserId)
        {
            string strUserType = getUserType(UserId, true);

            if (strUserType == "SuperUser")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
