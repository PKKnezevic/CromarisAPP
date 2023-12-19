using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class DatabaseQueryForm : Form
    {
        //string connectionString = "Data Source = 10.100.1.162\\BIZERBA;Initial Catalog=OSNOVNA_SREDSTVA;Integrated security=false;user=OS_API;password=TvornicaRibe!.99";
        //SELECT count(*) as No_of_Column FROM information_schema.columns WHERE table_name ='geeksforgeeks';
        
        public DatabaseQueryForm()
        {
            InitializeComponent();
        }

        private void ConnectionButtonClick(object sender, EventArgs e)
        {
            string connstring = "Data Source = 10.100.1.162\\BIZERBA;Initial Catalog=OSNOVNA_SREDSTVA;Integrated security=false;user=OS_API;password=TvornicaRibe!.99";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from " + databaseTables.SelectedItem;
            
            //Execute the given command
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable(databaseTables.SelectedItem.ToString());
            adapter.Fill(dataTable);
            databaseView.DataSource = dataTable;
            SqlCommand cmd = OperateCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(1));
            }
            
            con.Close();
        }

        private SqlCommand OperateCommand(string query, SqlConnection connection)
        {
            return new SqlCommand(query, connection);
        }


        private void AddNewEleButtonOnClick(object sender, EventArgs e)
        {
            databaseTables.SelectedItem.ToString();
        }
    }
}