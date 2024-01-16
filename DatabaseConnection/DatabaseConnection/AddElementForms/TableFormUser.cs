using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormUser : Form, ITableInterface
    {
        private SqlConnection _connection;

        public TableFormUser()
        {
            InitializeComponent();
            Show(Parent);
        }

        public void SetConnection(SqlConnection connection)
        {
            _connection = connection;
        }

        public void AddElementsToTable(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@Value1", IDBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value2", NameBox.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void SendDataToKorisnik_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO Korisnik VALUES (@Value1, @Value2)";
            var insertIntoTable = new SqlCommand(query, _connection);
            if (IDBox.Text.Equals("") | NameBox.Text.Equals(""))
            {
                MessageBox.Show("Molim unseite polja!");
                return;
            }

            AddElementsToTable(insertIntoTable);
            MessageBox.Show("Uspješno dodan zapis!");
            NameBox.Text = "";
            IDBox.Text = "";
        }
    }
}