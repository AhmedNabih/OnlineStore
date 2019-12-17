using OnlineStore.Users.NormalUsers;
using OnlineStore.Users.StoreOwners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.ShoppingCart
{
    public class UserCartFactory
    {
        public static IBuyable CreateUserBuyable(String key)
        {
            if (key == "StoreOwner")
                return new StoreOwner();
            else if (key == "NormalUser")
                return new NormalUser();
            else
                throw new NotSupportedException("btal habd");
        }
    }
}
