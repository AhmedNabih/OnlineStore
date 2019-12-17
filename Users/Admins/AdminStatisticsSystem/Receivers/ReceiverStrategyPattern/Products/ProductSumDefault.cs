using OnlineStore.Database_Files;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
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
