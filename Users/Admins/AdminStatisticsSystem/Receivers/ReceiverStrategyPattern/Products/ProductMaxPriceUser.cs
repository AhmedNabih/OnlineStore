using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceUser : IMax
    {
        private AdminStatisticsCommandPatternQueries query;
        private String UserID;

        public ProductMaxPriceUser(String UserID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.UserID = UserID;
        }

        public string Max()
        {
            return "Max Product Price for User ID = " + UserID + ": " + query.StorePricesMaxForUser(UserID);
        }
    }
}
