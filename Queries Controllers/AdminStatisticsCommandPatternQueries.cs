using OnlineStore.Database_Files;
using System;
using System.Data;

namespace OnlineStore.Queries_Controllers
{
    public class AdminStatisticsCommandPatternQueries
    {
        private DataBase dataBase;
        
        public AdminStatisticsCommandPatternQueries()
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
            String cmd = "select count(StoreID) as cnt from Store";
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
            String cmd = "select count(StoreID) from StoreProducts where StoreID in (select StoreID from UserStore where UserID = " + UserID + ")";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String ProductTableSumForStore(String StoreID)
        {
            String cmd = "select count(StoreID) from StoreProducts where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesSum()
        {
            String cmd = "select sum(price) as cnt from StoreProducts";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesCnt()
        {
            String cmd = "select count(price) as cnt from StoreProducts";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesSumForUser(String UserID)
        {
            try
            {
                String cmd = "select sum(price) from StoreProducts sps inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID;
                DataTable tpData = dataBase.Query(cmd);
                
                if (tpData.Rows.Count <= 0 || tpData.Rows == null)
                    return "0.0";
                return tpData.Rows[0][0].ToString();
            }
            catch
            {
                return "0.0";
            }
        }
        
        public String StorePricesCntForUser(String UserID)
        {
            String cmd = "select count(price) from StoreProducts inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesSumForStore(String StoreID)
        {
            String cmd = "select sum(price) from StoreProducts where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesCntForStore(String StoreID)
        {
            String cmd = "select count(price) from StoreProducts where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMax()
        {
            String cmd = "select Max(price) from StoreProducts";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMaxForUser(String UserID)
        {
            String cmd = "select Max(price) from StoreProducts sps inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID; ;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMaxForStore(String StoreID)
        {
            String cmd = "select Max(price) from StoreProducts where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMin()
        {
            String cmd = "select Min(price) from StoreProducts";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMinForUser(String UserID)
        {
            String cmd = "select Min(price) from StoreProducts sps inner join UserStore us on us.StoreID = sps.StoreID and us.UserID = " + UserID; ;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
        
        public String StorePricesMinForStore(String StoreID)
        {
            String cmd = "select Min(price) from StoreProducts where StoreID = " + StoreID;
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }

        
    }
}
