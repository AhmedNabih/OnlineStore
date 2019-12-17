using System;
using System.Windows.Forms;

namespace OnlineStore.Data
{
    public class BrandRawData
    {
        public String ID;
        public String Name;
        public String Type;

        public BrandRawData()
        {
            this.ID = null;
            this.Name = null;
            this.Type = null;
        }

        public BrandRawData(String ID, String name, String type)
        {
            this.ID = ID;
            this.Name = name;
            this.Type = type;
        }

        public void Handler(String[] data)
        {
            this.ID = data[0];
            this.Name = data[1];
            this.Type = data[2];
        }

        public override String ToString()
        {
            String str = "Brand ID: " + ID + " Brand Name: " + Name + " Brand Type: " + Type;
            return str;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(' ');
                String[] Refactor = { tempData[2], tempData[4], tempData[6] };
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
