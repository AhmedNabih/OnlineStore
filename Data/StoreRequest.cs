using System;
using System.Windows.Forms;

namespace OnlineStore.App.Stores.Data
{
    public class StoreRequest
    {
        public String storeRequestID;
        public String userID;
        public StoreRawData storeData;

        public StoreRequest()
        {
            this.storeRequestID = null;
            this.userID = null;
            this.storeData = new StoreRawData();
        }

        public StoreRequest(String storeRequestID, String userID, StoreRawData storeData)
        {
            this.storeRequestID = storeRequestID;
            this.userID = userID;
            this.storeData = storeData;
        }

        public void Handler(String[] data)
        {
            this.storeRequestID = data[0];
            this.userID = data[1];
        }

        public override String ToString()
        {
            return "Store Request ID: " + storeRequestID + " User ID: " + userID + " -> " + storeData.ToString();
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(new String[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                String[] re = tempData[0].Split(' ');
                String[] Refactor = { re[3], re[6] };
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
