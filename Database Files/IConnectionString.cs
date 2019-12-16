using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Database_Files
{
    public interface IConnectionString
    {
        public abstract String GetConnectionString();
        public abstract void SetConnectionString(String str);
    }
}
