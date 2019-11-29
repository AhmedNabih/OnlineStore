using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.NotSupported;
using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystem.Receivers.ReceiverFactory
{
    public class MaxFactory
    {
        public static IMax GetCommand(String str, String arg) // pass null to arg if not used
        {
            if (str == "Product Max Price User" && arg != null)
                return new ProductMaxPriceUser(arg);
            else if (str == "Product Max Price Store" && arg != null)
                return new ProductMaxPriceStore(arg);
            else if (str == "Product Max Price Default")
                return new ProductMaxPriceDefault();
            else
                return new MaxNotSupportedOperation();
        }
    }
}
