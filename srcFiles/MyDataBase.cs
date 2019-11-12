using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.srcFiles
{
    public class MyDataBase
    {
        private String myCWD;
        private String ConnectionString = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adpt;
        private SqlCommand Command;
        private bool SafeGarde;


        public MyDataBase(String CD)
        {
            this.myCWD = CD;
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Can not Connect to Database");
                SafeGarde = false;
            }
            else
                SafeGarde = true;

        }

        ~MyDataBase()
        {
            connection.Close();
        }

        public void QueryExec(String query)
        {
            try
            {
                if (SafeGarde)
                {
                    adpt.SelectCommand = new SqlCommand(query, connection);
                    adpt.SelectCommand.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }

        public DataTable Query(String query)
        {
            if (SafeGarde)
            {
                DataTable datatable = new DataTable();
                adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand(query, connection);
                adpt.Fill(datatable);
                return datatable;
            }
            else
            {
                MessageBox.Show("Can not Connect to Database");
                return null;
            }
        }


        public DataTable GetProductsData()
        {
            String cmd = "select BrandName,BrandType,ProductName from Product";
            DataTable datatable = Query(cmd);
            return datatable;


        }

        public DataTable GetStoreData()
        {
            String cmd = "select StoreName,StoreType,StoreLocation,StoreInfo from Store";
            DataTable datatable = Query(cmd);
            return datatable;
        }

        public DataTable GetStoreReq()
        {
            String cmd = "select * from StoreRequests";
            DataTable datatable = Query(cmd);
            return datatable;
        }

        public UserData SearchUserList(String UN, string PW)
        {
            String cmd = "select * from MyUser Where UserName=@UserName and Password=@UserPass";
            Command = new SqlCommand(cmd, connection);
            Command.Parameters.AddWithValue("@UserName", UN);
            Command.Parameters.AddWithValue("@UserPass", PW);
            adpt = new SqlDataAdapter(Command);

            DataTable datatable = new DataTable();
            adpt.Fill(datatable);
            String[] tpData = new String[datatable.Columns.Count];
            int i = 0;
            if (datatable.Rows.Count > 0)
            {
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
            else
                return null;

        }
    }

}
