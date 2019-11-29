using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern
{
    public class StoreSumDefault : ISum
    {
        private DataBaseQueries query;

        public StoreSumDefault()
        {
            query = new DataBaseQueries();
        }

        public String Sum()
        {
            return "Stores Sum: " + query.StoreTableSum();
        }
    }
}
