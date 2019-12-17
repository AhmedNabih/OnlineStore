using System.Collections.Generic;

namespace OnlineStore.ShoppingCart
{
    class ShoppingCart
    {
       public List<CartObject> ListItem;
        public ShoppingCart()
        {
            ListItem = new List<CartObject>();
        }
       
    }
}
