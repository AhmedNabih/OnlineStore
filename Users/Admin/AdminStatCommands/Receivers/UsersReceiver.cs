using OnlineStore.srcFiles;
using OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers
{
    public class UsersReceiver : IReceiver
    {
        public UsersReceiver() { }

        public String Sum(ISum bahavior)
        {
            return bahavior.Sum();
        }

        public String Average(IAverage behavior)
        {
            return behavior.Average();
        }

        public String Max(IMax behavior)
        {
            return behavior.Max();
        }

        public String Min(IMin behavior)
        {
            return behavior.Min();
        }

    }
}
