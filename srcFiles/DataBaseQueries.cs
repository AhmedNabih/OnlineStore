using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.srcFiles
{
    public class DataBaseQueries
    {
        private MyDataBase dataBase;
        
        DataBaseQueries()
        {
            this.dataBase = MyDataBase.GetInstance();
        }

        public String UserTableSum()
        {
            String cmd = "select count(UserID) as cnt from MyUser where Role != 'Admin'";
            DataTable tpData = dataBase.Query(cmd);
            return tpData.Rows[0][0].ToString();
        }
    }
}
