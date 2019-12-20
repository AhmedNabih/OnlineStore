using OnlineStore.Database_Files;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Queries_Controllers
{
    class NormalUserControllerQueries
    {
        private DataBase dataBase;

        public NormalUserControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);

        }
        public DataTable GetAllStores()
        {
            String cmd = "select f.UserID,UserName, f.StoreID, f.StoreName,f.StoreType,f.StoreLocation,f.StoreInfo from MyUser mu inner join (select UserID, s.StoreID, StoreName, StoreType, StoreLocation, StoreInfo from Store s inner join UserStore us on s.StoreID = us.StoreID) as f on f.UserID = mu.UserID";
            DataTable datatable = dataBase.Query(cmd);
            return datatable;
        }
        public DataTable GetProductsInStore(String StoreID)
        {
            try
            {
                String cmd = "select ProductName ,BrandName,NumOfViews,NumOfSold,StoreName,price,amount,StoreProducts.ProductID from StoreProducts,Product,Brand ,Statistic,Store where StoreProducts.StoreID = '" + StoreID + "' AND StoreProducts.BrandID=Brand.BrandID AND StoreProducts.ProductID=Product.ProductID AND StoreProducts.StatID=Statistic.StatID ";
                DataTable dataTable = dataBase.Query(cmd);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

    }
}
