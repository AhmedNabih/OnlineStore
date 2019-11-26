using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles
{
    public partial class InputData : Form
    {
        double price;
        public InputData(String data)
        {
            InitializeComponent();
            DataInput.Text = data;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
             this.price = System.Convert.ToDouble(Pricee.Text);
            this.Hide();
        }
       public double get()
        {
            return this.price;
            this.Close();
        }
    }
}
