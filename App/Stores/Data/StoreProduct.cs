using OnlineStore.Data;
using System;
using System.Windows.Forms;

namespace OnlineStore.App.Stores.Data
{
    public class StoreProduct
    {
        public String storeProductID;
        public String storeID;
        public ProductRawData product;
        public BrandRawData brand;
        public Statistics statistics;
        public double price;
        public int amount;

        public StoreProduct()
        {
            this.storeProductID = null;
            this.storeID = null;
            this.product = new ProductRawData();
            this.brand = new BrandRawData();
            this.statistics = new Statistics();
            this.price = 0.0;
            this.amount = 0;
        }

        public StoreProduct(String storeProductID, String storeID, ProductRawData product, BrandRawData brand, Statistics statistics, double price, int amount)
        {
            this.storeProductID = storeProductID;
            this.storeID = storeID;
            this.product = product;
            this.brand = brand;
            this.statistics = statistics;
            this.price = price;
            this.amount = amount;
        }

        public void Handler(String[] data)
        {
            this.storeProductID = data[0];
            this.storeID = data[1];
            
            int i = 2;
            String[] dumy = new String[3];
            for (int j = 0; i < 5; i++,j++)
                dumy[j] = data[i];
            this.product.Handler(dumy);

            dumy = new String[3];
            for (int j = 0; i < 9; i++,j++)
                dumy[j] = data[i];
            this.brand.Handler(dumy);

            dumy = new String[4];
            for (int j = 0; i < 13; i++, j++)
                dumy[j] = data[i];
            this.statistics.Handler(dumy);

            this.price = System.Convert.ToDouble(data[i]);
            this.amount = System.Convert.ToInt32(data[i+1]);
        }

        public override String ToString()
        {
            return "Store Product ID: " + storeProductID + " Store ID: " + storeID + " Product Price: " + price + " Product Amount: " + amount + " -> " + product.ToString() + " -> " + brand.ToString() + " -> " + statistics.ToString();
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(new String[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                String[] re = tempData[0].Split(' ');
                this.storeProductID = re[3];
                this.storeID = re[6];
                this.price = System.Convert.ToDouble(re[9]);
                this.amount = System.Convert.ToInt32(re[12]);
                product.RefactorString(tempData[1]);
                brand.RefactorString(tempData[2]);
                statistics.RefactorString(tempData[3]);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
