using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Data;
using OnlineStore.Users.StoreOwners;

namespace OnlineStore.GUIFiles
{
    public partial class addStorePage : Form
    {
        private StoreOwner SO;
        public addStorePage(StoreOwner SO)
        {
            this.SO = SO;
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SO.AddStore(StoreName.Text, StoreType.Text,StoreLocation.SelectedItem.ToString(), StoreInfo.Text);
            MessageBox.Show("Request sent");
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
