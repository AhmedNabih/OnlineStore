﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users
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