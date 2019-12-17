using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceDefault : IMax
    {
        private AdminStatisticsCommandPatternQueries query;

        public ProductMaxPriceDefault()
        {
            query = new AdminStatisticsCommandPatternQueries();
        }

        public String Max()
        {
            return "Max Product Price: " + query.StorePricesMax();
        }
    }
}
