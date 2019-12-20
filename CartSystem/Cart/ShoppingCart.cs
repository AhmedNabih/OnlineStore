using System.Collections.Generic;

namespace OnlineStore.CartSystem.Cart
{
    public class ShoppingCart
    {
        private List<CartItem> ListItem;

        public ShoppingCart()
        {
            ListItem = new List<CartItem>();
        }
       
        public List<CartItem> GetCartData()
        {
            return this.ListItem;
        }
    }
}
