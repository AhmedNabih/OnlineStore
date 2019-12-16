using OnlineStore.Data;
using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Queries_Controllers
{
    public class UserControllerQueries
    {
        private DataBase database;

        public UserControllerQueries(IConnectionString connectionString)
        {
            this.database = DataBase.GetInstance(connectionString);
        }

        public DataTable GetUsersData()
        {
            String cmd = "select UserID, UserName, Name, Email, Role from MyUser";
            DataTable dataTable = this.database.Query(cmd);
            return dataTable;
        }

        public UserData SearchUserList(String UN, String PW)
        {
            String cmd = "select * from MyUser Where UserName='" + UN + "' and Password='" + PW + "'";
            DataTable datatable = this.database.Query(cmd);

            if (datatable == null)
                return null;

            String[] tpData = new String[datatable.Columns.Count];
            int i = 0;
            foreach (DataRow row in datatable.Rows)
            {
                foreach (DataColumn col in datatable.Columns)
                {
                    tpData[i] = row[col].ToString();
                    i++;
                }
            }
            UserData tpUD = new UserData(tpData[0], tpData[1], tpData[2], tpData[3], tpData[4], tpData[5]);
            return tpUD;
        }
    }
}
