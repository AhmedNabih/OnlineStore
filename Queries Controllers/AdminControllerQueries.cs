using OnlineStore.Database_Files;
using System;
using System.Data;

namespace OnlineStore.Queries_Controllers
{
    public class AdminControllerQueries
    {
        private DataBase dataBase;

        public AdminControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);
        }


        ///////////////////////////////////// Product /////////////////////////////////////

        public DataTable GetProductsData()
        {
            try
            {
                String cmd = "select * from Product";
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

        public bool AddProduct(String Name, String Type)
        {
            try
            {
                String cmd = "insert into Product( ProductName, ProductType) values('" + Name + "','" + Type + "')";
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveProduct(String ProductID)
        {
            try
            {
                String cmd = "delete from Product where ProductID = " + ProductID;
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        ///////////////////////////////////// Brand /////////////////////////////////////

        public DataTable GetBrandsData()
        {
            try
            {
                String cmd = "select * from Brand";
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

        public bool AddBrand(String Name, String Type)
        {
            try
            {
                String cmd = "insert into Brand( BrandName, BrandType) values('" + Name + "','" + Type + "')";
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveBrand(String BrandID)
        {
            try
            {
                String cmd = "delete from Brand where BrandID = " + BrandID;
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        ///////////////////////////////////// Store Request /////////////////////////////////////

        public DataTable GetStoreRequest()
        {
            try
            {
                String cmd = "select sr.StoreRequestID, sr.UserID, s.StoreID, StoreName, StoreType, StoreLocation, StoreInfo from Store s inner join StoreRequests sr on s.StoreID = sr.StoreID";
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

        public bool AcceptStore(String storeRequestID, String UserID, String StoreID)
        {
            try
            {
                // set store visable = true
                String cmd = "Update Store set visable = 1 where StoreID = " + StoreID;
                dataBase.QueryExec(cmd);
                // add stat
                cmd = "insert into Statistic(NumOfViews, NumOfSold) output Inserted.StatID values(0,0)";
                DataTable dataTable = dataBase.Query(cmd);
                String statID = dataTable.Rows[0][0].ToString();
                // add userStore
                cmd = "insert into UserStore values(" + UserID + "," + StoreID + "," + statID + ")";
                dataBase.QueryExec(cmd);
                // remove request from storeRequest
                cmd = "delete from StoreRequests where StoreRequestID = " + storeRequestID;
                dataBase.QueryExec(cmd);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RejectStore(String storeRequestID, String StoreID)
        {
            try
            {
                // remove store data from store
                String cmd = "delete from Store where StoreID = " + StoreID;
                dataBase.QueryExec(cmd);
                // remove request from storeRequest
                cmd = "delete from StoreRequests where StoreRequestID = " + storeRequestID;
                dataBase.QueryExec(cmd);

                return true;
            }
            catch
            {
                return false;
            }
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
