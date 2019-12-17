using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumDefault : ISum
    {
        private AdminStatisticsCommandPatternQueries query;

        public ProductSumDefault()
        {
            query = new AdminStatisticsCommandPatternQueries();
        }

        public String Sum()
        {
            return "Product Sum: " + query.ProductTableSum();
        }
    }
}
