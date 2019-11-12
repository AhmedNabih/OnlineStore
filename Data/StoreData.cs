using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data
{
    public class StoreData
    {
        public String ID;
        public String Name;
        public String Type;
        public String Location;
        public String Info;

        public StoreData()
        {
            this.Name = null;
            this.Type = null;
            this.Location = null;
            this.Info = null;
        }

        public StoreData(String ID, String name, String type, String location, String info)
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
    }
}
