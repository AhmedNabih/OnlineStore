using System;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles
{
    public partial class InputData : Form
    {
        public InputData(String labelname1,String labelname2,String labelname3)
        {
            InitializeComponent();
            label1.Text = labelname1;
            label2.Text = labelname2;
            label3.Text = labelname3;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            double price = System.Convert.ToDouble(data1.Text);
            int amount = Convert.ToInt32(data2.Text);
            StoreLayoutPage.SetPrice(price);
            StoreLayoutPage.SetAmount(amount);
            this.Close();
        }

        
    }
}
