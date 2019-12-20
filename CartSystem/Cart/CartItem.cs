using System;

namespace OnlineStore.CartSystem.Cart
{
    public class CartItem : ICartItem
    {
        private String productID;
        private String productName;
        private double price;
        private int amonut;
        private bool firstTime;

        public CartItem()
        {
            this.productID = null;
            this.productName = null;
            this.price = 0.0;
            this.amonut = 0;
            this.firstTime = false;
        }

        public CartItem(String productId, String productname, double Price, int Amonut, bool firstTime)
        {
            this.productID = productId;
            this.productName = productname;
            this.price = Price;
            this.amonut = Amonut;
            this.firstTime = firstTime;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetAmount()
        {
            return this.amonut;
        }

        public bool FirstTime()
        {
            return this.firstTime;
        }
    }
}
