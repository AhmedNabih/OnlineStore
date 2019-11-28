using OnlineStore.Users.Admin.AdminStatCommands.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands
{
    public class CommandInvoker // INVOKER
    {

        public CommandInvoker() { }
        
        public String DoCommand(ICommand cmd)
        {
            return cmd.Execute();
        }


    }
}
