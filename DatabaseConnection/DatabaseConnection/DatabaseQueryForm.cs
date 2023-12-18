using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class DatabaseQueryForm : Form
    {
        //string connectionString = "Data Source = 10.100.1.162\\BIZERBA;Initial Catalog=OSNOVNA_SREDSTVA;Integrated security=false;user=OS_API;password=TvornicaRibe!.99";
        //string getColumnCount = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";

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
            
            string query = "Select * from " + databaseTables.SelectedItem;
            SqlCommand cmd = operateCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader.GetValue(1));
            }
        }

        private SqlCommand operateCommand(string query, SqlConnection connection)
        {
            return new SqlCommand(query, connection);
        }
        
        
    }
}