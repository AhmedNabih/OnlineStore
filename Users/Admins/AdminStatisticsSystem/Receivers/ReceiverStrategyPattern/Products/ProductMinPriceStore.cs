using OnlineStore.Database_Files;
using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceStore : IMin
    {
        private DataBaseQueries query;
        private String StoreID;

        public ProductMinPriceStore(String StoreID)
        {
            query = new DataBaseQueries();
            this.StoreID = StoreID;
        }

        public String Min()
        {
            return "Min Product Price for Store ID = " + StoreID + ": " + query.StorePricesMinForStore(StoreID);
        }
    }
}
