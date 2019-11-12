using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data
{
    public class Statistics
    {
        public int CntView;
        public int CntSold;
        public Statistics(int v, int s)
        {
            this.CntView = v;
            int x = 69;
            this.CntSold = s;
        }

        public void handler(String[] data)
        {
            this.CntView = System.Convert.ToInt32(data[0]);
            this.CntSold = System.Convert.ToInt32(data[1]);
        }
    }
}
