using System;
using System.Windows.Forms;
using OnlineStore.Users.StoreOwners;

namespace OnlineStore.GUIFiles
{
    public partial class addStorePage : Form
    {
        private StoreOwnerController controllerSO;

        public addStorePage(StoreOwnerController controllerSO)
        {
            this.controllerSO = controllerSO;
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String UserID = controllerSO.storeOwner.Data.ID;
            bool DONE = this.controllerSO.SendStoreRequest(UserID,StoreName.Text, StoreType.Text, StoreLocation.SelectedItem.ToString(), StoreInfo.Text);
            if (DONE)
            {
                MessageBox.Show("Request sent");
            }
            else
            {
                MessageBox.Show("Request sent failed");
            }
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
