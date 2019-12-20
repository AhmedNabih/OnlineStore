using OnlineStore.App.Stores.Data;
using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.App.Stores
{
    public class StoreController
    {
        private Store store;
        private StoreControllerQueries queries;

        public StoreController()
        {
            this.store = new Store();
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.queries = new StoreControllerQueries(connectionString);
        }

        public bool AddProduct(String storeID, StoreProduct product)
        {
            return store.products.AddStoreProduct(storeID, product);
        }
    }
}
