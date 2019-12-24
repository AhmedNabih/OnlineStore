using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OnlineStore.App.Stores.Data;
using OnlineStore.GUIFiles;
using OnlineStore.Users.StoreOwners;

namespace OnlineStore
{
    public partial class StoreOwnerPage : Form
    {
        private StoreOwnerController controllerSO;

        public StoreOwnerPage(StoreOwnerController controllerSO)
        {
            this.controllerSO = controllerSO;
            InitializeComponent();
            TuserName.Text = controllerSO.storeOwner.Data.userName;
            Tname.Text = controllerSO.storeOwner.Data.name;
            Temail.Text = controllerSO.storeOwner.Data.email;
            Trole.Text = controllerSO.storeOwner.Data.role;
        }

        private void AddStore_Click(object sender, EventArgs e)
        {
            addStorePage asp = new addStorePage(controllerSO);
            asp.Show();
        }

        private void DeleteStores_Click(object sender, EventArgs e)
        {
            if (MyStores.SelectedItem == null)
                return;

            String SelectedItem = MyStores.SelectedItem.ToString();
            StoreRawData tempData = new StoreRawData();
            tempData.RefactorString(SelectedItem);

            String UserID = controllerSO.storeOwner.Data.ID;
            String StoreID = tempData.ID;

            bool DONE = this.controllerSO.DeleteStore(UserID, StoreID);
            if (DONE)
                MessageBox.Show("Store Deleted");
            else
                MessageBox.Show("Store Deletion failed");

            this.RefreshStoreList_Click(sender, e);
        }

        private void RefreshStoreList_Click(object sender, EventArgs e)
        {
            MyStores.Items.Clear();

            List<StoreRawData> StoresList = controllerSO.GetStoresData(controllerSO.storeOwner.Data.ID);

            if (StoresList == null)
                return;

            foreach (StoreRawData storeData in StoresList)
            {
                MyStores.Items.Add(storeData.ToString());
            }
        }

        private void ShowStore_Click(object sender, EventArgs e)
        {
            if (MyStores.SelectedItem == null)
                return;

            String SelectedItem = MyStores.SelectedItem.ToString();
            StoreRawData tempData = new StoreRawData();
            tempData.RefactorString(SelectedItem);
            String UserID = controllerSO.storeOwner.Data.ID;
            String StoreID = tempData.ID;



        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
