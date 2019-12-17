using OnlineStore.App.Stores.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.ShoppingCart
{
    public class CartObject
    {
        string productID;
        string productName;
        double price;
        int amonut;
        bool firstTime;

        public double GetPrice()
        {
            return this.price;
        }
        public CartObject()
        {
            this.productID = null;
            this.productName = null;
            this.price = 0.0;
            this.amonut = 0;
            this.firstTime = true;
        }
        public CartObject(string productId, string productname, double Price, int Amonut)
        {
            this.productID = productId;
            this.productName = productname;
            this.price = Price;
            this.amonut = Amonut;
            this.firstTime = true;
        }
        public bool FirstTime()
        {
            return firstTime;
        }
        public int GetAmount()
        {
            return this.amonut;
        }


    }
}
