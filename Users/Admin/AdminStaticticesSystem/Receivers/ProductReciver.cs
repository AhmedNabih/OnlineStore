using OnlineStore.srcFiles;
using OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers
{
    public class ProductReciver : IReceiver
    {
        public String Sum(ISum behavior)
        {
            return behavior.Sum();
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
