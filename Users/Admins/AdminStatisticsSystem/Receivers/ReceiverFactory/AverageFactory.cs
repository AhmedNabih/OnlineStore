﻿using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
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
    public class AverageFactory
    {
        public static IAverage GetCommand(String str, String arg) // pass null to arg if not used
        {
            if (str == "Store Average All")
                return new StoreAverageDefault();
            else if (str == "Product Average User" && arg != null)
                return new ProductAveragePriceUser(arg);
            else if (str == "Product Average Store" && arg != null)
                return new ProductAveragePriceStore(arg);
            else if (str == "Product Average All")
                return new ProductAveragePriceDefault();
            else
                return new AverageNotSupportedOperation();
        }
    }
}
