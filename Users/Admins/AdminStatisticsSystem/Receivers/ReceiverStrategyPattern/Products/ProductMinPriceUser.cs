using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMinPriceUser : IMin
    {
        private DataBaseQueries query;
        private String UserID;

        public ProductMinPriceUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public String Min()
        {
            return "Min Product Price for User ID = " + UserID + ": " + query.StorePricesMinForUser(UserID);
        }
    }
}
