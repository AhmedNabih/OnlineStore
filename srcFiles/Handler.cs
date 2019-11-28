using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Data;
using OnlineStore.srcFiles;
using OnlineStore.Users;

namespace OnlineStore
{
    public class Handler
    {
        private static Handler instance = null;  // For Singelton Pattern
        public MyDataBase DB = MyDataBase.GetInstance();

        public static Handler GetInstance()
        {
            if (instance == null)
                instance = new Handler();
            return instance;
        }

        private Handler()
        {
        }

        public bool Login(string UN, string PW)
        {
            UserData tpUser = DB.SearchUserList(UN, PW);
            if (tpUser != null)
            {
                IUser myUser = UserFactory.CreateUser(tpUser.role);
                myUser.ConnectPage(tpUser);
                return true;
            }
            else
                return false;
        }

        public void Register(String[] data)
        {
            String cmdSZ = "select count(UserID) from MyUser";
            DataTable tp = DB.Query(cmdSZ);
            int sz = System.Convert.ToInt32(tp.Rows[0][0].ToString()) + 1;
            String ID = sz.ToString();
            String cmd = "insert into MyUser values("+ID+",'"+data[0]+ "','" + data[1] + "','" + data[2] + "','" + data[3] + "','" + data[4] + "')";
            DB.QueryExec(cmd);
        }

        public void Exit()
        {
            Application.Exit();
        }
    }
}
