using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystem.Commands
{
    public class AverageCommand : ICommand // COMMAND
    {
        private IAverage cmd;

        public AverageCommand(IAverage cmd)
        {
            this.cmd = cmd;
        }

        public String Execute()
        {
            return cmd.Average();
        }
    }
}
