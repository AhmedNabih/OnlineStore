﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Commands
{
    public interface ICommand // COMMAND INTEFACE
    {
        public abstract String Execute();
    }
}
