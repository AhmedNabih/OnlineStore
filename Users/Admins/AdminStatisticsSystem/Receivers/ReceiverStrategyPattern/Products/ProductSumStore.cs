using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumStore : ISum
    {
        private DataBaseQueries query;
        private String StoreID;

        public ProductSumStore(String StoreID)
        {
            query = new DataBaseQueries();
            this.StoreID = StoreID;
        }

        public string Sum()
        {
            return "Products Sum for Store ID = " + StoreID + ": " + query.ProductTableSumForStore(StoreID);
        }
    }
}
