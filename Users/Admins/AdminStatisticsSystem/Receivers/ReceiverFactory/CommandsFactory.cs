using OnlineStore.Users.Admins.AdminsStatisticsSystem.Receivers.ReceiverFactory;
using OnlineStore.Users.Admins.AdminStatisticsSystem.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminStatisticsSystem.Receivers.ReceiverFactory
{
    public abstract class CommandsFactory
    {
        public static IReceiverCommands CreateFactory(String factory, String factoryArg1, String factoryArg2)
        {
            if (factory == "Sum")
                return SumFactory.GetCommand(factoryArg1, factoryArg2);
            else if (factory == "Average")
                return AverageFactory.GetCommand(factoryArg1, factoryArg2);
            else if (factory == "Max")
                return MaxFactory.GetCommand(factoryArg1, factoryArg2);
            else if (factory == "Min")
                return MinFactory.GetCommand(factoryArg1, factoryArg2);
            else
                return null;
        }
    }
}
