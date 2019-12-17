using OnlineStore.App.Stores.Data;
using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                cmd = "insert into StoreProducts(StoreID,BrandID,ProductID,StatID,price,amount) values(" + StoreID + "," + product.brand.ID + "," + product.product.ID + "," + product.statistics.ID + "," + product.price + "," + product.amount + ")";
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
