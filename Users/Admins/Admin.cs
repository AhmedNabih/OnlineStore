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
            AdminPage ap = new AdminPage(this);
            ap.Show();
        }

        public void AddProduct(String BN, String BT, String N,String T)
        {
            String cmdSZ = "select count(ProductID) from Product";
            DataTable tp = dataBase.Query(cmdSZ);
            int sz = System.Convert.ToInt32(tp.Rows[0][0].ToString()) + new Random().Next(5000);
            String ID = sz.ToString();
            String cmd = "insert into Product values(" + ID + ",'" + BN + "','" + BT + "','" + N +"','"+T+"')";
            dataBase.QueryExec(cmd);
        }

        public void RemoveProducts(String[] data)
        {

        }

        public void AddStoreFromReq(String[] data)
        {
            String cmdSZ1 = "select count(StoreID) from Store";
            String cmdSZ2 = "select count(StatID) from MyStatistics";
            DataTable tp1 = dataBase.Query(cmdSZ1);
            DataTable tp2 = dataBase.Query(cmdSZ2);
            int sz1 = System.Convert.ToInt32(tp1.Rows[0][0].ToString()) + (new Random().Next(0, 1000));
            int sz2 = System.Convert.ToInt32(tp2.Rows[0][0].ToString()) + (new Random().Next(0, 1000));
            String ID1 = sz1.ToString();
            String ID2 = sz2.ToString();
            String cmd1 = "insert into Store values(" + ID1 + ",'" + data[1] + "','" + data[2] + "','" + data[3] + "','" + data[4] + "')";
            String cmd2 = "insert into MyStatistics values(" + ID2 + ",0,0)";
            dataBase.QueryExec(cmd1);
            dataBase.QueryExec(cmd2);

            String cmd3 = "insert into UserStore values("+data[0]+","+ID1+")";
            dataBase.QueryExec(cmd3);

            String cmd4 = "insert into StoreStat values("+ID1+","+ID2+")";
            dataBase.QueryExec(cmd4);

            String cmdRemoveReq = "delete from StoreRequests where UserID = "+data[0]+" and StoreName = '"+data[1]+"'";
            dataBase.QueryExec(cmdRemoveReq);

        }

        public void RemoveStoreFromReq()
        {

        }
        
    }
}
