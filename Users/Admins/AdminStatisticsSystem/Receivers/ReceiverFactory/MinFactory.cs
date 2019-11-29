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
    public class MinFactory
    {
        public static IMin GetCommand(String str, String arg) // pass null to arg if not used
        {
            if (str == "Product Min Price User" && arg != null)
                return new ProductMinPriceUser(arg);
            else if (str == "Product Min Price Store" && arg != null)
                return new ProductMinPriceStore(arg);
            else if (str == "Product Min Price Default")
                return new ProductMinPriceDefault();
            else
                return new MinNotSupportedOperation();
        }
    }
}
