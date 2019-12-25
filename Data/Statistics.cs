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
        public String StatID;
        public int CntView;
        public int CntSold;

        public Statistics()
        {
            this.StatID = null;
            this.CntView = 0;
            this.CntSold = 0;
        }

        public Statistics(String statID, int v, int s)
        {
            this.StatID = statID;
            this.CntView = v;
            this.CntSold = s;
        }

        public void Handler(String[] data)
        {
            this.StatID = data[0];
            this.CntView = System.Convert.ToInt32(data[1]);
            this.CntSold = System.Convert.ToInt32(data[2]);
        }

        public override String ToString()
        {
            return "Statistic ID: " + StatID + " Views: " + CntView + " Sold: " + CntSold;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(' ');
                String[] Refactor = { tempData[2], tempData[4], tempData[6]};
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
