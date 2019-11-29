using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins
{
    public class AdminsController
    {
        private IUser Admins;

        public AdminsController(Admin Admins)
        {
            this.Admins = Admins;
        }

        public void Statictices()
        {

        }

    }
}
