using OnlineStore.Database_Files;
using System;
using System.Data;

namespace OnlineStore.Queries_Controllers
{
    public class StoreOwnerControllerQueries
    {
        private DataBase dataBase;

        public StoreOwnerControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public DataTable GetStoresData(String UserID)
        {
            try
            {
                String cmd = "select s.StoreID,s.StoreName,s.StoreType,s.StoreLocation,s.StoreInfo from Store s inner join UserStore us on s.StoreID = us.StoreID and us.UserID = " + UserID;
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

        public bool SendStoreRequest(String UserID, String name, String type, String location, String info)
        {
            try
            {
                // add store to table with visable 0
                String cmd = "insert into store(StoreName,StoreType,StoreLocation,StoreInfo,visable) output Inserted.StoreID values('" + name+"','"+type+"','"+location+"','"+info+"',0)";
                DataTable dataTable = dataBase.Query(cmd);
                String StoreID = dataTable.Rows[0][0].ToString();

                // add store request for admin to review
                cmd = "insert into StoreRequests(UserID,StoreID) values(" + UserID + "," + StoreID + ")";
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteStore(String userID, String StoreID)
        {
            try
            {
                // get statid of userstore
                // get statid for every product
                // delete stat list from statistic
                // delete store form store
                String cmd = "select statID from StoreProducts where StoreID = " + StoreID;
                String StatID = "";
                DataTable dataTable = dataBase.Query(cmd);
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        StatID += row[col].ToString() + " ";
                    }
                }

                cmd = "select statID from UserStore where StoreID = " + StoreID;
                dataTable = dataBase.Query(cmd);
                StatID += dataTable.Rows[0][0].ToString();
                String[] StatIDs = StatID.Split(' ');

                cmd = "delete from store where storeID = " + StoreID;
                dataBase.QueryExec(cmd);
                foreach(String stat in StatIDs)
                {
                    cmd = "delete from Statistic where statID = " + stat;
                    dataBase.QueryExec(cmd);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetSystemProducts()
        {
            try
            {
                String cmd = "select * from product";
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

        public DataTable GetSystemBrands()
        {
            try
            {
                String cmd = "select * from brand";
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

        public DataTable GetStoreStat(String StoreID)
        {
            try
            {
                String cmd = "select s.StatID, s.NumOfViews, s.NumOfSold from Statistic s inner join UserStore us on s.StatID = us.StatID and us.StoreID = " + StoreID;
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

        public DataTable GetCollaboratorStores(String UserID)
        {
            try
            {
                String cmd = "select s.StoreID,s.StoreName,s.StoreType,s.StoreLocation,s.StoreInfo from Store s inner join collaborators c on s.StoreID = c.StoreID and c.UserID = " + UserID;
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


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
