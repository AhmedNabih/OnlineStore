using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers
{
    public class StoreReceiver : IReceiver
    {
        private String UserID;
        private String StoreID;

        public String User { get { return UserID; } set { UserID = value; } }
        public String Store { get { return StoreID; } set { StoreID = value; } }

        public StoreReceiver()
        {
            this.UserID = null;
            this.StoreID = null;
        }

        public String Sum()
        {
            if(StoreID == null)
            {
                return "smthg";
            }
            else
            {
                return "smthg";
            }
        }

        public String Average()
        {
            throw new NotImplementedException();
        }

        public String Max()
        {
            throw new NotImplementedException();
        }

        public String Min()
        {
            throw new NotImplementedException();
        }

    }
}
