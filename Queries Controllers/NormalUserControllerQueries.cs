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
            try
            {
                String cmd = "select * from store where visable = 1";
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
