using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern
{
    public class StoreSumDefault : ISum
    {
        private AdminStatisticsCommandPatternQueries query;

        public StoreSumDefault()
        {
            query = new AdminStatisticsCommandPatternQueries();
        }

        public String Sum()
        {
            return "Stores Sum: " + query.StoreTableSum();
        }
    }
}
