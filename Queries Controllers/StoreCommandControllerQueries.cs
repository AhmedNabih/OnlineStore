using OnlineStore.App.StoreCommand;
using OnlineStore.Database_Files;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineStore.Queries_Controllers
{
    public class StoreCommandControllerQueries
    {
        private DataBase dataBase;

        public StoreCommandControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public DataTable GetCommands(String StoreID)
        {
            try
            {
                String cmd = "select * from StoreHistory where storeID = " + StoreID;
                DataTable datatable = dataBase.Query(cmd);

                if (datatable.Rows.Count <= 0)
                    return null;
                return datatable;
            }
            catch
            {
                return null;
            }
        }

        public void SaveStoreData(CommandData data)
        {
            try
            {
                String cmd = "insert into StoreHistory(UserIDCollab,UserNameColab,CommandType,StoreProductID,ProductName,amount,price,StoreID) values(" + data.UserIDCollab + ",'" + data.UsernameCollab + "','" + data.CmdType + "'," + data.ProductID + ",'" + data.ProductName + "'," + data.PAmount + "," + data.Price + "," + data.StoreID + ")";
                dataBase.QueryExec(cmd);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        public void UnSaveStoreData(String HistoryID)
        {
            try
            {
                String cmd = "delete from StoreHistory where HistoryID = " + HistoryID;
                dataBase.QueryExec(cmd);
            }
            catch
            {
            }
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
