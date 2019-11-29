using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumStore : ISum
    {
        private DataBaseQueries query;
        private String StoreID;

        public ProductSumStore(String StoreID)
        {
            query = new DataBaseQueries();
            this.StoreID = StoreID;
        }

        public string Sum()
        {
            return "Products Sum for Store ID = " + StoreID + ": " + query.ProductTableSumForStore(StoreID);
        }
    }
}
