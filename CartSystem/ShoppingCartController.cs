using OnlineStore.CartSystem.Cart;
using OnlineStore.CartSystem.DecoratedClasses;
using OnlineStore.CartSystem.TotalPriceDecorator;
using OnlineStore.CartSystem.TotalPriceDecorator.DecoratedClasses;
using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineStore.CartSystem
{
    public class ShoppingCartController
    {
        private ShoppingCart cartData;
        private ShoppingCartControllerQueries queries;

        public ShoppingCartController(ShoppingCart cartData)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);
            this.queries = new ShoppingCartControllerQueries(connectionString);
            
            this.cartData = cartData;
        }

        public void addCartItem(CartItem obj)
        {
            this.cartData.GetCartData().Add(obj);
            MessageBox.Show("Succeful");
        }
        public void deleteCartItem(CartItem obj)
        {
            this.cartData.GetCartData().Remove(obj);
        }

        public List<CartItem> viewCart()
        {
            return this.cartData.GetCartData();
        }

        public double calcTotalPrice(String identifer)
        {
            double totalPrice = 0.0;
            foreach (CartItem obj in this.cartData.GetCartData())
            {
                ICartItem cartItem = obj;

                ICart cartObject = new SimpleCart();
                cartObject = new CartDecorated(cartObject);
                
                if (obj.FirstTime())
                {
                    cartObject = new FirstTimeBuy(cartObject);
                }
                if (obj.GetAmount() >= 2)
                {
                    cartObject = new TwoOfSameItemBuy(cartObject);
                }
                
                double objPrice = cartObject.CalcPrice(cartItem);

                totalPrice += objPrice;
            }

            ITotalPrice totalPriceObject = new SimpleTotalPrice(totalPrice);
            totalPriceObject = new TotalPriceDecorated(totalPriceObject);
            totalPriceObject = TotalPriceUserFactory.CreateUserTotalPrice(identifer, totalPriceObject);
            totalPrice = totalPriceObject.TotalPrice();

            return totalPrice;
        }

    }
}
