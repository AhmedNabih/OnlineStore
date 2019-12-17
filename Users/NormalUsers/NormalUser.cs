using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;
using OnlineStore.srcFiles;
using OnlineStore.Users.UserFactoryPattern;

namespace OnlineStore.Users.NormalUsers
{
    public class NormalUser : IUser
    {
        public NormalUser() { }

        public override void ConnectPage(UserData data)
        {
            this.hand = UserController.GetInstance();
            this.Data = data;
            NormalUser controller = new NormalUser();
            NUserPage ap = new NUserPage(controller);
            ap.Show();
        }
    }
}
