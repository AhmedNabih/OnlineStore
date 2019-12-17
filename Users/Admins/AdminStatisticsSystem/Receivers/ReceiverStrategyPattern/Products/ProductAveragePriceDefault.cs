using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductAveragePriceDefault : IAverage
    {
        private AdminStatisticsCommandPatternQueries query;

        public ProductAveragePriceDefault()
        {
            query = new AdminStatisticsCommandPatternQueries();
        }

        public String Average()
        {
            double res1 = Convert.ToDouble(query.StorePricesSum());
            int res2 = Convert.ToInt32(query.StorePricesCnt());
            return "Store prices Average: " + ((double)res1 / res2).ToString();
        }
    }
}
