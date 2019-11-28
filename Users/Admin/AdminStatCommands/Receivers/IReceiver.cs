using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers
{
    public interface IReceiver  // RECEIVER
    {
        public abstract String Sum();

        public abstract String Average();

        public abstract String Max();

        public abstract String Min();

    }
}
