using OnlineStore.App.Stores.Data;
using OnlineStore.Data;
using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using OnlineStore.Users.Admins.AdminsStatisticsSystem;
using OnlineStore.Users.Admins.AdminsStatisticsSystem.Commands;
using OnlineStore.Users.Admins.AdminsStatisticsSystem.Receivers.ReceiverFactory;
using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.Users.Admins.AdminStatisticsSystem
{
    public class AdminStatisticsController
    {
        private AdminStatisticsControllerQueries queries;
        public AdminStatisticsController()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.queries = new AdminStatisticsControllerQueries(connectionString);
        }

        public String Statistic(String cmdType, String arg1, String arg2)
        {
            ICommand cmd;
            if (cmdType == "Sum")
            {
                ISum sum = SumFactory.GetCommand(arg1, arg2);
                cmd = new SumCommand(sum);
            }
            else if (cmdType == "Average")
            {
                IAverage average = AverageFactory.GetCommand(arg1, arg2);
                cmd = new AverageCommand(average);
            }
            else if (cmdType == "Max")
            {
                IMax max = MaxFactory.GetCommand(arg1, arg2);
                cmd = new MaxCommand(max);
            }
            else
            {
                IMin min = MinFactory.GetCommand(arg1, arg2);
                cmd = new MinCommand(min);
            }

            String res = CommandInvoker.DoCommand(cmd);
            return res;
        }

        public List<UserStoreData> GetAllUserStores()
        {
            // UserID, StoreID, StoreName, StoreType, StoreLocation, StoreInfo, statID, noOfview, noOfSold
            DataTable dataTable = queries.GetAllUserStores();
            if (dataTable == null)
                return null;
            List<UserStoreData> userStoresList = new List<UserStoreData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                UserStoreData tempData = new UserStoreData();

                tempData.Handler(tpStr);
                userStoresList.Add(tempData);
            }

            return userStoresList;
        }

        public List<UserStoreData> GetUserStores(String UserID)
        {
            // UserID, StoreID, StoreName, StoreType, StoreLocation, StoreInfo, statID, noOfview, noOfSold
            DataTable dataTable = queries.GetUserStores(UserID);
            if (dataTable == null)
                return null;
            List<UserStoreData> userStoresList = new List<UserStoreData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                UserStoreData tempData = new UserStoreData();

                tempData.Handler(tpStr);
                userStoresList.Add(tempData);
            }

            return userStoresList;
        }

        public List<StoreProduct> GetAllProductsInStore()
        {
            DataTable dataTable = queries.GetAllProductsInStore();
            if (dataTable == null)
                return null;
            List<StoreProduct> storeProductList = new List<StoreProduct>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                StoreProduct tempData = new StoreProduct();
                tempData.Handler(tpStr);
                storeProductList.Add(tempData);
            }

            return storeProductList;
        }

        public List<StoreProduct> GetProductsInStore(String storeID) 
        {
            DataTable dataTable = queries.GetProductsInStore(storeID);
            if (dataTable == null)
                return null;
            List<StoreProduct> storeProductList = new List<StoreProduct>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                StoreProduct tempData = new StoreProduct();
                tempData.Handler(tpStr);
                storeProductList.Add(tempData);
            }

            return storeProductList;
        }

        public List<UserData> GetAllUsersData()
        {
            DataTable dataTable = queries.GetAllUsersData();
            if (dataTable == null)
                return null;
            List<UserData> userList = new List<UserData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                UserData tempData = new UserData();
                tempData.Handler(tpStr);
                userList.Add(tempData);
            }

            return userList;
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
