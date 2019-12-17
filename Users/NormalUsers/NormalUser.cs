using OnlineStore.Data;
using OnlineStore.Users.UserFactoryPattern;

namespace OnlineStore.Users.NormalUsers
{
    public class NormalUser : IUser
    {
        public NormalUser() { }

        public override void ConnectPage(UserData data)
        {
            this.Data = data;
            NormalUser controller = new NormalUser();
            NUserPage ap = new NUserPage(controller);
            ap.Show();
        }
    }
}
