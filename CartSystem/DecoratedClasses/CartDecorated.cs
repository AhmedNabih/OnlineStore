using OnlineStore.CartSystem.Cart;

namespace OnlineStore.CartSystem.DecoratedClasses
{
    public class CartDecorated : ICart
    {
        private ICart cartObject;
        protected double GlobalDiscountRate = 0.0;

        public CartDecorated(ICart cartObject)
        {
            this.cartObject = cartObject;
        }

        public double CalcPrice(ICartItem cartItem)
        {
            double withOutDiscount = this.cartObject.CalcPrice(cartItem);

            double withDiscount = withOutDiscount - GlobalDiscountRate * withOutDiscount;
            
            return withDiscount;
        }
    }
}
