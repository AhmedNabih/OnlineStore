using OnlineStore.Users.Admins.AdminsStatisticsSystem.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystem
{
    public class CommandInvoker // INVOKER
    {

        public CommandInvoker() { }
        
        public static String DoCommand(ICommand cmd)
        {
            return cmd.Execute();
        }


    }
}
