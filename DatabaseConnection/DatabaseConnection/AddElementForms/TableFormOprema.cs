using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection.AddElementForms
{
    public partial class TableFormOprema : Form, ITableInterface
    {
        private readonly List<Control> _boxElements;
        private SqlConnection _connection;

        public TableFormOprema()
        {
            InitializeComponent();
            Show(Parent);
            _boxElements = new List<Control>();
            FillBoxElements(_boxElements);
        }

        public void SetConnection(SqlConnection connection)
        {
            _connection = connection;
        }

        public void AddElementsToTable(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@Value1", int.Parse(InternalBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value2", int.Parse(SerialBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value3", ProviderBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value4", int.Parse(RIFBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value5", SAPNameBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value6", int.Parse(SAPCodeBox.Text));
            sqlCommand.Parameters.AddWithValue("@Value7", aktivacijaDTP.Text);
            sqlCommand.Parameters.AddWithValue("@Value8", checkBox1.Checked);
            sqlCommand.Parameters.AddWithValue("@Value9", primkaDTP.Text);
            sqlCommand.Parameters.AddWithValue("@Value10", IPBox.Text);
            sqlCommand.Parameters.AddWithValue("@Value11", zaprimanjeDTP.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void AddGear_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO Oprema VALUES (@Value1, @Value2, @Value3, @Value4, @Value5," +
                        " @Value6, @Value7, @Value8, @Value9, @Value10, @Value11)";
            var insertIntoTable = new SqlCommand(query, _connection);
            if (InternalBox.Text.Equals(""))
            {
                MessageBox.Show("Molim unseite interni broj!");
                return;
            }

            AddElementsToTable(insertIntoTable);
            ResetBoxes();
            MessageBox.Show("Uspješno dodan zapis!");
        }

        private void ResetBoxes()
        {
            foreach (var box in _boxElements) box.Text = "";
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