using OnlineStore.Data;
using OnlineStore.Users.UserFactoryPattern;
using OnlineStore.GUIFiles.Users.Admins;

namespace OnlineStore.Users.Admins
{
    public class Admin : IUser
    {
        public Admin()
        {
        }

        public override void ConnectPage(UserData data)
        {
            this.Data = data;
            AdminsController controller = new AdminsController(this);
            AdminPage ap = new AdminPage(controller);
            ap.Show();
        }

        
        
    }
}
