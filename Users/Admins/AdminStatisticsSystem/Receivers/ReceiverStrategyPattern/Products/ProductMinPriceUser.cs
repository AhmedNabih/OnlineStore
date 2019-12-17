using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceUser : IMin
    {
        private DataBaseQueries query;
        private String UserID;

        public ProductMinPriceUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public String Min()
        {
            return "Min Product Price for User ID = " + UserID + ": " + query.StorePricesMinForUser(UserID);
        }
    }
}
