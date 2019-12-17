using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceUser : IMax
    {
        private DataBaseQueries query;
        private String UserID;

        public ProductMaxPriceUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public string Max()
        {
            return "Max Product Price for User ID = " + UserID + ": " + query.StorePricesMaxForUser(UserID);
        }
    }
}
