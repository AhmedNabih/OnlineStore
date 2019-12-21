
namespace OnlineStore.CartSystem.Cart
{
    public interface ICartItem
    {
        public abstract double GetPrice();
        public abstract int GetAmount();
        public abstract bool FirstTime();
    }
}
