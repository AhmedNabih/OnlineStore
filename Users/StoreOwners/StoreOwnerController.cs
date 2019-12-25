using OnlineStore.App.Stores.Data;
using OnlineStore.Data;
using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.Users.StoreOwners
{
    public class StoreOwnerController
    {
        public StoreOwner storeOwner;
        private StoreOwnerControllerQueries queries;

        public StoreOwnerController(StoreOwner storeOwner)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.queries = new StoreOwnerControllerQueries(connectionString);
            this.storeOwner = storeOwner;
        }

        public List<StoreRawData> GetStoresData(String userID)
        {
            DataTable dataTable = queries.GetStoresData(userID);
            if (dataTable == null)
                return null;
            List<StoreRawData> StoresList = new List<StoreRawData>();

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
                StoresList.Add(tempData);
            }

            return StoresList;
        }

        public bool SendStoreRequest(String userid, String name, String type, String location, String info)
        {
            return this.queries.SendStoreRequest(userid, name, type, location, info);
        }

        public bool DeleteStore(String userID,String StoreID)
        {
            return this.queries.DeleteStore(userID, StoreID);
        }

        public List<ProductRawData> GetSystemProducts()
        {
            DataTable dataTable = queries.GetSystemProducts();
            if (dataTable == null)
                return null;
            List<ProductRawData> productsList = new List<ProductRawData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                ProductRawData tempData = new ProductRawData();
                tempData.Handler(tpStr);
                productsList.Add(tempData);
            }

            return productsList;
        }

        public List<BrandRawData> GetSystemBrands()
        {
            DataTable dataTable = queries.GetSystemBrands();
            if (dataTable == null)
                return null;
            List<BrandRawData> brandsList = new List<BrandRawData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                BrandRawData tempData = new BrandRawData();
                tempData.Handler(tpStr);
                brandsList.Add(tempData);
            }

            return brandsList;
        }

        public Statistics GetStoreStat(String StoreID)
        {
            DataTable dataTable = queries.GetStoreStat(StoreID);
            if (dataTable == null)
                return null;
            Statistics stat = new Statistics();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                stat.Handler(tpStr);
            }

            return stat;
        }

        public List<StoreRawData> GetCollaboratorStores(String UserID)
        {
            DataTable dataTable = queries.GetCollaboratorStores(UserID);
            if (dataTable == null)
                return null;
            List<StoreRawData> StoresList = new List<StoreRawData>();

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
                StoresList.Add(tempData);
            }

            return StoresList;
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
