
namespace OnlineStore.CartSystem.TotalPriceDecorator.DecoratedClasses
{
    public class StoreOwnerTotalPrice : TotalPriceDecorated
    {
        public StoreOwnerTotalPrice(ITotalPrice totalPriceObject) : base(totalPriceObject)
        {
            base.GlobalDiscountRate += 0.15;
        }
    }
}
