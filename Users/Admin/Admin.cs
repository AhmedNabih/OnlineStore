using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;
using System.Windows.Forms;

namespace OnlineStore.Users.Admin
{
    public class Admin : IUser
    {

        public override void ConnectPage(UserData data)
        {
            this.hand = Handler.GetInstance();
            this.Data = data;
            AdminPage ap = new AdminPage(this);
            ap.Show();
        }

        public void AddProduct(String BN, String BT, String N,String T)
        {
            String cmdSZ = "select count(ProductID) from Product";
            DataTable tp = hand.DB.Query(cmdSZ);
            int sz = System.Convert.ToInt32(tp.Rows[0][0].ToString()) + new Random().Next(5000);
            String ID = sz.ToString();
            String cmd = "insert into Product values(" + ID + ",'" + BN + "','" + BT + "','" + N +"','"+T+"')";
            hand.DB.QueryExec(cmd);
        }

        public void RemoveProducts(String[] data)
        {

        }

        public void AddStoreFromReq(String[] data)
        {
            String cmdSZ1 = "select count(StoreID) from Store";
            String cmdSZ2 = "select count(StatID) from MyStatistics";
            DataTable tp1 = hand.DB.Query(cmdSZ1);
            DataTable tp2 = hand.DB.Query(cmdSZ2);
            int sz1 = System.Convert.ToInt32(tp1.Rows[0][0].ToString()) + (new Random().Next(0, 1000));
            int sz2 = System.Convert.ToInt32(tp2.Rows[0][0].ToString()) + (new Random().Next(0, 1000));
            String ID1 = sz1.ToString();
            String ID2 = sz2.ToString();
            String cmd1 = "insert into Store values(" + ID1 + ",'" + data[1] + "','" + data[2] + "','" + data[3] + "','" + data[4] + "')";
            String cmd2 = "insert into MyStatistics values(" + ID2 + ",0,0)";
            hand.DB.QueryExec(cmd1);
            hand.DB.QueryExec(cmd2);

            String cmd3 = "insert into UserStore values("+data[0]+","+ID1+")";
            hand.DB.QueryExec(cmd3);

            String cmd4 = "insert into StoreStat values("+ID1+","+ID2+")";
            hand.DB.QueryExec(cmd4);

            String cmdRemoveReq = "delete from StoreRequests where UserID = "+data[0]+" and StoreName = '"+data[1]+"'";
            hand.DB.QueryExec(cmdRemoveReq);

        }

        public void RemoveStoreFromReq()
        {

        }
        
    }
}
