using OnlineStore.CartSystem.Cart;

namespace OnlineStore.CartSystem.DecoratedClasses
{
    public class SimpleCart : ICart
    {
        public double CalcPrice(ICartItem cartItem)
        {
            return cartItem.GetAmount() * cartItem.GetPrice();
        }
    }
}
