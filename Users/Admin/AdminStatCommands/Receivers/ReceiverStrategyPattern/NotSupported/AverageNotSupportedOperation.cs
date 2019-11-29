using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern.NotSupported
{
    public class AverageNotSupportedOperation : IAverage
    {
        public string Average()
        {
            return "Average Is Not Supported";
        }
    }
}
