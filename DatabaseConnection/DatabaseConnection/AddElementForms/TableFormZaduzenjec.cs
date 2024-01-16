using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormZaduzenjec : Form, ITableInterface
    {
        private SqlConnection _connection;

        public TableFormZaduzenjec()
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
            sqlCommand.Parameters.AddWithValue("@Value1", cadrovskiBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value2", internalBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value3", datZaduzenjaDTP.Text);
            sqlCommand.Parameters.AddWithValue("@Value4", datRazduzenjaDTP.Text);
            sqlCommand.Parameters.AddWithValue("@Value5", flokBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value6", imtBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value7", rifBox.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void addZaduzenje_Click(object sender, EventArgs e)
        {
            var query =
                "INSERT INTO Zaduzenje (Kadrovski_broj, Interni_broj_opreme, DAT_zaduzenja, DAT_razduzenja, FLOK, IMT, RIF) " +
                "VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)";
            var insertIntoTable = new SqlCommand(query, _connection);
            if (CheckBoxes())
            {
                MessageBox.Show("Molim unseite polja!");
                return;
            }

            AddElementsToTable(insertIntoTable);
            MessageBox.Show("Uspješno dodan zapis!");
        }

        private bool CheckBoxes()
        {
            if (internalBox.Text.Equals("") | cadrovskiBox.Text.Equals("") | flokBox.Text.Equals("") |
                imtBox.Text.Equals("") | rifBox.Text.Equals(""))
                return true;

            return false;
        }
    }
}