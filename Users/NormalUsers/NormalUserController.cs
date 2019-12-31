using OnlineStore.App.Stores.Data;
using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.Users.NormalUsers
{
    public class NormalUserController
    {
        public IUser normalUser;
        private NormalUserControllerQueries queries;

        public NormalUserController(NormalUser normalUser)
        {
            this.normalUser = normalUser;
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            this.queries = new NormalUserControllerQueries(connectionString);

        }

        public NormalUserController(IUser user)
        {
            this.normalUser = user;
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            this.queries = new NormalUserControllerQueries(connectionString);
        }

        public List<StoreRawData> GetAllStores()
        {
            DataTable dataTable = queries.GetAllStores();
            if (dataTable == null)
                return null;
            List<StoreRawData> storeList = new List<StoreRawData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                StoreRawData tempData = new StoreRawData();
                tempData.Handler(tpStr);
                storeList.Add(tempData);
            }

            return storeList;
        }
        public DataTable GetProductsInStore(String StoreID)
        {
            return queries.GetProductsInStore(StoreID);
        }
    }
}
