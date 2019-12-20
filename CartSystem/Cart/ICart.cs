
namespace OnlineStore.CartSystem.Cart
{
    public interface ICart
    {
        public abstract double CalcPrice(ICartItem cartItem);
    }
}
