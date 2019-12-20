using System;

namespace OnlineStore.Database_Files
{
    public class DataBaseConnection : IConnectionString
    {
        private DataBaseConnection instance;
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
