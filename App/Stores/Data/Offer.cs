using System;
using System.Windows.Forms;

namespace OnlineStore.App.Stores.Data
{
    public class Offer
    {
        public String ID;
        public StoreProduct product;
        public double discountRate;

        public Offer()
        {
            this.ID = null;
            this.product = new StoreProduct();
            this.discountRate = 0.0;
        }

        public Offer(String ID, StoreProduct product, double discountRate)
        {
            this.ID = ID;
            this.product = product;
            this.discountRate = discountRate;
        }

        public void Handler(String[] data)
        {
            this.ID = data[0];
            this.discountRate = System.Convert.ToDouble(data[1]);
        }

        public override String ToString()
        {
            String str = product.ToString() + " -> Offer ID: " + ID + " Offer discountRate: " + discountRate;
            return str;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(new String[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                product.RefactorString(tempData[0]);
                String[] Refactor = tempData[1].Split(' ');
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
