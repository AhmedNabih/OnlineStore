using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductAveragePriceDefault : IAverage
    {
        private DataBaseQueries query;

        public ProductAveragePriceDefault()
        {
            query = new DataBaseQueries();
        }

        public String Average()
        {
            double res1 = Convert.ToDouble(query.StorePricesSum());
            int res2 = Convert.ToInt32(query.StorePricesCnt());
            return "Store prices Average: " + ((double)res1 / res2).ToString();
        }
    }
}
