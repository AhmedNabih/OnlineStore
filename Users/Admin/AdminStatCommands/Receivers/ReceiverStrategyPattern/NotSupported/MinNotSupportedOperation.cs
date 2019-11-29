using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern.NotSupported
{
    public class MinNotSupportedOperation : IMin
    {
        public string Min()
        {
            return "Min Is Not Supported";
        }
    }
}
