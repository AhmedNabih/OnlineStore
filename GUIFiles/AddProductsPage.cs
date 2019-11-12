using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUIFiles
{
    public partial class AddProductsPage : Form
    {
        Admin admin;
        public AddProductsPage(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            admin.AddProduct(TbrandName.Text,TbrandType.Text, Tname.Text);
            MessageBox.Show("Product Added");
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearText_Click(object sender, EventArgs e)
        {
            TbrandName.Clear();
            TbrandType.Clear();
            Tname.Clear();
        }
    }
}
