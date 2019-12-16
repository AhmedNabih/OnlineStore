using System;
using System.Data;
using System.Windows.Forms;
using OnlineStore.Data;
using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using OnlineStore.Users.UserFactoryPattern;

namespace OnlineStore.srcFiles
{
    public class UserController
    {
        private static UserController instance = null;  // For Singelton Pattern
        private UserControllerQueries queries;

        public static UserController GetInstance()
        {
            if (instance == null)
                instance = new UserController();
            return instance;
        }

        private UserController()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            this.queries = new UserControllerQueries(connectionString);

        }

        public bool Login(string UN, string PW)
        {
            UserData tpUser = this.queries.SearchUserList(UN, PW);
            if (tpUser == null)
                return false;

            IUser myUser = UserFactory.CreateUser(tpUser.role);
            myUser.ConnectPage(tpUser);
            return true;

        }

        public bool Register(String UN, String PW, String N, String EM, String Role)
        {
            bool DONE = this.queries.Register(UN, PW, N, EM, Role);
            if (DONE)
                return true;
            else
                return false;
        }


    }
}
