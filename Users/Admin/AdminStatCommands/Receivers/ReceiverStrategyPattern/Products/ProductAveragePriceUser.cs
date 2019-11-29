using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductAveragePriceUser : IAverage
    {
        private DataBaseQueries query;
        private String UserID;

        public ProductAveragePriceUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public string Average()
        {
            double res1 = Convert.ToInt32(query.StorePricesSumForUser(UserID));
            int res2 = Convert.ToInt32(query.StorePricesCntForUser(UserID));
            return "Store prices Average for User ID = " + UserID + ": " + ((double)res1 / res2).ToString();
        }
    }
}
