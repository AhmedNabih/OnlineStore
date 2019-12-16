using OnlineStore.Data;
using OnlineStore.Database_Files;
using System;
using System.Data;

namespace OnlineStore.Queries_Controllers
{
    public class UserControllerQueries
    {
        private DataBase database;

        public UserControllerQueries(IConnectionString connectionString)
        {
            this.database = DataBase.GetInstance(connectionString);
        }

        public UserData SearchUserList(String UN, String PW)
        {
            String cmd = "select * from MyUser Where UserName='" + UN + "' and Password='" + PW + "'";
            DataTable datatable = this.database.Query(cmd);

            if (datatable.Rows.Count <= 0)
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

        public bool Register(String UN, String PW, String N, String EM, String Role)
        {
            try
            {
                String cmd = "insert into MyUser( UserName,Password,Name,Email,Role)values('" + UN + "','" + PW + "','" + N + "','" + EM + "','" + Role + "')";
                this.database.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
