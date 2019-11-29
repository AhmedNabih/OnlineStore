using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStaticticesSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceUser : IMax
    {
        private DataBaseQueries query;
        private String UserID;

        public ProductMaxPriceUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public string Max()
        {
            return "Max Product Price for User ID = " + UserID + ": " + query.StorePricesMaxForUser(UserID);
        }
    }
}
