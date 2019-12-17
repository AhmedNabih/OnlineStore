using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumUser : ISum
    {
        private DataBaseQueries query;
        private String UserID;

        public ProductSumUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public string Sum()
        {
            return "Products Sum for User ID = " + UserID + ": " + query.ProductTableSumForUser(UserID);
        }
    }
}
