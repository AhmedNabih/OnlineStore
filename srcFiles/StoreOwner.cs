﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.srcFiles;

namespace WindowsFormsApp1
{
    public class StoreOwner : User
    {
        public Store[] storeslist;

        public override void ConnectPage(UserData data, handler hand)
        {
            this.hand = hand;
            this.Data = data;
            StoreOwnerPage ap = new StoreOwnerPage(this, hand);
            ap.Show();
        }


        public void RefreshData()
        {
            String cmd1 = "select count(UserID) from UserStore where UserID = " + Data.ID+"";
            DataTable tp = hand.DB.Query(cmd1);
            int sz = System.Convert.ToInt32(tp.Rows[0][0].ToString());
            storeslist = new Store[sz];
            String cmd2 = "select Store.StoreID,StoreName,StoreType,StoreLocation,StoreInfo from Store inner join UserStore on Store.StoreID = UserStore.StoreID and UserStore.UserID = " + Data.ID;
            DataTable tpData = hand.DB.Query(cmd2);
            int i = 0;
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }

                StoreData tpStoreData = new StoreData();
                tpStoreData.Handler(tpStr.Split(','));
                storeslist[i] = new Store(tpStoreData,hand);
                i++;
            }
        }

        public void AddStore(String name, String type, String Location, String info)
        {
            String cmd = "insert into StoreRequests (UserID,StoreName,Storetype,StoreLocation,StoreInfo) values(" + Data.ID + ",'" + name + "','" + type + "','" + Location + "','" + info + "')";
            hand.DB.QueryExec(cmd);
        }

        public void DeleteStore(String StoreID)
        {
            String cmd = "Delete from Store where StoreID = " + StoreID;
            hand.DB.QueryExec(cmd);
        }
    }
}