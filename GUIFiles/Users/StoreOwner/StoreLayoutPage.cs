using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OnlineStore.App.Stores;
using OnlineStore.Data;
using OnlineStore.Database_Files;
using OnlineStore.Users.StoreOwners;

namespace OnlineStore.GUIFiles
{
    public partial class StoreLayoutPage : Form
    {
        private Store store;
        private StoreOwner SO;
        private DataBase dataBase;

        public StoreLayoutPage(StoreOwner SO, StoreController store)
        {
            /*
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.dataBase = DataBase.GetInstance(connectionString);
            /*
            this.SO = SO;
            //this.store = SD;
            //store.GetStat();

            InitializeComponent();
            /*
            TuserName.Text = SO.Data.userName;
            Tname.Text = SO.Data.name;
            Temail.Text = SO.Data.email;
            Trole.Text = SO.Data.role;
            TStoreName.Text = store.SD.Name;
            TstoreLocation.Text = store.SD.Location;
            TstoreType.Text = store.SD.Type;
            TnumViews.Text = store.SS.CntView.ToString();
            TnumSold.Text = store.SS.CntSold.ToString();
            */
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowProducts_Click(object sender, EventArgs e)
        {
            /*
            ProductsList.Items.Clear();
            String cmd = "select * from Product";
            DataTable tpData = dataBase.Query(cmd);
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                //Products.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
            */
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            /*
            String cmd;
            List<int> select = new List<int>();
            for (int i = 0; i < Products.Items.Count; i++)
            {
                if (Products.GetItemChecked(i))
                {
                    select.Add(i);
                }
            }
            foreach (int inx in select)
            {
                String cmdStat = "insert into MyStatistics values(" + IDStat + ",0,0)";
                dataBase.QueryExec(cmdStat);

                price = 0.0;
                amount = 0;
                InputData temp = new InputData("Enter Price", "Enter Amount", Products.Items[inx].ToString().Split(',')[3]);
                temp.ShowDialog();

                cmd = "insert into StoreProductStat values (" + store.SD.ID + "," + Products.Items[inx].ToString().Split(',')[0] + "," + IDStat + "," +price+","+amount+")";
                dataBase.QueryExec(cmd);
                MessageBox.Show("Item Added Succesfully");
            }
            */
        }
        

        private static double price = 0.0;
        private static int amount = 0;
        public static void setPrice(double val)
        {
            price = val;
        }
        public static void setAmount(int val)
        {
            amount = val;
        }
        private void BRefresh_Click(object sender, EventArgs e)
        {
            /*
            MyProducts.Items.Clear();
            try
            {
                store.GetProducts();
                for (int i = 0; i < store.PD.Length; i++)
                {
                    String tp = store.PD[i].ID+","+store.PD[i].Name + "," + store.PD[i].BrandName + "," + store.PD[i].BrandType +","+store.PD[i].amount+","+store.PD[i].price;
                    MyProducts.Items.Add(tp);
                }
            }
            catch
            {
                MessageBox.Show("No Data");
            }
            */
        }

        private void ShowProductStat_Click(object sender, EventArgs e)
        {
            /*
            List<int> select = new List<int>();
            for (int i = 0; i < MyProducts.Items.Count; i++)
            {
                if (MyProducts.GetItemChecked(i))
                {
                    select.Add(i);
                }
            }
            store.GetStat();
            foreach (int inx in select)
            {
                String tp = MyProducts.Items[inx].ToString().Split(',')[0];
                Statistics context = store.PS[tp];
                MessageBox.Show(context.CntView+" "+context.CntSold);
            }
            */
        }

    }
}
