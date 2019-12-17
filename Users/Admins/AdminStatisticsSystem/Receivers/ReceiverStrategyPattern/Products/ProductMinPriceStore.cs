using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceStore : IMin
    {
        private DataBaseQueries query;
        private String StoreID;

        public ProductMinPriceStore(String StoreID)
        {
            query = new DataBaseQueries();
            this.StoreID = StoreID;
        }

        public String Min()
        {
            return "Min Product Price for Store ID = " + StoreID + ": " + query.StorePricesMinForStore(StoreID);
        }
    }
}
