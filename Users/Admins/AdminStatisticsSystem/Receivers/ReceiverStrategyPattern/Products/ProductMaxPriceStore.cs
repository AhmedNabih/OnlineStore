using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceStore : IMax
    {
        private DataBaseQueries query;
        private String StoreID;

        public ProductMaxPriceStore(String StoreID)
        {
            query = new DataBaseQueries();
            this.StoreID = StoreID;
        }

        public string Max()
        {
            return "Max Product Price for Store ID = " + StoreID + ": " + query.StorePricesMaxForStore(StoreID);
        }
    }
}
