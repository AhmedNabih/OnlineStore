using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using System;
using System.Collections.Generic;

namespace OnlineStore.App.Stores.Data
{
    public class StoreProductController
    {
        private List<StoreProduct> products;
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
            this.products = new List<StoreProduct>();
        }

        public bool AddStoreProduct(String storeID, StoreProduct product)
        {
            return queries.AddStoreProduct(storeID, product);
        }
    }
}
