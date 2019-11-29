using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
