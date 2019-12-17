using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern
{
    public class StoreSumDefault : ISum
    {
        private DataBaseQueries query;

        public StoreSumDefault()
        {
            query = new DataBaseQueries();
        }

        public String Sum()
        {
            return "Stores Sum: " + query.StoreTableSum();
        }
    }
}
