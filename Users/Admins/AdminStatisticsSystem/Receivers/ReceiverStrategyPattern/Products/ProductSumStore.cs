using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumStore : ISum
    {
        private AdminStatisticsCommandPatternQueries query;
        private String StoreID;

        public ProductSumStore(String StoreID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.StoreID = StoreID;
        }

        public string Sum()
        {
            return "Products Sum for Store ID = " + StoreID + ": " + query.ProductTableSumForStore(StoreID);
        }
    }
}
