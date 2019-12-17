using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductAveragePriceUser : IAverage
    {
        private AdminStatisticsCommandPatternQueries query;
        private String UserID;

        public ProductAveragePriceUser(String UserID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.UserID = UserID;
        }

        public String Average()
        {
            double res1 = 0.0;
            try { res1 = Convert.ToDouble(query.StorePricesSumForUser(UserID)); } catch { res1 = 0.0; }
            int res2 = Convert.ToInt32(query.StorePricesCntForUser(UserID));
            return "Store prices Average for User ID = " + UserID + ": " + ((double)res1 / res2).ToString();
        }
    }
}
