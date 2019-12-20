using OnlineStore.App.Stores.Data;
using OnlineStore.Data;
using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.Users.Admins
{
    public class AdminsController
    {
        public IUser admin;
        private AdminControllerQueries queries;

        public AdminsController(Admin admin)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.queries = new AdminControllerQueries(connectionString);
            this.admin = admin;
        }

        ///////////////////////////////////// Product /////////////////////////////////////

        public List<ProductRawData> GetProductsData()
        {
            DataTable dataTable = queries.GetProductsData();
            if (dataTable == null)
                return null;
            List<ProductRawData> productList = new List<ProductRawData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                ProductRawData tempData = new ProductRawData();
                tempData.Handler(tpStr);
                productList.Add(tempData);
            }

            return productList;
        }

        public bool AddProduct(String productName, String productType)
        {
            return queries.AddProduct(productName, productType);
        }

        public bool RemoveProduct(String ProductID)
        {
            return queries.RemoveProduct(ProductID);
        }

        ///////////////////////////////////// Brand /////////////////////////////////////

        public List<BrandRawData> GetBrandsData()
        {
            DataTable dataTable = queries.GetBrandsData();
            if (dataTable == null)
                return null;
            List<BrandRawData> brandList = new List<BrandRawData>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                BrandRawData tempData = new BrandRawData();
                tempData.Handler(tpStr);
                brandList.Add(tempData);
            }

            return brandList;
        }

        public bool AddBrand(String brandName, String brandType)
        {
            return queries.AddBrand(brandName, brandType);
        }

        public bool RemoveBrand(String BrandID)
        {
            return queries.RemoveBrand(BrandID);
        }

        ///////////////////////////////////// Store Request /////////////////////////////////////

        public List<StoreRequest> GetStoreRequest()
        {
            DataTable dataTable = queries.GetStoreRequest();
            if (dataTable == null)
                return null;
            List<StoreRequest> requestList = new List<StoreRequest>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }

                String StoreRequestID = tpStr[0];
                String UserID = tpStr[1];
                String[] storeString = new String[tpStr.Length - 2];
                
                for (int j = 2; j < tpStr.Length; j++)
                    storeString[j - 1] = tpStr[j];
                
                StoreRawData storeData = new StoreRawData();
                storeData.Handler(storeString);

                StoreRequest tempData = new StoreRequest(StoreRequestID, UserID, storeData);
                requestList.Add(tempData);
            }

            return requestList;
        }

        public bool AcceptStore(String storeRequestID, String UserID, String StoreID)
        {
            return queries.AcceptStore(storeRequestID, UserID, StoreID);
        }

        public bool RejectStore(String storeRequestID, String StoreID)
        {
            return queries.RejectStore(storeRequestID, StoreID);
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
