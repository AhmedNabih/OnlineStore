using OnlineStore.Users.Admins.AdminsStatisticsSystem.Commands;
using System;

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
