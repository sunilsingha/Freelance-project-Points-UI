using System.Data;

namespace PointsUI
{
    public interface iSql
    {
        void OpenConnection();
        void CloseConnection();
        DataTable getDatatable(string query);
        int QryCommand(string Qry, bool bExecuteScalar,bool blTransaction);
        string QryCommandSec(string Qry);
        DataSet getDataset(string Qry);
        void QryUpdateViaDataset(string Qry, ref DataSet dtaSet);
        DataSet getDatasetFromStroedProcedure(string ColumnName, string SearchString);
    }
}
