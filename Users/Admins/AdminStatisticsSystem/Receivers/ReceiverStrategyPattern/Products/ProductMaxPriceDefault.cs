using OnlineStore.Database_Files;

namespace OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductMaxPriceDefault : IMax
    {
        private DataBaseQueries query;

        public ProductMaxPriceDefault()
        {
            query = new DataBaseQueries();
        }

        public string Max()
        {
            return "Max Product Price: " + query.StorePricesMax();
        }
    }
}
