using System.Data.SqlClient;

namespace DatabaseConnection.Interfaces
{
    public interface ITableInterface
    {
        void SetConnection(SqlConnection connection);
        void AddElementsToTable(SqlCommand sqlCommand);
    }
}