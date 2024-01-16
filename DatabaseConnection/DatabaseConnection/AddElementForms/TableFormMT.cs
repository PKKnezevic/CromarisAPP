using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormMT : Form, ITableInterface
    {
        private SqlConnection _connection;
        
        public TableFormMT()
        {
            InitializeComponent();
            Show(Parent);
        }
        private void addMT_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MT VALUES (@Value1, @Value2)";
            SqlCommand insertIntoTable = new SqlCommand(query, _connection);
            if (SAPbox.Text.Equals("") | NameBox.Text.Equals(""))
            {
                MessageBox.Show("Molim unseite polja!");
                return;
            }
            AddElementsToTable(insertIntoTable);
            MessageBox.Show("Uspješno dodan zapis!");
            NameBox.Text = "";
            SAPbox.Text = "";
        }

        public void SetConnection(SqlConnection connection)
        {
            _connection = connection;
        }

        public void AddElementsToTable(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@Value1", SAPbox.Text);
            sqlCommand.Parameters.AddWithValue("@Value2", NameBox.Text);
            sqlCommand.ExecuteNonQuery();
        }

    }
}