using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;

namespace OnlineStore
{
    public class NormalUser : IUser
    {

        public override void ConnectPage(UserData data)
        {
            this.hand = Handler.GetInstance();
            this.Data = data;
            NUserPage ap = new NUserPage();
            ap.Show();
        }
    }
}
