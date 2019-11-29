using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceDefault : IMin
    {
        private DataBaseQueries query;

        public ProductMinPriceDefault()
        {
            query = new DataBaseQueries();
        }

        public String Min()
        {
            return "Min Product Price: " + query.StorePricesMin();
        }
    }
}
