using OnlineStore.Users.Admins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles.Users.Admins
{
    public partial class AddBrandPage : Form
    {
        AdminsController controller;

        public AddBrandPage(AdminsController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void AddBrand_Click(object sender, EventArgs e)
        {
            bool DONE = this.controller.AddBrand(TBrandName.Text, TBrandType.Text);
            if (DONE)
            {
                MessageBox.Show("Product Added");
            }
            else
            {
                MessageBox.Show("DataBase Not Connected");
            }
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearText_Click(object sender, EventArgs e)
        {
            TBrandName.Clear();
            TBrandType.Clear();
        }
    }
}
