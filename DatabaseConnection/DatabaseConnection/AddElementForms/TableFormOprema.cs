using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormOprema : Form, ITableInterface
    {
        private SqlConnection _connection;
        private List<TextBox> _boxElements;
        public TableFormOprema()
        {
            InitializeComponent();
            FillBoxElements(_boxElements);
        }

        private void AddGear_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Korisnik (DAT_zaprimanja, DAT_Primke, IP_adresa, DAT_aktivacije, " +
                           "SAP_Sifra, Naziv_SAP, RIF_ID, Dobavljac, Interni_broj, Serijski_broj, EU_Fond)" +
                           "VALUES (@Value1, @Value2, @Value3, @Value4, @Value5," +
                           " @Value6, @Value7, @Value8, @Value9, @Value10, @Value11)";
            SqlCommand insertIntoTable = new SqlCommand(query, _connection);
            if (InternalBox.Text.Equals(""))
            {
                MessageBox.Show("Molim unseite interni broj!");
                return;
            }
            AddElementsToTable(insertIntoTable);
            ResetBoxes();
            MessageBox.Show("Uspješno dodan zapis!");
           
        }

        public void SetConnection(SqlConnection connection)
        {
            _connection = connection;
        }

        public void AddElementsToTable(SqlCommand sqlCommand)
        {
            var i = 1;
            foreach (var box in _boxElements)
            {
                sqlCommand.Parameters.AddWithValue("@Value" + i, box.Text);
                i++;
            }

            sqlCommand.Parameters.AddWithValue("@Value11", checkBox1.Checked);
            sqlCommand.ExecuteNonQuery();
        }

        private void ResetBoxes()
        {
            foreach (var box in _boxElements)
            {
                box.Text = "";
            }   
        }
        

        private void FillBoxElements(List<TextBox> list)
        {
            list.Add(ReceivingDateBox);
            list.Add(RecivingBox);
            list.Add(IPBox);
            list.Add(ActivationDateBox);
            list.Add(SAPCodeBox);
            list.Add(SAPNameBox);
            list.Add(RIFBox);
            list.Add(ProviderBox);
            list.Add(InternalBox);
            list.Add(SerialBox);
        }

        /*
        private bool CheckBoxes()
        {
            foreach (var box in _boxElements)
            {
                if (box.Text.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }
        */
    }
}