using OnlineStore.CartSystem.Cart;

namespace OnlineStore.CartSystem.DecoratedClasses
{
    public class FirstTimeBuy : CartDecorated
    {
        public FirstTimeBuy(ICart cartObject) : base(cartObject)
        {
            base.GlobalDiscountRate += 0.05;
        }
    }
}
