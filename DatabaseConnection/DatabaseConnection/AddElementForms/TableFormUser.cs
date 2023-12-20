using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormUser : Form, TableInteraction
    {
        
        public TableFormUser()
        {
            InitializeComponent();
        }
        
        private void SendDataToKorisnik_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Korisnik VALUES (@Value1, @Value2)";
            SqlCommand insertIntoTable = new SqlCommand(query, _connection);
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

        public void AddElementsToTable(SqlCommand sqlCommand)
        {
            
        }
    }
}