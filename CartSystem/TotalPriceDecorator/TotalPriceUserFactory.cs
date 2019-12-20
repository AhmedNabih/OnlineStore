using OnlineStore.CartSystem.TotalPriceDecorator.DecoratedClasses;
using System;

namespace OnlineStore.CartSystem.TotalPriceDecorator
{
    public class TotalPriceUserFactory
    {
        public static ITotalPrice CreateUserTotalPrice(String key, ITotalPrice totalPriceObject)
        {
            if (key == "StoreOwner")
                return new StoreOwnerTotalPrice(totalPriceObject);
            else if (key == "NormalUser")
                return new NormalUserTotalPrice(totalPriceObject);
            else
                throw new NotSupportedException("btal habd");
        }
    }
}
