using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles
{
    public partial class AdminStatistic : Form
    {
        private Handler hand;
        private MyDataBase DB;
        private bool Users, Store;

        public AdminStatistic()
        {
            hand = Handler.GetInstance();
            DB = hand.DB;
            this.Users = false;
            this.Store = false;
            InitializeComponent();
        }

        private void BShowUsers_Click(object sender, EventArgs e)
        {
            this.Users = true;
            this.Store = false;
            StatBox.Items.Clear();
            StatBox.Items.Add("All");

            // UserID, UserName, Name, Email, Role
            DataTable tpData = DB.GetUsersData();

            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ", ";
                }
                StatBox.Items.Add(tpStr.Substring(0, tpStr.Length - 2));
            }
        }

        private void BShowStores_Click(object sender, EventArgs e)
        {
            String SelectedString;
            DataTable tpData = new DataTable();

            if (StatBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Something.");
            }
            else
            {
                SelectedString = StatBox.SelectedItem.ToString();
                if (this.Users && SelectedString != "All")
                {
                    // StoreID, StoreName, StoreType, StoreLocation, StoreInfo
                    tpData = DB.GetStore(SelectedString.Split(',')[0]);
                }
                else
                {
                    // UserID, UserName, StoreID, StoreName, StoreType, StoreLocation, StoreInfo
                    tpData = DB.GetAllStores();
                }

                this.Users = false;
                this.Store = true;
                StatBox.Items.Clear();
                StatBox.Items.Add("All");
                foreach (DataRow row in tpData.Rows)
                {
                    String tpStr = "";
                    foreach (DataColumn col in tpData.Columns)
                    {
                        tpStr += row[col].ToString() + ", ";
                    }
                    StatBox.Items.Add(tpStr.Substring(0, tpStr.Length - 2));
                }
            }

        }

        private void BShowProducts_Click(object sender, EventArgs e)
        {
            String SelectedString;
            DataTable tpData = new DataTable();

            if (StatBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Something.");
            }
            else
            {
                SelectedString = StatBox.SelectedItem.ToString();
                if (this.Store && SelectedString != "All")
                {
                    // StoreID, ProductName, price, amount
                    tpData = DB.GetProductsInStore(SelectedString.Split(new String[] { ", "},StringSplitOptions.RemoveEmptyEntries)[2]);
                }
                else
                {
                    // // StoreID, ProductName, price, amount
                    tpData = DB.GetAllProductsInStore();
                }

                this.Users = false;
                this.Store = false;
                StatBox.Items.Clear();
                StatBox.Items.Add("All");
                foreach (DataRow row in tpData.Rows)
                {
                    String tpStr = "";
                    foreach (DataColumn col in tpData.Columns)
                    {
                        tpStr += row[col].ToString() + ", ";
                    }
                    StatBox.Items.Add(tpStr.Substring(0, tpStr.Length - 2));
                }
            }
        }

        private void BSum_Click(object sender, EventArgs e)
        {

        }

        private void BAverage_Click(object sender, EventArgs e)
        {

        }

        private void BMax_Click(object sender, EventArgs e)
        {

        }

        private void BMin_Click(object sender, EventArgs e)
        {

        }

        private void BClear_Click(object sender, EventArgs e)
        {
            this.Users = false;
            this.Store = false;
            StatBox.Items.Clear();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            hand.Exit();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
