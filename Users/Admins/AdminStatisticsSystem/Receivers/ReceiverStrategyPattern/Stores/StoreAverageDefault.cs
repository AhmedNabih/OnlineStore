using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Stores
{
    public class StoreAverageDefault : IAverage
    {
        private DataBaseQueries query;

        public StoreAverageDefault()
        {
            query = new DataBaseQueries();
        }

        public String Average()
        {
            int res1 = Convert.ToInt32(query.StoreTableSum());
            int res2 = Convert.ToInt32(query.StoreOwnersSum());
            return ((double)res1 / res2).ToString();
        }
    }
}
