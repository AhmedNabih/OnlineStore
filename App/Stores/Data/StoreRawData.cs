using System;
using System.Windows.Forms;

namespace OnlineStore.App.Stores.Data
{
    public class StoreRawData
    {
        public String ID;
        public String Name;
        public String Type;
        public String Location;
        public String Info;

        public StoreRawData()
        {
            this.Name = null;
            this.Type = null;
            this.Location = null;
            this.Info = null;
        }

        public StoreRawData(String ID, String name, String type, String location, String info)
        {
            this.ID = ID;
            this.Name = name;
            this.Type = type;
            this.Location = location;
            this.Info = info;
        }

        public void Handler(String[] data)
        {
            this.ID = data[0];
            this.Name = data[1];
            this.Type = data[2];
            this.Location = data[3];
            this.Info = data[4];
        }
        public override String ToString()
        {
            String str = "Store ID: " + ID + " Store Name: " + Name + " Store Type: " + Type  + " Store Location: " + Location + " Store Information: " + Info;
            return str;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(' ');
                String[] Refactor = { tempData[2], tempData[4], tempData[6] , tempData[8], tempData[10] };
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
