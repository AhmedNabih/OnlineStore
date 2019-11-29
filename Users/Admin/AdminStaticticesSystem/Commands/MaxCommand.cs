using OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystem.Commands
{
    public class MaxCommand : ICommand // COMMAND
    {
        private IReceiver cmds;

        public MaxCommand(IReceiver cmds)
        {
            this.cmds = cmds;
        }

        public String Execute()
        {
            return cmds.Max();
        }
    }
}
