using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.ShoppingCart
{
    public class BuyableDecorated : IBuyable
    {
        IBuyable buyableObject;
        protected double discountRate = 0.0;
       
        public BuyableDecorated(IBuyable obj)
        {
            this.buyableObject = obj;
        }

        public double Buy(CartObject obj)
        {
            Double res = 0.0;
            if (discountRate == 0.0)
                res = this.buyableObject.Buy(obj) * obj.GetAmount();
            else
            {
                Double dumy = this.buyableObject.Buy(obj);
                MessageBox.Show(dumy.ToString());

                int dumy1 = obj.GetAmount();
                MessageBox.Show(dumy1.ToString());

                res = dumy * dumy1;
                res = res - discountRate * res;
            }
            return res;
        }
    }
}
