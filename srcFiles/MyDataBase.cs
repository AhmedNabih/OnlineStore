﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Data;

namespace OnlineStore.srcFiles
{
    public class MyDataBase
    {
        private static MyDataBase instance = null; // For Singelton Pattern
        private String ConnectionString = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=789789789asd;";
            //"Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adpt;
        private SqlCommand Command;
        private bool SafeGarde;

        public static MyDataBase GetInstance()
        {
            if (instance == null)
                instance = new MyDataBase();
            return instance;
        }

        private MyDataBase()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Can not Connect to Database");
                SafeGarde = false;
            }
            else
                SafeGarde = true;

        }

        ~MyDataBase()
        {
            try { connection.Close(); } catch { }
        }

        public void QueryExec(String query)
        {
            try
            {
                if (SafeGarde)
                {
                    adpt.SelectCommand = new SqlCommand(query, connection);
                    adpt.SelectCommand.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }

        public DataTable Query(String query)
        {
            if (SafeGarde)
            {
                DataTable datatable = new DataTable();
                adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand(query, connection);
                adpt.Fill(datatable);
                return datatable;
            }
            else
            {
                MessageBox.Show("Can not Connect to Database");
                return null;
            }
        }

        public DataTable GetAllStores()
        {
            String cmd = "select f.UserID,UserName, f.StoreID, f.StoreName,f.StoreType,f.StoreLocation,f.StoreInfo from MyUser mu inner join (select UserID, s.StoreID, StoreName, StoreType, StoreLocation, StoreInfo from Store s inner join UserStore us on s.StoreID = us.StoreID) as f on f.UserID = mu.UserID";
            DataTable datatable = Query(cmd);
            return datatable;
        }

        public DataTable GetStore(String userID)
        {
            String cmd = "select s.StoreID,StoreName,StoreType,StoreLocation,StoreInfo from Store s inner join UserStore us on s.StoreID = us.StoreID and us.UserID = " + userID;
            DataTable dataTable = Query(cmd);
            return dataTable;
        }


        public DataTable GetProductsData()
        {
            String cmd = "select BrandName,BrandType,ProductName,terms from Product";
            DataTable datatable = Query(cmd);
            return datatable;


        }

        public DataTable GetStoreData()
        {
            String cmd = "select StoreName,StoreType,StoreLocation,StoreInfo from Store";
            DataTable datatable = Query(cmd);
            return datatable;
        }

        public DataTable GetProductsInStore(String StoreID)
        {
            String cmd = "select StoreID, p.ProductName, price, amount from StoreProductStat sps inner join Product p on sps.Product = p.ProductID and sps.StoreID = " + StoreID;
            DataTable dataTable = Query(cmd);
            return dataTable;
        }

        public DataTable GetAllProductsInStore()
        {
            String cmd = "select StoreID, p.ProductName, price, amount from StoreProductStat sps inner join Product p on sps.Product = p.ProductID";
            DataTable dataTable = Query(cmd);
            return dataTable;
        }

        public DataTable GetStoreReq()
        {
            String cmd = "select * from StoreRequests";
            DataTable datatable = Query(cmd);
            return datatable;
        }

        public DataTable GetUsersData()
        {
            String cmd = "select UserID, UserName, Name, Email, Role from MyUser";
            DataTable dataTable = Query(cmd);
            return dataTable;
        }

        public UserData SearchUserList(String UN, string PW)
        {
            String cmd = "select * from MyUser Where UserName=@UserName and Password=@UserPass";
            Command = new SqlCommand(cmd, connection);
            Command.Parameters.AddWithValue("@UserName", UN);
            Command.Parameters.AddWithValue("@UserPass", PW);
            adpt = new SqlDataAdapter(Command);

            DataTable datatable = new DataTable();
            adpt.Fill(datatable);
            String[] tpData = new String[datatable.Columns.Count];
            int i = 0;
            if (datatable.Rows.Count > 0)
            {
                foreach (DataRow row in datatable.Rows)
                {
                    foreach (DataColumn col in datatable.Columns)
                    {
                        tpData[i] = row[col].ToString();
                        i++;
                    }
                }
                UserData tpUD = new UserData(tpData[0], tpData[1], tpData[2], tpData[3], tpData[4], tpData[5]);
                return tpUD;
            }
            else
                return null;

        }
    }

}
