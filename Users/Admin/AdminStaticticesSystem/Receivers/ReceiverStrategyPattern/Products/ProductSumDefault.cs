using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumDefault : ISum
    {
        private DataBaseQueries query;

        public ProductSumDefault()
        {
            query = new DataBaseQueries();
        }

        public string Sum()
        {
            return "Product Sum: " + query.ProductTableSum();
        }
    }
}
