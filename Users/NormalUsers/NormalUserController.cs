using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Data;

namespace OnlineStore.Users.NormalUsers
{
    public class NormalUserController
    {
        public IUser normalUser;
        private NormalUserControllerQueries quiere;

        public NormalUserController(NormalUser normalUser)
        {
            this.normalUser = normalUser;
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            this.quiere = new NormalUserControllerQueries(connectionString);

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
            this.quiere = new NormalUserControllerQueries(connectionString);
        }

        public DataTable GetAllStores()
        {
            return quiere.GetAllStores();
        }
        public DataTable GetProductsInStore(String StoreID)
        {
            return quiere.GetProductsInStore(StoreID);
        }
    }
}
