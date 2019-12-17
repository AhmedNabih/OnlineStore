using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceDefault : IMin
    {
        private DataBaseQueries query;

        public ProductMinPriceDefault()
        {
            query = new DataBaseQueries();
        }

        public String Min()
        {
            return "Min Product Price: " + query.StorePricesMin();
        }
    }
}
