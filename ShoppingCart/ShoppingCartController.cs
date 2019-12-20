using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OnlineStore.ShoppingCart
{
    public class ShoppingCartController
    {
        ShoppingCart cart;
        ShoppingCartControllerQueries queries;
        public ShoppingCartController()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            this.queries = new ShoppingCartControllerQueries(connectionString);
            cart = new ShoppingCart();
            
        }
        public void addCartItem(CartObject obj)
        {
            cart.ListItem.Add(obj);
            MessageBox.Show("Succeful");
        }
        public void deleteCartItem(CartObject obj)
        {
            cart.ListItem.Remove(obj);
        }
        public void viewCart()
        {

        }

        public double calcTotalPrice(String identifer)
        {
            double totalPrice = 0.0;
            foreach (CartObject obj in cart.ListItem)
            {
                IBuyable buyable = UserCartFactory.CreateUserBuyable(identifer);
                buyable = new BuyableDecorated(buyable);
                
                if (obj.FirstTime())
                {
                    buyable = new FirstTimeBuy(buyable);
                }
                if (obj.GetAmount() >= 2)
                {
                    buyable = new TwoOfSameItemBuy(buyable);
                }
                
                double objPrice = buyable.Buy(obj);

                totalPrice += objPrice;
            }

            return totalPrice;
        }

    }
}
