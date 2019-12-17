using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceStore : IMax
    {
        private AdminStatisticsCommandPatternQueries query;
        private String StoreID;

        public ProductMaxPriceStore(String StoreID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.StoreID = StoreID;
        }

        public string Max()
        {
            return "Max Product Price for Store ID = " + StoreID + ": " + query.StorePricesMaxForStore(StoreID);
        }
    }
}
