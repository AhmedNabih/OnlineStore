using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.App.StoreCommand
{
    public class StoreCommandController
    {
        private StoreCommandControllerQueries queries;

        public StoreCommandController()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.queries = new StoreCommandControllerQueries(connectionString);
        }

        public List<CommandData> GetCommands(String StoreID)
        {
            DataTable dataTable = queries.GetCommands(StoreID);
            if (dataTable == null)
                return null;
            List<CommandData> commandList = new List<CommandData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                CommandData tempData = new CommandData();
                List<Object> list = new List<Object>();
                list.Add(tpStr[0]);
                list.Add(tpStr[1]);
                list.Add(tpStr[2]);
                list.Add(tpStr[3]);
                list.Add(tpStr[4]);
                list.Add(tpStr[5]);
                list.Add(tpStr[6]);
                list.Add(tpStr[7]);
                list.Add(tpStr[8]);
                tempData.Handler(list);
                commandList.Add(tempData);
            }

            return commandList;
        }

        public void SaveData(CommandData data)
        {
            queries.SaveStoreData(data);
        }

        public void UnSaveData(CommandData data)
        {
            queries.UnSaveStoreData(data.HistoryID);
        }

        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
