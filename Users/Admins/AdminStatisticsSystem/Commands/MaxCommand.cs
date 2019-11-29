using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystem.Commands
{
    public class MaxCommand : ICommand // COMMAND
    {
        private IMax cmd;

        public MaxCommand(IMax cmd)
        {
            this.cmd = cmd;
        }

        public String Execute()
        {
            return cmd.Max();
        }
    }
}
