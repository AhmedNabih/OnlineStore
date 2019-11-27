using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles
{
    public partial class AddShippingInfo : Form
    {
        public static int amount;
        public static int StoreID;
        public static int ProductID;
        public Handler hand;
        public AddShippingInfo(String labelname1, String labelname2, String labelname3)
        {
            InitializeComponent();
            label1.Text = labelname1;
            label2.Text = labelname2;
            label3.Text = labelname3;
            hand = Handler.GetInstance();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            int requiredAmount = System.Convert.ToInt32(data1.Text);
            if (requiredAmount > amount)
            {
                MessageBox.Show("insufficient amount");
                MessageBox.Show(amount.ToString());
                MessageBox.Show(StoreID.ToString());
            }
            else
            {
                int NewAmount = amount - requiredAmount;
                String s = "update StoreProductStat set amount='" + NewAmount + "' where StoreID='" + StoreID + "' and Product='"+ ProductID+"' ";
                hand.DB.QueryExec(s);
                MessageBox.Show("Transaction Complete");
            }
        }
        public void setAmount(int val)
        {
            amount = val;
        }
        public void SetStoreId(int val)
        {
            StoreID = val;
        }
        public void SetProductID(int val)
        {

            ProductID = val;
        }
    }
}
