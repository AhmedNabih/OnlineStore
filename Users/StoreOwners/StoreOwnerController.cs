using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.StoreOwners
{
    public class StoreOwnerController
    {
        private IUser storeOwner;

        public StoreOwnerController(StoreOwner storeOwner)
        {
            this.storeOwner = storeOwner;
        }
    }
}
