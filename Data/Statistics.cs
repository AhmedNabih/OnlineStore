using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.Data
{
    public class Statistics
    {
        public String ID;
        public String StatID;
        public int CntView;
        public int CntSold;

        public Statistics()
        {
            this.ID = null;
            this.StatID = null;
            this.CntView = 0;
            this.CntSold = 0;
        }

        public Statistics(String id,String statID, int v, int s)
        {
            this.ID = id;
            this.StatID = statID;
            this.CntView = v;
            this.CntSold = s;
        }

        public void Handler(String[] data)
        {
            this.ID = data[0];
            this.StatID = data[1];
            this.CntView = System.Convert.ToInt32(data[2]);
            this.CntSold = System.Convert.ToInt32(data[3]);
        }

        public override String ToString()
        {
            return "From ID: " + ID + " Statistic ID: " + StatID + " Views: " + CntView + " Sold: " + CntSold;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(' ');
                String[] Refactor = { tempData[2], tempData[5], tempData[7], tempData[9]};
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
