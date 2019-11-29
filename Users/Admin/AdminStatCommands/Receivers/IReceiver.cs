using OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers
{
    public interface IReceiver  // RECEIVER
    {
        public abstract String Sum(ISum bahavior);

        public abstract String Average(IAverage behavior);

        public abstract String Max(IMax behavior);

        public abstract String Min(IMin behavior);

    }
}
