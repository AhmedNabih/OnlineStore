using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceDefault : IMax
    {
        private DataBaseQueries query;

        public ProductMaxPriceDefault()
        {
            query = new DataBaseQueries();
        }

        public string Max()
        {
            return "Max Product Price: " + query.StorePricesMax();
        }
    }
}
