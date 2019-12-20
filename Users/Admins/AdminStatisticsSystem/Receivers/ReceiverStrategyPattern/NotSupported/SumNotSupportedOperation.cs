using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.NotSupported
{
    public class SumNotSupportedOperation : ISum
    {
        public String Sum()
        {
            return "Sum Is Not Supported";
        }
    }
}
