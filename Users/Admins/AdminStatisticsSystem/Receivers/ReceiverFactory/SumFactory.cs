using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.NotSupported;
using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products;
using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystem.Receivers.ReceiverFactory
{
    public class SumFactory
    {
        public static ISum GetCommand(String str, String arg) // pass null to arg if not used
        {
            if (str == "User Sum All")
                return new UserSumDefault();
            else if (str == "Store Sum All")
                return new StoreSumDefault();
            else if (str == "Product Sum All")
                return new ProductSumDefault();
            else if (str == "Store Sum User" && arg != null)
                return new StoreSumUser(arg);
            else if (str == "Product Sum User" && arg != null)
                return new ProductSumUser(arg);
            else if (str == "Product Sum Store" && arg != null)
                return new ProductSumStore(arg);
            else
                return new SumNotSupportedOperation();
        }
    }
}
