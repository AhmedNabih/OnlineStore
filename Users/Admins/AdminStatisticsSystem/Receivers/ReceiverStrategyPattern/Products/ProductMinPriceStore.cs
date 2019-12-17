using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceStore : IMin
    {
        private AdminStatisticsCommandPatternQueries query;
        private String StoreID;

        public ProductMinPriceStore(String StoreID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.StoreID = StoreID;
        }

        public String Min()
        {
            return "Min Product Price for Store ID = " + StoreID + ": " + query.StorePricesMinForStore(StoreID);
        }
    }
}
