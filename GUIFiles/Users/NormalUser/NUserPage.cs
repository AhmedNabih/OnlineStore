using OnlineStore.App.Stores.Data;
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
        private StoreProductController controllerStoreProduct;
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
            controllerStoreProduct = new StoreProductController();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Store.Items.Clear();
            List<StoreRawData> storeList = controller.GetAllStores();
            if (storeList == null)
                return;

            foreach (StoreRawData store in storeList)
            {
                Store.Items.Add(store.ToString());
            }
            
        }

        private void OpenStore_Click(object sender, EventArgs e)
        {
            Products.Items.Clear();

            if (Store.SelectedItem == null)
                return;

            String selected = Store.SelectedItem.ToString();
            StoreRawData storeRawData = new StoreRawData();
            storeRawData.RefactorString(selected);

            List<StoreProduct> storeProducts = controllerStoreProduct.GetStoreProducts(storeRawData.ID);
            if (storeProducts == null)
                return;
            foreach (StoreProduct product in storeProducts)
                Products.Items.Add(product.ToString());
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            if (Products.SelectedItem == null)
                return;

            String selected = Products.SelectedItem.ToString();
            StoreProduct storeProduct = new StoreProduct();
            storeProduct.RefactorString(selected);

            int ActualAmount = storeProduct.amount;
            ProductInfo temp = new ProductInfo(ActualAmount);
            temp.ShowDialog();
            if (amount != 0)
            {
                DataTable firstTime = queries.isItFirstTime(controller.normalUser.Data.ID);
                if (firstTime.Rows.Count <= 0)
                    cartObject = new CartItem(storeProduct.storeProductID, storeProduct.product.Name, storeProduct.price, storeProduct.amount, true);
                else
                {
                    cartObject = new CartItem(storeProduct.storeProductID, storeProduct.product.Name, storeProduct.price, storeProduct.amount, false);
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
