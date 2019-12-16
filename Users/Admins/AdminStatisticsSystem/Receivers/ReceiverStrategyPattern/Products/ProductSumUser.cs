using OnlineStore.Database_Files;
using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductSumUser : ISum
    {
        private DataBaseQueries query;
        private String UserID;

        public ProductSumUser(String UserID)
        {
            query = new DataBaseQueries();
            this.UserID = UserID;
        }

        public string Sum()
        {
            return "Products Sum for User ID = " + UserID + ": " + query.ProductTableSumForUser(UserID);
        }
    }
}
