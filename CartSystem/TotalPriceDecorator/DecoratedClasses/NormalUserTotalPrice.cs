
namespace OnlineStore.CartSystem.TotalPriceDecorator.DecoratedClasses
{
    public class NormalUserTotalPrice : TotalPriceDecorated
    {
        public NormalUserTotalPrice(ITotalPrice totalPriceObject) : base(totalPriceObject)
        {
            base.GlobalDiscountRate += 0.0;
        }
    }
}
