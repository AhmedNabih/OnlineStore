using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceUser : IMin
    {
        private AdminStatisticsCommandPatternQueries query;
        private String UserID;

        public ProductMinPriceUser(String UserID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.UserID = UserID;
        }

        public String Min()
        {
            return "Min Product Price for User ID = " + UserID + ": " + query.StorePricesMinForUser(UserID);
        }
    }
}
