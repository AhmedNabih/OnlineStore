using OnlineStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.App.Stores.Data
{
    public class UserStoreData
    {
        public String UserID;
        public StoreRawData storeData;
        public Statistics storeStatistics;

        public UserStoreData()
        {
            this.UserID = null;
            this.storeData = new StoreRawData();
            this.storeStatistics = new Statistics();
        }

        public UserStoreData(String UserID, StoreRawData storeData, Statistics storeStatistics)
        {
            this.UserID = UserID;
            this.storeData = storeData;
            this.storeStatistics = storeStatistics;
        }

        public void Handler(String[] data)
        {
            this.UserID = data[0];
            String[] dumy = new String[5];
            int i = 0;
            for (; i < 5; i++)
                dumy[i] = data[i + 1];
            storeData.Handler(dumy);
            dumy = new String[4];
            for (int j = 0; i < 9; i++, j++)
                dumy[j] = data[i];
            storeStatistics.Handler(dumy);
        }

        public override String ToString()
        {
            String str = "User ID: " + UserID + " -> " + storeData.ToString() + " -> " + storeStatistics.ToString();
            return str;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(new String[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                String[] re = tempData[0].Split(' ');
                this.UserID = re[0];
                storeData.RefactorString(tempData[1]);
                storeStatistics.RefactorString(tempData[2]);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
