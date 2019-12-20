using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.NotSupported
{
    public class MaxNotSupportedOperation : IMax
    {
        public String Max()
        {
            return "Max Is Not Supported";
        }
    }
}
