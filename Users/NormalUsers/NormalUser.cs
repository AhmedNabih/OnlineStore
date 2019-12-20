using OnlineStore.CartSystem;
using OnlineStore.CartSystem.Cart;
using OnlineStore.Data;
using OnlineStore.Users.UserFactoryPattern;
using System;

namespace OnlineStore.Users.NormalUsers
{
    public class NormalUser : IUser, IBuyable
    {

        private ShoppingCartController controllerCart;

        public NormalUser()
        {
            ShoppingCart CartData = new ShoppingCart();
            this.controllerCart = new ShoppingCartController(CartData);
        }

        public double Buy()
        {
            Double res = controllerCart.calcTotalPrice("NormalUser");
            return res;
        }

        public override void ConnectPage(UserData data)
        {
            this.Data = data;
            NormalUserController controller = new NormalUserController(this);
            NUserPage ap = new NUserPage(controller);
            ap.Show();
        }
    }
}
