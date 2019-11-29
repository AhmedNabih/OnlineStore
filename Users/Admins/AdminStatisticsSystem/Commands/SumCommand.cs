using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystem.Commands
{
    public class SumCommand : ICommand  // COMMAND
    {
        private ISum cmd;

        public SumCommand(ISum cmd)
        {
            this.cmd = cmd;
        }

        public String Execute()
        {
            return cmd.Sum();
        }
    }
}
