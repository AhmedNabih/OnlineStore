﻿using System;
using System.Windows.Forms;
using OnlineStore.Users.Admins;

namespace OnlineStore.GUIFiles.Users.Admins
{
    public partial class AddProductsPage : Form
    {
        AdminsController controller;

        public AddProductsPage(AdminsController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        
        private void AddProduct_Click(object sender, EventArgs e)
        {
            bool DONE = this.controller.AddProduct(TProductName.Text, TProductType.Text);
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
            TProductName.Clear();
            TProductType.Clear();
        }
        
    }
}
