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

        public void Register(String[] data)
        {
            String cmdSZ = "select count(UserID) from MyUser";
            DataTable tp = this.queries.Query(cmdSZ);
            int sz = System.Convert.ToInt32(tp.Rows[0][0].ToString()) + 1;
            String ID = sz.ToString();
            String cmd = "insert into MyUser values(" + ID + ",'" + data[0] + "','" + data[1] + "','" + data[2] + "','" + data[3] + "','" + data[4] + "')";
            DB.QueryExec(cmd);
        }


    }
}
