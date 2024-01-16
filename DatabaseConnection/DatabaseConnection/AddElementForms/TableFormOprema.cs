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
        private List<Control> _boxElements;
        public TableFormOprema()
        {
            InitializeComponent();
            Show(Parent);
            _boxElements = new List<Control>();
            FillBoxElements(_boxElements);
        }

        private void AddGear_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Oprema VALUES (@Value1, @Value2, @Value3, @Value4, @Value5," +
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
            sqlCommand.Parameters.AddWithValue("@Value1", Int32.Parse(InternalBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value2", Int32.Parse(SerialBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value3", ProviderBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value4", Int32.Parse(RIFBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value5", SAPNameBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value6", Int32.Parse(SAPCodeBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value7", aktivacijaDTP.Text);
            sqlCommand.Parameters.AddWithValue("@Value8", checkBox1.Checked);
            sqlCommand.Parameters.AddWithValue("@Value9", primkaDTP.Text);
            sqlCommand.Parameters.AddWithValue("@Value10", IPBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value11", zaprimanjeDTP.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void ResetBoxes()
        {
            foreach (var box in _boxElements)
            {
                box.Text = "";
            }   
        }
        

        private void FillBoxElements(List<Control> list)
        {
            list.Add(InternalBox);
            list.Add(SerialBox);
            list.Add(ProviderBox);
            list.Add(RIFBox);
            list.Add(SAPNameBox);
            list.Add(SAPCodeBox);
            list.Add(aktivacijaDTP);
            list.Add(primkaDTP);
            list.Add(IPBox);
            list.Add(zaprimanjeDTP);
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