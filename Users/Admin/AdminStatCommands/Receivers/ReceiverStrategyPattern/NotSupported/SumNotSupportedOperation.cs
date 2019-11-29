using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern.NotSupported
{
    public class SumNotSupportedOperation : ISum
    {
        public String Sum()
        {
            return "Sum Is Not Supported";
        }
    }
}
