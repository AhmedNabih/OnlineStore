using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern
{
    public class UserSumDefault : ISum
    {
        private AdminStatisticsCommandPatternQueries query;

        public UserSumDefault()
        {
            query = new AdminStatisticsCommandPatternQueries();
        }

        public String Sum()
        {
            return "Users Sum: " + query.UserTableSum();
        }
    }
}
