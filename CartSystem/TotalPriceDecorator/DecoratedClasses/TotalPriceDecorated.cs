
namespace OnlineStore.CartSystem.TotalPriceDecorator.DecoratedClasses
{
    public class TotalPriceDecorated : ITotalPrice
    {
        private ITotalPrice totalPriceObject;
        protected double GlobalDiscountRate = 0.0;

        public TotalPriceDecorated(ITotalPrice totalPriceObject)
        {
            this.totalPriceObject = totalPriceObject;
        }

        public double TotalPrice()
        {
            double withOutDiscount = this.totalPriceObject.TotalPrice();

            double withDiscount = withOutDiscount - GlobalDiscountRate * withOutDiscount;

            return withDiscount;
        }
    }
}
