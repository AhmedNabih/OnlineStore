using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceStore : IMax
    {
        private DataBaseQueries query;
        private String StoreID;

        public ProductMaxPriceStore(String StoreID)
        {
            query = new DataBaseQueries();
            this.StoreID = StoreID;
        }

        public string Max()
        {
            return "Max Product Price for Store ID = " + StoreID + ": " + query.StorePricesMaxForStore(StoreID);
        }
    }
}
