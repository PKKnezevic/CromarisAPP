using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.AddElementForms;
using DatabaseConnection.Interfaces;

namespace DatabaseConnection
{
    public partial class DatabaseTableQuery : Form
    {
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
            var adapter = new SqlDataAdapter(query, _con);
            _dataTable = new DataTable(databaseTables.SelectedItem.ToString());
            adapter.Fill(_dataTable);
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

        private List<String> PopulateColumnPicker()
        {
            List<String> list = new List<String>();
            foreach (DataGridViewTextBoxColumn column in databaseView.Columns)
            {
                list.Add(column.Name);
            }

            return list;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvTable = _dataTable.DefaultView;
            if (searchBox.Text != "")
            {
                try
                {
                    dvTable.RowFilter = columnPickerCBox.Text + " Like '%" + searchBox.Text + "%'";
                }
                catch (Exception exception)
                {
                    string query = "SELECT * FROM " + databaseTables.SelectedItem + " WHERE "
                                   +columnPickerCBox.Text+"="+searchBox.Text;
                    var adapter = new SqlDataAdapter(query, _con);
                    var newDt = new DataTable();
                    adapter.Fill(newDt);
                    databaseView.DataSource = newDt;
                }
            }
            else
            {
                databaseView.DataSource = _dataTable;
            }   
        }
    }
}