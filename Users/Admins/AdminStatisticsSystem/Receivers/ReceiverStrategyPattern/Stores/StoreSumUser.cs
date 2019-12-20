using OnlineStore.Queries_Controllers;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Stores
{
    public class StoreSumUser : ISum
    {
        private AdminStatisticsCommandPatternQueries query;
        private String UserID;

        public StoreSumUser(String UserID)
        {
            query = new AdminStatisticsCommandPatternQueries();
            this.UserID = UserID;
        }

        public String Sum()
        {
            return "Stores Sum For User ID = " + UserID + ": " + query.StoreTableSumForUser(this.UserID);
        }
    }
}
