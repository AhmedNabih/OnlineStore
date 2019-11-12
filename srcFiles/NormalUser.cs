using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;

namespace OnlineStore
{
    public class NormalUser : User
    {

        public override void ConnectPage(UserData data, handler hand)
        {
            this.hand = hand;
            this.Data = data;
            NUserPage ap = new NUserPage();
            ap.Show();
        }
    }
}
