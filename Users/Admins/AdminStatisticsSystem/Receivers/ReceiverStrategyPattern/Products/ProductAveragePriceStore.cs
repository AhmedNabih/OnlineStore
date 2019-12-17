using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductAveragePriceStore : IAverage
    {
        private AdminStatisticsCommandPatternQueries query;
        private String StoreID;

        public ProductAveragePriceStore(String StoreID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.StoreID = StoreID;
        }

        public String Average()
        {
            double res1 = Convert.ToDouble(query.StorePricesSumForStore(StoreID));
            int res2 = Convert.ToInt32(query.StorePricesCntForStore(StoreID));
            return "Store prices Average for Store ID = " + StoreID + ": " + ((double)res1 / res2).ToString();
        }
    }
}
