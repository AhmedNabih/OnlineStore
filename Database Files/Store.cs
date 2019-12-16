using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Data;
using OnlineStore.Database_Files;

namespace OnlineStore.srcFiles
{
    public class Store
    {
        public StoreData SD; //con.
        public Statistics SS;
        public Dictionary<String, Statistics> PS;
        public ProductData[] PD;
        private DataBase dataBase; //con.


        public Store(StoreData SD)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.dataBase = DataBase.GetInstance(connectionString);

            PS = new Dictionary<string, Statistics>();
            this.SD = SD;
            
        }

        public void GetStat()
        {
            String cmd1 = "select NumOfViews,NumOfSold from MyStatistics MS inner join StoreStat SS on MS.StatID = SS.StatID and SS.StoreID = " + SD.ID;
            DataTable tp = dataBase.Query(cmd1);
            if (tp.Rows.Count > 0)
            {
                String[] tpData = new String[2];
                foreach (DataRow row in tp.Rows)
                {
                    int i = 0;
                    foreach (DataColumn col in tp.Columns)
                    {
                        tpData[i] = row[col].ToString();
                    }

                }
                int num1 = System.Convert.ToInt32(tpData[0]);
                int num2 = System.Convert.ToInt32(tpData[1]);
                SS = new Statistics(num1, num2);
            }

            String cmd2 = "select SS.Product,NumOfViews,NumOfSold from MyStatistics MS inner join StoreProductStat SS on MS.StatID = SS.StatID and SS.StoreID = " + SD.ID;
            tp = dataBase.Query(cmd2);
            if (tp.Rows.Count > 0)
            {
                foreach (DataRow row in tp.Rows)
                {
                    String[] tpData = new String[3];
                    int i = 0;
                    foreach (DataColumn col in tp.Columns)
                    {
                        tpData[i] = row[col].ToString();
                        i++;
                    }
                    try
                    {
                        PS.Add(tpData[0], new Statistics(System.Convert.ToInt32(tpData[1]), System.Convert.ToInt32(tpData[2])));
                    }
                    catch
                    {
                        //MessageBox.Show("el dania biza");
                    }
                }
            }
        }

        public void GetProducts()
        {
            int i = 0;
            string cmd = "select ProductID,ProductName,BrandName,BrandType,SPS.amount,SPS.price from Product P inner join StoreProductStat SPS on P.ProductID = SPS.Product and SPS.StoreID =" + SD.ID;
            DataTable tp = dataBase.Query(cmd);
            if (tp.Rows.Count > 0)
            {
                int sz = tp.Rows.Count;
                PD = new ProductData[sz];
                for (int k = 0; k < sz; k++)
                    PD[k] = new ProductData();
                foreach (DataRow row in tp.Rows)
                {
                    String tpStr = "";
                    foreach (DataColumn col in tp.Columns)
                    {
                        tpStr += row[col].ToString() + ",";
                    }
                    PD[i].Handler(tpStr.Split(','));
                    i++;
                }
            }

        }
        public void addProduct()
        {

        }
        
    }
}
