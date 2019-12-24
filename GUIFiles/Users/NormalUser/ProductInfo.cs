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
    public partial class ProductInfo : Form
    {
       public static int amount;
        public int actualAmount;
        public ProductInfo(int am)
        {
            InitializeComponent();
            actualAmount = am;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(System.Convert.ToInt32(textBox1.Text)<=actualAmount)
            NUserPage.amount = System.Convert.ToInt32(textBox1.Text);
            else
            {
                MessageBox.Show("insufficient amount");

            }
            this.Close();
        }
    }
}
