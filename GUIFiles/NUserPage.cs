using OnlineStore.GUIFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class NUserPage : Form
    {
        private IUser user;
        public static int StoreID;

        public NUserPage(NormalUser user)
        {
            this.user = user;
            InitializeComponent();
            TuserName.Text = user.Data.userName;
            Temail.Text = user.Data.email;
            Tname.Text = user.Data.name;
            Trole.Text = user.Data.role;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Handler.GetInstance().Exit();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }

        private void Store_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NUserPage_Load(object sender, EventArgs e)
        {
           
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Store.Items.Clear();
            DataTable tpData=user.hand.DB.GetAllStores();
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                Store.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        }

        private void OpenStore_Click(object sender, EventArgs e)
        {
            Products.Items.Clear();
            String[] s=null;
            List<int> select = new List<int>();

            for (int i = 0; i < Store.Items.Count; i++)
            {
                if (Store.GetItemChecked(i))
                {
                    select.Add(i);
                    break;
                }
            }
            foreach (int inx in select)
            {
                s = Store.Items[inx].ToString().Split(',');
            }
            StoreID = System.Convert.ToInt32(s[2]);
           DataTable tpData = user.hand.DB.GetProductsInStore(s[3]);
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                Products.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        
        }

        private void Addtocart_Click(object sender, EventArgs e)
        {
            List<int> LIST = new List<int>();
            for (int i = 0; i < Products.Items.Count; i++)
            {
                if (Products.GetItemChecked(i))
                {
                    LIST.Add(i);
                }
            }
            foreach (int inx in LIST)
            {
                AddShippingInfo temp = new AddShippingInfo("Enter Amount", "Enter Shipping address", Products.Items[inx].ToString().Split(',')[0]);
                String[] s = null;
                List<int> select = new List<int>();

                for (int i = 0; i < Products.Items.Count; i++)
                {
                    if (Products.GetItemChecked(i))
                    {
                        select.Add(i);
                        break;
                    }
                }
                foreach (int indx in select)
                {
                    s = Products.Items[indx].ToString().Split(',');
                }
                DataTable tpData = user.hand.DB.getAmount(StoreID, System.Convert.ToInt32(s[1]));
                String tpStr = "";

                foreach (DataRow row in tpData.Rows)
                {
                    foreach (DataColumn col in tpData.Columns)
                    {
                        tpStr += row[col].ToString();
                    }

                }
                temp.setAmount(System.Convert.ToInt32(tpStr));
                temp.SetStoreId(StoreID);
                temp.SetProductID(System.Convert.ToInt32(s[1]));
                temp.ShowDialog();

            }





        }
        private static double price = 0.0;
        private static String amount = null;
        public static void setAmount(double val)
        {
            price = val;
        }
        public static void SetShippingAddress(String val)
        {
            amount = val;
        }

        private void viewCart_Click(object sender, EventArgs e)
        {
            Cart obj = new Cart();
            obj.Show();
        }
    }
}
