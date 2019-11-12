using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    public class ProductData
    {
        public String ID;
        public String BrandName;
        public String BrandType;
        public String Name;
        
        public ProductData()
        {
            this.ID = null;
            this.BrandName = null;
            this.BrandType = null;
            this.Name = null;
        }

        public ProductData(String ID,String BN, String BT, String N)
        {
            this.ID = ID;
            this.BrandName = BN;
            this.BrandType = BT;
            this.Name = N;
        }

        public void Handler(String[] data)
        {
            this.ID = data[0];
            this.BrandName = data[1];
            this.BrandType = data[2];
            this.Name = data[3];
        }
        
    }
}
