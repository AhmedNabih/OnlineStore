
namespace OnlineStore.CartSystem.TotalPriceDecorator
{
    public class SimpleTotalPrice : ITotalPrice
    {
        private double totalPrice;

        public SimpleTotalPrice(double totalPrice)
        {
            this.totalPrice = totalPrice;
        }

        public double TotalPrice()
        {
            return this.totalPrice;
        }
    }
}
