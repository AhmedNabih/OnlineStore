using OnlineStore.Data;
using System;
using System.Windows.Forms;

namespace OnlineStore.App.Stores.Data
{
    public class StoreProduct
    {
        public ProductRawData product;
        public BrandRawData brand;
        public Statistics statistics;
        public double price;
        public int amount;

        public StoreProduct()
        {
            this.product = new ProductRawData();
            this.brand = new BrandRawData();
            this.statistics = new Statistics();
            this.price = 0.0;
            this.amount = 0;

        }

        public StoreProduct(ProductRawData product, BrandRawData brand, Statistics statistics, double price, int amount)
        {
            this.product = product;
            this.brand = brand;
            this.statistics = statistics;
            this.price = price;
            this.amount = amount;
        }

        public void Handler(String[] data)
        {
            this.price = System.Convert.ToDouble(data[0]);
            this.amount = System.Convert.ToInt32(data[1]);
        }

        public override String ToString()
        {
            return product.ToString() + " -> " + brand.ToString() + " -> " + statistics.ToString() + " -> Product Price: " + price + " Product Amount: " + amount;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(new String[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                product.RefactorString(tempData[0]);
                brand.RefactorString(tempData[1]);
                statistics.RefactorString(tempData[2]);
                String[] Refactor = tempData[3].Split(' ');
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
