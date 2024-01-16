using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormRIF : Form, ITableInterface
    {
        private SqlConnection _connection;
        public TableFormRIF()
        {
            InitializeComponent();
            Show(Parent);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            string query = "Insert into RIF (Narudzbenica,Racun,DMS_BR_Dokumenta,Investicijski_nalog)VALUES (@Value1, @Value2, @Value3, @Value4)";
            SqlCommand insertIntoTable = new SqlCommand(query, _connection);
            if (OrderBox.Text.Equals(""))
            {
                MessageBox.Show("Molim unseite polje narudzbenice!");
                return;
            }
            AddElementsToTable(insertIntoTable);
            MessageBox.Show("Uspješno dodan zapis!");
            OrderBox.Text = "";
            ReceiptBox.Text = "";
            DMSBox.Text = "";
            InvestmentBox.Text = "";
        }

        public void AddElementsToTable(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@Value1", OrderBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value2", ReceiptBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value3", Int32.Parse(DMSBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value4", InvestmentBox.Text);
            sqlCommand.ExecuteNonQuery();
        }

        public void SetConnection(SqlConnection connection)
        {
            _connection = connection;
        }
    }
}