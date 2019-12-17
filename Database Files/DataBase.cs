using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineStore.Database_Files
{
    public class DataBase
    {
        private static DataBase instance = null; // For Singelton Pattern
        private IConnectionString connectionString;
        private SqlConnection connection;
        private SqlDataAdapter adpt;

        public static DataBase GetInstance(IConnectionString connectionString)
        {
            if (instance == null)
                instance = new DataBase(connectionString);
            return instance;
        }

        private DataBase(IConnectionString connectionString)
        {
            this.connectionString = connectionString;
            this.adpt = new SqlDataAdapter();

            Connect();
        }

        private void Connect()
        {
            connection = new SqlConnection(this.connectionString.GetConnectionString());
            try { connection.Open(); } catch { MessageBox.Show("Can not Connect to Database"); }
        }

        ~DataBase()
        {
            try { connection.Close(); } catch { }
        }

        public void QueryExec(String query)
        { 
            adpt.SelectCommand = new SqlCommand(query, connection);
            adpt.SelectCommand.ExecuteNonQuery();
        }

        public DataTable Query(String query)
        {

            DataTable datatable = new DataTable();
            adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(query, connection);
            adpt.Fill(datatable);
            return datatable;
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }

}
