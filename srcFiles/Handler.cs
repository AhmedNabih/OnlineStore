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

namespace OnlineStore
{
    public class handler
    {
        public MyDataBase DB = new MyDataBase("D:\\dev\\VS\\WindowsFormsApp1\\WindowsFormsApp1\\MyData");
        private Dictionary<String, Object> pages;

        public handler()
        {
            pages = new Dictionary<string, object>();
            pages.Add("Admin",new Admin());
            pages.Add("NormalUser", new NormalUser());
            pages.Add("StoreOwner", new StoreOwner());
        }

        public bool Login(string UN, string PW)
        {
            UserData tpUser = DB.SearchUserList(UN, PW);
            if (tpUser != null)
            {
                dynamic TempObject = pages[tpUser.role];
                TempObject.ConnectPage(tpUser, this);
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
