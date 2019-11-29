using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.NormalUser
{
    public class NormalUserController
    {
        private NormalUser normalUser;

        public NormalUserController(NormalUser normalUser)
        {
            this.normalUser = normalUser;
        }
    }
}
