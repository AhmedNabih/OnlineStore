using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.NotSupported
{
    public class AverageNotSupportedOperation : IAverage
    {
        public String Average()
        {
            return "Average Is Not Supported";
        }
    }
}
