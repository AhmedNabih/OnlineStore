using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern
{
    public class UserSumDefault : ISum
    {
        private DataBaseQueries query;

        public UserSumDefault()
        {
            query = new DataBaseQueries();
        }

        public String Sum()
        {
            return "Users Sum: " + query.UserTableSum();
        }
    }
}
