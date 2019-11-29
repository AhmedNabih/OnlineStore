using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;
using OnlineStore.srcFiles;

namespace OnlineStore.Users.UserFactoryPattern
{
    public abstract class IUser
    {
        public UserData Data;
        public Handler hand;
        public abstract void ConnectPage(UserData data);
    }
}
