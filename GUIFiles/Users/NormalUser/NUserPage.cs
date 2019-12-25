using OnlineStore.CartSystem;
using OnlineStore.CartSystem.Cart;
using OnlineStore.Database_Files;
using OnlineStore.GUIFiles;
using OnlineStore.Users;
using OnlineStore.Users.NormalUsers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class NUserPage : Form
    {
        public static int amount;
        private NormalUserController controller;
        private ShoppingCartController cartController;
        private ShoppingCartControllerQueries queries;
        private IBuyable buyable;
        public CartItem cartObject;
        public string StoreID;
        public string ActualAmount;
        public string statID;
        public NUserPage(NormalUserController user, ShoppingCartController cartController, IBuyable buyable)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            queries = new ShoppingCartControllerQueries(connectionString);
            this.controller = user;
            InitializeComponent();
            TuserName.Text = controller.normalUser.Data.userName;
            Temail.Text = controller.normalUser.Data.email;
            Tname.Text = controller.normalUser.Data.name;
            Trole.Text = controller.normalUser.Data.role;
            this.cartController = cartController;
            this.buyable = buyable;
            cartObject = new CartItem();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
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
            DataTable tpData = controller.GetAllStores();
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
            String[] s = null;
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
            StoreID = s[2];
            DataTable tpData = controller.GetProductsInStore(s[2]);
            DataTable StatID=queries.GetStatID(s[2]);
            statID=StatID.Rows[0].ItemArray[0].ToString();
            queries.UpdateViews(statID);
            if (tpData == null)
                return;
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

        private void AddToCart_Click(object sender, EventArgs e)
        {
            
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
            foreach (int inx in select)
            {
                s = Products.Items[inx].ToString().Split(',');
            }
            ActualAmount = s[6];
            ProductInfo temp = new ProductInfo(System.Convert.ToInt32(ActualAmount));
            temp.ShowDialog();
            if (amount != 0)
            {
                DataTable firstTime = queries.isItFirstTime(controller.normalUser.Data.ID);
                if (firstTime.Rows.Count <= 0)
                    cartObject = new CartItem(s[7], s[0], System.Convert.ToDouble(s[5]), amount, true);
                else
                {
                    cartObject = new CartItem(s[7], s[0], System.Convert.ToDouble(s[5]), amount, false);
                }
                cartController.addCartItem(cartObject);
            }
            else
                MessageBox.Show("failed to add items to the cart");
        }

        private void ViewCart_Click(object sender, EventArgs e)
        {
            cartController.viewCart();
            Cart cart = new Cart(cartController,controller,buyable,StoreID,ActualAmount,statID);
            cart.ShowDialog();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
