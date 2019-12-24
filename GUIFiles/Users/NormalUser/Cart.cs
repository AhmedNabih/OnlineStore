using OnlineStore.CartSystem;
using OnlineStore.CartSystem.Cart;
using OnlineStore.Database_Files;
using OnlineStore.Users;
using OnlineStore.Users.NormalUsers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles
{
    public partial class Cart : Form
    {
        ShoppingCartControllerQueries querie;
        public NormalUserController controller;
        List<CartItem> ListItem;
        private IBuyable buyable;
        public string StoreID;
        public string Actualamount;
        public string statID;
        public Cart(ShoppingCartController cartController, NormalUserController controller, IBuyable buyable,string s,string amount,string statID)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            this.buyable = buyable;
            InitializeComponent();
            this.cartController = cartController;
            this.controller = controller;
            ListItem = cartController.viewCart();
            this.StoreID = s;
            this.Actualamount = amount;
            this.statID = statID;
            this.querie = new ShoppingCartControllerQueries(connectionString);
        }


        private void Cart_Load(object sender, EventArgs e)
        {
           

            foreach (CartItem item in ListItem)
            {
                String tpStr = "";

                tpStr += item.GetName() + "," + item.GetPrice() + "," + item.GetAmount() + ",";

                checkedListBox1.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double price = buyable.Buy();
            MessageBox.Show(price.ToString());
            string[] s = null ;
            for(int i=0;i<ListItem.Count;i++)
            {

                querie.InsertIntoTransacations(controller.normalUser.Data.ID, ListItem[i].GetProductID());
            }
            for (int i = 0; i < ListItem.Count; i++)
            {

                querie.UpdateAmount(StoreID, (System.Convert.ToInt32(Actualamount) - ListItem[i].GetAmount()).ToString());
                querie.UpdateNumOfSold(statID,ListItem[i].GetAmount().ToString());
            }
        }
    }
}
