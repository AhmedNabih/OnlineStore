﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers.ReceiverStrategyPattern.NotSupported
{
    public class MaxNotSupportedOperation : IMax
    {
        public string Max()
        {
            return "Max Is Not Supported";
        }
    }
}