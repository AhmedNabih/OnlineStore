using OnlineStore.Data;
using System;
using System.Collections.Generic;

namespace OnlineStore.App.StoreCommand
{
    public class CommandData : IData
    {
        public String HistoryID;
        public String UserIDCollab;
        public String UsernameCollab;
        public String CmdType;
        public String ProductID;
        public String ProductName;
        public int PAmount;
        public double Price;
        public String StoreID;

        public List<Object> GetData()
        {
            List<Object> list = new List<Object>();
            list.Add(HistoryID);
            list.Add(UserIDCollab);
            list.Add(UsernameCollab);
            list.Add(CmdType);
            list.Add(ProductID);
            list.Add(ProductName);
            list.Add(PAmount);
            list.Add(Price);
            list.Add(StoreID);

            return list;
        }

        public void Handler(List<Object> list)
        {
            HistoryID = (String) list[0];
            UserIDCollab = (String) list[1];
            UsernameCollab = (String) list[2];
            CmdType = (String) list[3];
            ProductID = (String) list[4];
            ProductName = (String) list[5];
            PAmount = Convert.ToInt32((String) list[6]);
            Price = Convert.ToDouble((String)list[7]);
            StoreID = (String) list[8];
        }

        public override string ToString()
        {
            return "History ID: " + HistoryID + " Collaborator User ID: " + UserIDCollab + " Collaborator Username: " + UsernameCollab + " Command Type: " + CmdType + " Product ID: " + ProductID + " Product Name: " + ProductName+ " Amount: " + PAmount + " Price: " + Price + " Store ID: " + StoreID;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] temp = str.Split(' ');
                List<Object> list = new List<Object>();

                list.Add(temp[2]);
                list.Add(temp[6]);
                list.Add(temp[9]);
                list.Add(temp[12]);
                list.Add(temp[15]);
                list.Add(temp[18]);
                list.Add(temp[20]);
                list.Add(temp[22]);
                list.Add(temp[25]);

                Handler(list);
            }
            catch
            {

            }
        }
    }
}
