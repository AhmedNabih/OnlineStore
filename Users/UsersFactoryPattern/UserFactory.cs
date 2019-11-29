using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Users.Admins;
using OnlineStore.Users.NormalUsers;
using OnlineStore.Users.StoreOwners;

namespace OnlineStore.Users.UserFactoryPattern
{
    public class UserFactory
    {
        public static IUser CreateUser(String UserRole)
        {
            if (UserRole == "Admin")
                return new Admin();
            else if (UserRole == "NormalUser")
                return new NormalUser();
            else if (UserRole == "StoreOwner")
                return new StoreOwner();
            else
                throw new NotSupportedException("No User With Role " + UserRole);
        }
    }
}
