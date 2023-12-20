using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection.AddElementForms;

namespace DatabaseConnection
{
    public partial class DatabaseTableQuery : Form
    {
        private SqlConnection con;
        
        public DatabaseTableQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var userForm = new TableFormUser();
            userForm.Visible = true;
            userForm.SetConnection(con);
        }
    }
}