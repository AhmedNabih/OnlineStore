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
            this.hand = Handler.GetInstance();
            this.Data = data;
            NUserPage ap = new NUserPage(this);
            ap.Show();
        }
    }
}
