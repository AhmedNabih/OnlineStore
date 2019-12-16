using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Database_Files
{
    public class DataBaseConnection : IConnectionString
    {
        private String ConnctionString;

        public DataBaseConnection()
        {
            this.ConnctionString = null;
        }

        public void SetConnectionString(String str)
        {
            this.ConnctionString = str;
        }

        public String GetConnectionString()
        {
            return this.ConnctionString;
        }
    }
}
