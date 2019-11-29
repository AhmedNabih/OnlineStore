using System;
using System.Windows.Forms;
using OnlineStore.Users.Admins;

namespace OnlineStore.GUIFiles.Users.Admins
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
            admin.AddProduct(TbrandName.Text,TbrandType.Text, Tname.Text,Tterms.Text);
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
