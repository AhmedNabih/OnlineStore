using System;
using System.Data;
using OnlineStore.Data;
using OnlineStore.Users.UserFactoryPattern;
using OnlineStore.srcFiles;
using OnlineStore.GUIFiles.Users.Admins;
using OnlineStore.Database_Files;

namespace OnlineStore.Users.Admins
{
    public class Admin : IUser
    {
        private DataBase dataBase;

        public Admin()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public override void ConnectPage(UserData data)
        {
            this.Data = data;
            AdminsController controller = new AdminsController(this);
            AdminPage ap = new AdminPage(controller);
            ap.Show();
        }

        
        
    }
}
