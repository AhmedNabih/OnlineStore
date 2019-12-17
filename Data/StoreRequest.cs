using System;
using System.Windows.Forms;

namespace OnlineStore.App.Stores.Data
{
    public class StoreRequest
    {
        public String userID;
        public StoreRawData storeData;

        public StoreRequest()
        {
            this.userID = null;
            this.storeData = null;
        }

        public StoreRequest(String userID, StoreRawData storeData)
        {
            this.userID = userID;
            this.storeData = storeData;
        }

        public void Handler(String[] data)
        {
            this.userID = data[0];
        }

        public override String ToString()
        {
            return userID + " -> " + storeData.ToString();
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(new String[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                String[] Refactor = { tempData[0] };
                Handler(Refactor);
                storeData.RefactorString(tempData[1]);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
