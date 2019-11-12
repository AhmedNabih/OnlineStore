using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
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
