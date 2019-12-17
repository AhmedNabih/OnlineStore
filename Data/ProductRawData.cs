using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.Data
{
    public class ProductRawData
    {
        public String ID;
        public String Name;
        public String Type;

        public ProductRawData()
        {
            this.ID = null;
            this.Name = null;
            this.Type = null;
        }

        public ProductRawData(String ID, String name, String type)
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
            String str = "Product ID: " + ID + " Product Name: " + Name + " Product Type: " + Type;
            return str;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(' ');
                String[] Refactor = { tempData[2], tempData[5], tempData[8] };
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: "+str+" is not in the right format");
            }
        }
    }
}
