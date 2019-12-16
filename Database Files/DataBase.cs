using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OnlineStore.Data;

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


        ///////////////////////////////////////////////////////////////////////////////////////////////////////


        public DataTable GetUsersData()
        {
            String cmd = "select UserID, UserName, Name, Email, Role from MyUser";
            DataTable dataTable = Query(cmd);
            return dataTable;
        }

        public DataTable GetAllStores()
        {
            String cmd = "select f.UserID,UserName, f.StoreID, f.StoreName,f.StoreType,f.StoreLocation,f.StoreInfo from MyUser mu inner join (select UserID, s.StoreID, StoreName, StoreType, StoreLocation, StoreInfo from Store s inner join UserStore us on s.StoreID = us.StoreID) as f on f.UserID = mu.UserID";
            DataTable datatable = Query(cmd);
            return datatable;
        }

        public DataTable GetStore(String userID)
        {
            String cmd = "select s.StoreID,StoreName,StoreType,StoreLocation,StoreInfo from Store s inner join UserStore us on s.StoreID = us.StoreID and us.UserID = " + userID;
            DataTable dataTable = Query(cmd);
            return dataTable;
        }


        public DataTable GetProductsData()
        {
            String cmd = "select BrandName,BrandType,ProductName,terms from Product";
            DataTable datatable = Query(cmd);
            return datatable;


        }

        public DataTable GetStoreData()
        {
            String cmd = "select StoreName,StoreType,StoreLocation,StoreInfo from Store";
            DataTable datatable = Query(cmd);
            return datatable;
        }

        public DataTable GetProductsInStore(String StoreID)
        {
            String cmd = "select StoreID, p.ProductName, price, amount from StoreProductStat sps inner join Product p on sps.Product = p.ProductID and sps.StoreID = " + StoreID;
            DataTable dataTable = Query(cmd);
            return dataTable;
        }

        public DataTable GetAllProductsInStore()
        {
            String cmd = "select StoreID, p.ProductName, price, amount from StoreProductStat sps inner join Product p on sps.Product = p.ProductID";
            DataTable dataTable = Query(cmd);
            return dataTable;
        }

        public DataTable GetStoreReq()
        {
            String cmd = "select * from StoreRequests";
            DataTable datatable = Query(cmd);
            return datatable;
        }




    }

}
