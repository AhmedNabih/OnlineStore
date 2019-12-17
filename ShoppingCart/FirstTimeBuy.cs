using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.ShoppingCart
{
    public class FirstTimeBuy : BuyableDecorated
    {

        public FirstTimeBuy(IBuyable obj) : base(obj)
        {
            base.discountRate += 0.05;
        }
        

    }
}
