using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data
{
    public class ProductData
    {
        public String ID;
        public String BrandName;
        public String BrandType;
        public String Name;
        public String terms;
        public int amount;
        
        public ProductData()
        {
            this.ID = null;
            this.BrandName = null;
            this.BrandType = null;
            this.Name = null;
            this.amount = 0;
            this.terms = null;
        }

        public ProductData(String ID,String BN, String BT, String N, String terms, int amount)
        {
            this.ID = ID;
            this.BrandName = BN;
            this.BrandType = BT;
            this.Name = N;
            this.terms = terms;
            this.amount = amount;
        }

        public void Handler(String[] data)
        {
            this.ID = data[0];
            this.BrandName = data[1];
            this.BrandType = data[2];
            this.Name = data[3];
            this.terms = data[4];
            this.amount = System.Convert.ToInt32(data[5]);
        }
        
    }
}
