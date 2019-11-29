using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductAveragePriceStore : IAverage
    {
        private DataBaseQueries query;
        private String StoreID;

        public ProductAveragePriceStore(String StoreID)
        {
            query = new DataBaseQueries();
            this.StoreID = StoreID;
        }

        public string Average()
        {
            double res1 = Convert.ToInt32(query.StorePricesSumForStore(StoreID));
            int res2 = Convert.ToInt32(query.StorePricesCntForStore(StoreID));
            return "Store prices Average for Store ID = " + StoreID + ": " + ((double)res1 / res2).ToString();
        }
    }
}
