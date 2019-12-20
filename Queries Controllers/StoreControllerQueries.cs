using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Queries_Controllers
{
    public class StoreControllerQueries
    {
        private DataBase dataBase;

        public StoreControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);
        }

        
    }
}
