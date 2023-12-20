using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnection.Interfaces
{
    public abstract class TableInteraction : Form
    {
        private SqlConnection _connection;

        protected void SetConnection(SqlConnection connection)
        {
            _connection = connection;
        }
        public abstract void AddElementsToTable(SqlCommand sqlCommand);
    }
}