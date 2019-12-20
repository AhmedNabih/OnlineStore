using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceDefault : IMin
    {
        private AdminStatisticsCommandPatternQueries query;

        public ProductMinPriceDefault()
        {
            query = new AdminStatisticsCommandPatternQueries();
        }

        public String Min()
        {
            return "Min Product Price: " + query.StorePricesMin();
        }
    }
}
