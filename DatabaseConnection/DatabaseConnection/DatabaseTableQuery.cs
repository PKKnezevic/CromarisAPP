using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DatabaseConnection.AddElementForms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection
{
    public partial class DatabaseTableQuery : Form
    {
        private SqlDataAdapter _adapter;
        private SqlConnection _con;
        private DataTable _dataTable;

        public DatabaseTableQuery()
        {
            InitializeComponent();
        }

        private void connectToDB_Click(object sender, EventArgs e)
        {
            var connstring =
                "Data Source = 10.100.1.162\\BIZERBA;Initial Catalog=OSNOVNA_SREDSTVA;Integrated security=false;user=OS_API;password=TvornicaRibe!.99";
            _con = new SqlConnection(connstring);
            _con.Open();
            var query = "Select * from " + databaseTables.SelectedItem;

            //Execute the given command
            _adapter = new SqlDataAdapter(query, _con);
            _dataTable = new DataTable(databaseTables.SelectedItem.ToString());
            _adapter.Fill(_dataTable);
            databaseView.DataSource = _dataTable;
            var list = PopulateColumnPicker();
            columnPickerCBox.DataSource = list;
        }


        private void addEntry_Click(object sender, EventArgs e)
        {
            if (_con == null)
            {
                MessageBox.Show("Molim spojite se na željenu bazu prvo!");
                return;
            }

            ITableInterface entryForm = null;
            switch (databaseTables.SelectedItem.ToString())
            {
                case "Korisnik":
                    entryForm = new TableFormUser();
                    break;
                case "Lokacija":
                    entryForm = new TableFormLocation();
                    break;
                case "RIF":
                    entryForm = new TableFormRIF();
                    break;
                case "MT":
                    entryForm = new TableFormMT();
                    break;
                case "Oprema":
                    entryForm = new TableFormOprema();
                    break;
                case "Zaduzenje":
                    entryForm = new TableFormZaduzenjec();
                    break;
            }

            entryForm.SetConnection(_con);
        }

        private List<string> PopulateColumnPicker()
        {
            var list = new List<string>();
            foreach (DataGridViewColumn column in databaseView.Columns) list.Add(column.Name);

            return list;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var dvTable = _dataTable.DefaultView;
            if (searchBox.Text != "" && Regex.IsMatch(searchBox.Text,@"[a-zA-Z]"))
                try
                {
                    dvTable.RowFilter = columnPickerCBox.Text + " Like '%" + searchBox.Text + "%'";
                }
                catch (EvaluateException exception)
                {
                    SearchUsingInt();
                    //Console exception log
                    //Console.WriteLine(exception);
                }
            else 
                ResetDataView();
        }

        private void SearchUsingInt()
        {
            
            if (Int32.TryParse(searchBox.Text, out _))
            {
                var query = "SELECT * FROM " + databaseTables.SelectedItem + " WHERE "
                            + columnPickerCBox.Text + "=" + searchBox.Text;
                _adapter = new SqlDataAdapter(query, _con);
                var newDt = new DataTable();
                _adapter.Fill(newDt);
                databaseView.DataSource = newDt;
            }
        }

        private void ResetDataView()
        {
            databaseView.DataSource = _dataTable;
        }

        private void databaseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchBox.Text = "";
            ResetDataView();
        }
    }
}