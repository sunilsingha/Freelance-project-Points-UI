using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using System.Data.OleDb;
using System.IO;

namespace PointsUI
{
    public class SqlModel : iSql, IDisposable
    {
        static OleDbConnection conn = null;

        OleDbCommand sqlCmd;
        OleDbDataAdapter da;
        OleDbDataReader dr;
        OleDbCommandBuilder cb;
        DataSet ds;
        DataTable dt;
        OleDbTransaction transaction = null;


        public void OpenConnection()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    return;
                }
            }

            conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = PointsUI.Properties.Settings.Default.connnection;
            try
            {
                conn.Open();
                // Insert code to process data.
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to connect to data source" + Environment.NewLine + ex.Message);
            }
        }

        public void CloseConnection()
        {
            if (conn == null) return;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void BeginTransaction()
        {
            if (conn == null) return;

            if (conn.State == ConnectionState.Open)
            {
                if (transaction == null || transaction.Connection == null)
                {
                    transaction = conn.BeginTransaction();
                }
            }
        }

        public void CommitTransaction()
        {
            if (conn == null) return;

            if (conn.State == ConnectionState.Open)
            {
                if (transaction != null)
                {
                    if (transaction.Connection != null)
                    {
                        transaction.Commit();
                    }
                }
            }
        }

        public void RollbackTransaction()
        {
            if (conn == null) return;

            if(conn.State == ConnectionState.Open)
            {
                if(transaction != null)
                {
                    if(transaction.Connection != null)
                    {
                        transaction.Rollback();
                    }
                }
            }
         }

        public DataTable getDatatable(string query)
        {
            try
            {
                OpenConnection();
                sqlCmd = new OleDbCommand(query, conn);
                da = new OleDbDataAdapter(sqlCmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Query failed {0} - {1}", query, ex.Message));
            }
            finally
            {
                //CloseConnection();
            }
            return dt.DefaultView.Table;
        }

        public int QryCommand(string Qry, bool bExecuteScalar, bool blTransaction = false)
        {
            int result;
            try
            {
                OpenConnection();

                if (blTransaction)
                {
                    BeginTransaction();
                }

                sqlCmd = new OleDbCommand(Qry, conn);
                sqlCmd.Transaction = transaction;

                if (bExecuteScalar)
                {
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.CommandText = "Select @@Identity;";
                    result = System.Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
                else
                {
                    result = sqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Query failed {0} - {1}", Qry, ex.Message));
            }
            finally
            {
                //CloseConnection();
            }
            return result;
        }

        public string QryCommandSec(string Qry)
        {
            string str;
            try
            {
                OpenConnection();
                sqlCmd = new OleDbCommand(Qry, conn);
                str = System.Convert.ToString(sqlCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Query failed {0} - {1}", Qry, ex.Message));
            }
            finally
            {
                //CloseConnection();
            }
            return str;
        }

        public DataSet getDataset(string Qry)
        {
            try
            {
                OpenConnection();
                sqlCmd = new OleDbCommand(Qry, conn);
                da = new OleDbDataAdapter(sqlCmd);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                this.CloseConnection();
                throw new Exception(String.Format("Query failed {0} - {1}", Qry, ex.Message));
            }
            finally
            {
                //CloseConnection();
            }
            return ds;
        }

        public void QryUpdateViaDataset(string Qry, ref DataSet dtaSet)
        {
            try
            {
                OpenConnection();
                sqlCmd = new OleDbCommand(Qry, conn);
                da = new OleDbDataAdapter(sqlCmd);
                cb = new OleDbCommandBuilder(da);
                da.Update(dtaSet);
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Query failed {0} - {1}", Qry, ex.Message));
            }
            finally
            {
                //CloseConnection();
            }
        }

        public void QryUpdateContractorAttachment(int contractorId, FileInfo fileInfo)
        {
            string sqlQuery = "";

            try
            {
                OpenConnection();
                sqlQuery = "UPDATE Contractors SET Contractors.IdImage = @file ";
                sqlQuery += "WHERE (((Contractors.Id) = " + contractorId + "));";

                OleDbCommand cmd = new OleDbCommand();
                using (cmd = new OleDbCommand(sqlQuery, conn, transaction))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@file", fileInfo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Query failed {0} - {1}", sqlQuery, ex.Message));
            }
            finally
            {
                //CloseConnection();
            }
        }

        public DataSet getDatasetFromStroedProcedure(string ColumnName, string SearchString)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
