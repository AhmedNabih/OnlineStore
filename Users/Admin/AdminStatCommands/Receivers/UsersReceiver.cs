using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers
{
    public class Users : IReceiver
    {
        private DataBaseQueries query;
        public Users() { }

        public String Sum()
        {
            String res = query.UserTableSum();
            return "Users Sum: " + res;
        }

        public String Average()
        {
            return "Users Average: Not Defined Operation";
        }

        public String Max()
        {
            return "Users Max: Not Defined Operation";
        }

        public String Min()
        {
            return "Users Min: Not Defined Operation";
        }

    }
}
