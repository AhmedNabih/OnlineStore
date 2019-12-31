using OnlineStore.Data;
using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.App.Stores.Data
{
    public class StoreProductController
    {
        private StoreProductControllerQueries queries;

        public StoreProductController()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.queries = new StoreProductControllerQueries(connectionString);
        }

        public string AddStoreProduct(String storeID, StoreProduct product)
        {
            return queries.AddStoreProduct(storeID, product);
        }

        public bool AddStoreProductVisable(String StoreProductID)
        {
            return queries.AddStoreProductVisable(StoreProductID);
        }

        public bool RemoveStoreProductVisable(String StoreProductID)
        {
            return queries.RemoveStoreProductVisable(StoreProductID);
        }

        public bool RemoveStoreProduct(String StoreID, String StoreProductID)
        {
            return queries.RemoveStoreProduct(StoreID, StoreProductID);
        }

        public bool EditStoreProduct(String StoreID, String StoreProductID)
        {
            return queries.EditStoreProduct(StoreID, StoreProductID);
        }

        public List<StoreProduct> GetStoreProducts(String StoreID)
        {
            // storeProductID, StoreID, ProductID, productName, ProductType, BrandID, BrandName, BrandType, price, amount
            DataTable dataTable = queries.GetStoreProducts(StoreID);
            if (dataTable == null)
                return null;

            List<StoreProduct> storeProductList = new List<StoreProduct>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                StoreProduct tempData = new StoreProduct();
                tempData.Handler(tpStr);
                storeProductList.Add(tempData);
            }

            return storeProductList;
        }

        public Statistics GetProductStat(String storeProductID)
        {
            DataTable dataTable = queries.GetProductStat(storeProductID);
            if (dataTable == null)
                return null;
            Statistics statistics = new Statistics();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                statistics.Handler(tpStr);
            }

            return statistics;
        }

        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
