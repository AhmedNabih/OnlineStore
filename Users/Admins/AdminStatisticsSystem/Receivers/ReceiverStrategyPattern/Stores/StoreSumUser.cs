using OnlineStore.Database_Files;
using System;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Stores
{
    public class StoreSumUser : ISum
    {
        private DataBaseQueries query;
        private String UserID;

        public StoreSumUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public string Sum()
        {
            return "Stores Sum For User ID = " + UserID + ": " + query.StoreTableSumForUser(this.UserID);
        }
    }
}
