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
        public double price;
        public int amount;

        public StoreProduct()
        {
            this.storeProductID = null;
            this.storeID = null;
            this.product = new ProductRawData();
            this.brand = new BrandRawData();
            this.price = 0.0;
            this.amount = 0;
        }

        public StoreProduct(String storeProductID, String storeID, ProductRawData product, BrandRawData brand, double price, int amount)
        {
            this.storeProductID = storeProductID;
            this.storeID = storeID;
            this.product = product;
            this.brand = brand;
            this.price = price;
            this.amount = amount;
        }

        public void Handler(String[] data)
        {
            this.storeProductID = data[0];
            this.storeID = data[1];
            
            String[] dumy = new String[3];
            dumy[0] = data[2];
            dumy[1] = data[3];
            dumy[2] = data[4];
            this.product.Handler(dumy);

            dumy = new String[3];
            dumy[0] = data[5];
            dumy[1] = data[6];
            dumy[2] = data[7];
            this.brand.Handler(dumy);

            this.price = System.Convert.ToDouble(data[8]);
            this.amount = System.Convert.ToInt32(data[9]);
        }

        public override String ToString()
        {
            return "Store Product ID: " + storeProductID + " Store ID: " + storeID + " Product Price: " + price + " Product Amount: " + amount + " -> " + product.ToString() + " -> " + brand.ToString();
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
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
