﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.AddElementForms;

namespace DatabaseConnection
{
    public partial class DatabaseQueryForm : Form
    {
        //string connectionString = "Data Source = 10.100.1.162\\BIZERBA;Initial Catalog=OSNOVNA_SREDSTVA;Integrated security=false;user=OS_API;password=TvornicaRibe!.99";
        //SELECT count(*) as No_of_Column FROM information_schema.columns WHERE table_name ='geeksforgeeks';
        private SqlConnection con;

        public DatabaseQueryForm()
        {
            InitializeComponent();
        }

        private void ConnectionButtonClick(object sender, EventArgs e)
        {
            var connstring =
                "Data Source = 10.100.1.162\\BIZERBA;Initial Catalog=OSNOVNA_SREDSTVA;Integrated security=false;user=OS_API;password=TvornicaRibe!.99";
            con = new SqlConnection(connstring);
            con.Open();
            var query = "Select * from " + databaseTables.SelectedItem;

            //Execute the given command
            var adapter = new SqlDataAdapter(query, con);
            var dataTable = new DataTable(databaseTables.SelectedItem.ToString());
            adapter.Fill(dataTable);
            databaseView.DataSource = dataTable;
            var cmd = OperateCommand(query, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) Console.WriteLine(reader.GetValue(1));
        }

        private SqlCommand OperateCommand(string query, SqlConnection connection)
        {
            return new SqlCommand(query, connection);
        }


        private void AddNewEleButtonOnClick(object sender, EventArgs e)
        {
            var userForm = new TableFormUser();
            userForm.SetConnection(con);
        }
    }
}