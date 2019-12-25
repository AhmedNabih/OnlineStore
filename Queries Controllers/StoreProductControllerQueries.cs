using OnlineStore.App.Stores.Data;
using OnlineStore.Database_Files;
using System;
using System.Data;

namespace OnlineStore.Queries_Controllers
{
    public class StoreProductControllerQueries
    {
        private DataBase dataBase;

        public StoreProductControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public bool AddStoreProduct(String StoreID, StoreProduct product)
        {
            // storeID, brandID, productID, statID, price, amount
            try
            {
                // create stat for product
                String cmd = "insert into Statistic(NumOfViews, NumOfSold) output Inserted.StatID values(0,0)";
                DataTable dataTable = dataBase.Query(cmd);
                String statID = dataTable.Rows[0][0].ToString();
                // add all to Store Product
                cmd = "insert into StoreProducts(StoreID,BrandID,ProductID,StatID,price,amount) values(" + StoreID + "," + product.brand.ID + "," + product.product.ID + "," + statID + "," + product.price + "," + product.amount + ")";
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveStoreProduct(String StoreID, String StoreProductID)
        {
            // get product statid
            // remove product from storeproducts
            // remove stat from Statistic
            try
            {
                String cmd = "select statID from StoreProducts where StoreID = " + StoreID + "and StoreProductID = " + StoreProductID;
                
                DataTable dataTable = dataBase.Query(cmd);
                String StatID = dataTable.Rows[0][0].ToString();

                cmd = "delete from StoreProducts where StoreID = " + StoreID + "and StoreProductID = " + StoreProductID;
                dataBase.QueryExec(cmd);

                cmd = "delete from Statistic where StatID = " + StatID;
                dataBase.QueryExec(cmd);


                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditStoreProduct(String StoreID, String StoreProductID)
        {
            // TODO
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetStoreProducts(String StoreID)
        {
            // storeProductID, StoreID, ProductID, productName, ProductType, BrandID, BrandName, BrandType, price, amount
            try
            {
                String cmd = "select NT.StoreProductID, NT.StoreID, NT.ProductID, NT.ProductName, NT.ProductType, b.BrandID, b.BrandName, b.BrandType, NT.price, NT.amount from (select sp.StoreProductID,sp.StoreID,sp.BrandID,p.ProductID,p.ProductName,p.ProductType,sp.price,sp.amount from StoreProducts sp inner join Product p on sp.ProductID = p.ProductID and sp.StoreID = " + StoreID + ") as NT inner join brand b on b.BrandID = NT.BrandID";
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

        public DataTable GetProductStat(String storeProductID)
        {
            try
            {
                String cmd = "select s.StatID, s.NumOfViews, s.NumOfSold from Statistic s inner join StoreProducts sp on s.StatID = sp.StatID and sp.StoreProductID = " + storeProductID;
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


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
