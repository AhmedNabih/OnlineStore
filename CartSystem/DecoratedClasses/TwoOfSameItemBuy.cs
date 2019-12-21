using OnlineStore.CartSystem.Cart;

namespace OnlineStore.CartSystem.DecoratedClasses
{
    public class TwoOfSameItemBuy : CartDecorated
    {
        public TwoOfSameItemBuy(ICart cartObject) : base(cartObject)
        {
            base.GlobalDiscountRate += 0.1;
        }
    }
}
