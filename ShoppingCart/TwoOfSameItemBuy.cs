using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.ShoppingCart
{
    public class TwoOfSameItemBuy : BuyableDecorated
    {
        public TwoOfSameItemBuy(IBuyable obj) : base(obj)
        {
            base.discountRate += 0.1;
        }

    }
}
