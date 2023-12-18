using System;
using System.ComponentModel;
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
            //Console.Write("This is the selected table: " + databaseTables.SelectedItem);
            string columnName = "SELECT count(*) as No_of_Column FROM information_schema.columns WHERE table_name ='"+databaseTables.SelectedItem+"'";
            string query = "Select * from " + databaseTables.SelectedItem;
            
            //Obtaining number of columns
            SqlCommand columns = OperateCommand(columnName, con);
            SqlDataReader columnReader = columns.ExecuteReader();
            var columnCount=0;
            while (columnReader.Read())
            { 
                columnCount = columnReader.GetInt32(0);
            }
            
            columnReader.Close();
            
            //Execute the given command
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
        
        
    }
}