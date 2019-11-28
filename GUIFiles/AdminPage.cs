using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.GUIFiles;

namespace OnlineStore
{
    public partial class AdminPage : Form
    {
        private Admin admin;
        private Handler hand;
        public AdminPage(Admin admin)
        {
            this.hand = Handler.GetInstance();
            this.admin = admin;
            InitializeComponent();
            TuserName.Text = admin.Data.userName;
            Temail.Text = admin.Data.email;
            Tname.Text = admin.Data.name;
            Trole.Text = admin.Data.role;
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            AddProductsPage app = new AddProductsPage(admin);
            app.Show();

        }


        private void RefreshProductsList_Click(object sender, EventArgs e)
        {
            ProductsList.Items.Clear();
            DataTable tpData = hand.DB.GetProductsData();
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ", ";
                }
                ProductsList.Items.Add(tpStr.Substring(0, tpStr.Length - 2));
            }
        }


        private void RemoveCheckedProduct_Click(object sender, EventArgs e)
        {


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            hand.Exit();
        }

        private void ShowReq_Click(object sender, EventArgs e)
        {
            StoresReq.Items.Clear();
            DataTable tpData = hand.DB.GetStoreReq();
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                StoresReq.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        }

        private void AddCheckedStoresReq_Click(object sender, EventArgs e)
        {
            List<String> select = new List<string>();
            for (int i=0; i<StoresReq.Items.Count; i++)
            {
                if (StoresReq.GetItemChecked(i))
                {
                    select.Add(StoresReq.Items[i].ToString());
                }
            }
            foreach(String str in select)
            {
                String[] data = str.Split(',');
                admin.AddStoreFromReq(data);
            }
            MessageBox.Show("Stores Added");
        }

        private void RemoveCheckedStoresReq_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            AdminStatistic adminStatistic = new AdminStatistic();
            adminStatistic.Show();
        }
    }
}
