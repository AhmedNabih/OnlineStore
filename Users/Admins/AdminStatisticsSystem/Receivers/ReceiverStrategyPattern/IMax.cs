using OnlineStore.Users.Admins.AdminStatisticsSystem.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern
{
    public interface IMax : IReceiverCommands
    {
        public abstract String Max();
    }
}
