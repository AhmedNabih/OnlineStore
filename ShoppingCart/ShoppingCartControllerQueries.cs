using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.ShoppingCart
{
    class ShoppingCartControllerQueries
    {
        public DataBase database;
        public ShoppingCartControllerQueries(IConnectionString connectionString)
        {
            this.database = DataBase.GetInstance(connectionString);
        }
    }
}
