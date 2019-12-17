
using OnlineStore.App.Stores;
using OnlineStore.App.Stores.Data;
using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.Queries_Controllers
{
    public class AdminStatisticsControllerQueries
    {
        private DataBase dataBase;

        public AdminStatisticsControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public DataTable GetAllUsersData()
        {
            try
            {
                String cmd = "select UserID, UserName, Name, Email, Role from MyUser where Role != 'Admin'";
                DataTable dataTable = dataBase.Query(cmd);

                if (dataTable.Rows.Count <= 0)
                    return null;
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetUserStores(String UserID)
        {
            try
            {
                // UserID, StoreID, StoreName, StoreType, StoreLocation, StoreInfo, statID, noOfview, noOfSold
                String cmd = "select t.UserID, t.storeID, t.StoreName, t.StoreType, t.StoreLocation, t.StoreInfo, stat.StatID, stat.NumOfViews, stat.NumOfSold from (select us.UserID, s.storeID, s.StoreName, s.StoreType, s.StoreLocation, s.StoreInfo, us.StatID from Store s inner join UserStore us on us.StoreID = s.StoreID and us.UserID = " + UserID + ") as t inner join Statistic stat on stat.StatID = t.StatID";
                DataTable dataTable = dataBase.Query(cmd);
                
                if (dataTable.Rows.Count <= 0)
                    return null;
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetAllUserStores()
        {
            try
            {
                // UserID, StoreID, StoreName, StoreType, StoreLocation, StoreInfo, statID, noOfview, noOfSold
                String cmd = "select t.UserID, t.storeID, t.StoreName, t.StoreType, t.StoreLocation, t.StoreInfo, stat.StatID, stat.NumOfViews, stat.NumOfSold from (select us.UserID, s.storeID, s.StoreName, s.StoreType, s.StoreLocation, s.StoreInfo, us.StatID from Store s inner join UserStore us on us.StoreID = s.StoreID) as t inner join Statistic stat on stat.StatID = t.StatID";
                DataTable dataTable = dataBase.Query(cmd);

                if (dataTable.Rows.Count <= 0)
                    return null;
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetProductsInStore(String storeID)
        {
            try
            {
                // TODO write Query
                String cmd = "";
                DataTable dataTable = dataBase.Query(cmd);

                if (dataTable.Rows.Count <= 0)
                    return null;
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetAllProductsInStore()
        {
            try
            {
                // TODO write Query
                String cmd = "";
                DataTable dataTable = dataBase.Query(cmd);

                if (dataTable.Rows.Count <= 0)
                    return null;
                return dataTable;
            }
            catch
            {
                return null;
            }
        }
    }
}
