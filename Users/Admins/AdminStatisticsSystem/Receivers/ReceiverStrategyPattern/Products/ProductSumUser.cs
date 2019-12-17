using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumUser : ISum
    {
        private AdminStatisticsCommandPatternQueries query;
        private String UserID;

        public ProductSumUser(String UserID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.UserID = UserID;
        }

        public string Sum()
        {
            return "Products Sum for User ID = " + UserID + ": " + query.ProductTableSumForUser(UserID);
        }
    }
}
