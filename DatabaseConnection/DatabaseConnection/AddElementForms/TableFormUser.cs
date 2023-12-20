using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormUser : Form
    {
        private SqlConnection _connection;
        
        public TableFormUser()
        {
            InitializeComponent();
        }

        public void SetConnection(SqlConnection connection)
        {
            _connection = connection;
        }
        
        private void SendDataToKorisnik_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Korisnik VALUES (@Value1, @Value2)";
            SqlCommand insertIntoTable = new SqlCommand(query, _connection);
            insertIntoTable.Parameters.AddWithValue("@Value1", IDBox.Text);
            insertIntoTable.Parameters.AddWithValue("@Value2", NameBox.Text);
            Console.WriteLine("Number of rows affected: " + insertIntoTable.ExecuteNonQuery());
        }
    }
}