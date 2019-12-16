using OnlineStore.Database_Files;
using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern
{
    public class UserSumDefault : ISum
    {
        private DataBaseQueries query;

        public UserSumDefault()
        {
            query = new DataBaseQueries();
        }

        public String Sum()
        {
            return "Users Sum: " + query.UserTableSum();
        }
    }
}
