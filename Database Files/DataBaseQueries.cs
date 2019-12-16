using System;
using System.Data;

namespace OnlineStore.Database_Files
{
    public class DataBaseQueries
    {
        private DataBase dataBase;
        
        public DataBaseQueries()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public String UserTableSum()
        {
            String cmd = "select count(UserID) as cnt from MyUser where Role != 'Admin'";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }

        public String StoreTableSum()
        {
            String cmd = "select count(StoreID) as cnt from store";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }

        public String StoreTableSumForUser(String UserID)
        {
            String cmd = "select count(UserID) as cnt from UserStore where UserID = " + UserID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }

        public String StoreOwnersSum()
        {
            String cmd = "select count(UserID) as cnt from MyUser where Role = 'StoreOwner'";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }

        public String ProductTableSum()
        {
            String cmd = "Select count(ProductID) from Product";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String ProductTableSumForUser(String UserID)
        {
            String cmd = "select count(StoreID) from StoreProductStat where StoreID in (select StoreID from UserStore where UserID = " + UserID + ")";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String ProductTableSumForStore(String StoreID)
        {
            String cmd = "select count(StoreID) from StoreProductStat where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesSum()
        {
            String cmd = "select sum(price) as cnt from StoreProductStat";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesCnt()
        {
            String cmd = "select count(price) as cnt from StoreProductStat";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesSumForUser(String UserID)
        {
            String cmd = "select sum(price) from StoreProductStat sps inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesCntForUser(String UserID)
        {
            String cmd = "select count(price) from StoreProductStat sps inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesSumForStore(String StoreID)
        {
            String cmd = "select sum(price) from StoreProductStat where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesCntForStore(String StoreID)
        {
            String cmd = "select count(price) from StoreProductStat where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMax()
        {
            String cmd = "select Max(price) from StoreProductStat";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMaxForUser(String UserID)
        {
            String cmd = "select Max(price) from StoreProductStat sps inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID; ;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMaxForStore(String StoreID)
        {
            String cmd = "select Max(price) from StoreProductStat where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMin()
        {
            String cmd = "select Min(price) from StoreProductStat";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMinForUser(String UserID)
        {
            String cmd = "select Min(price) from StoreProductStat sps inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID; ;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMinForStore(String StoreID)
        {
            String cmd = "select Min(price) from StoreProductStat where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }

        
    }
}
