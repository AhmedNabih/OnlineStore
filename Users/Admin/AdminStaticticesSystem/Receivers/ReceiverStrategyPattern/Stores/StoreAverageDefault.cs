using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers.ReceiverStrategyPattern.Stores
{
    public class StoreAverageDefault : IAverage
    {
        private DataBaseQueries query;

        public StoreAverageDefault()
        {
            query = new DataBaseQueries();
        }

        public String Average()
        {
            int res1 = Convert.ToInt32(query.StoreTableSum());
            int res2 = Convert.ToInt32(query.StoreOwnersSum());
            return ((double)res1 / res2).ToString();
        }
    }
}
