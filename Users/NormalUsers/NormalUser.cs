using OnlineStore.Data;
using OnlineStore.ShoppingCart;
using OnlineStore.Users.UserFactoryPattern;

namespace OnlineStore.Users.NormalUsers
{
    public class NormalUser : IUser, IBuyable
    {

        public NormalUser() { }

        public double Buy(CartObject obj)
        {
            return obj.GetPrice();
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
