using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OnlineStore.App.Stores;
using OnlineStore.App.Stores.Data;
using OnlineStore.Data;
using OnlineStore.GUIFiles;
using OnlineStore.Users;
using OnlineStore.Users.NormalUsers;
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
            String StoreID = tempData.ID;

            String UserID = controllerSO.storeOwner.Data.ID;
            StoreRawData storeRawData = new StoreRawData();
            storeRawData.RefactorString(MyStores.SelectedItem.ToString());
            Statistics statistics = controllerSO.GetStoreStat(storeRawData.ID);

            UserStoreData userStoreData = new UserStoreData(UserID, storeRawData, statistics);

            Store store = new Store(userStoreData);

            StoreController storeController = new StoreController(store);
            StoreProductController storeProductController = new StoreProductController();

            StoreLayoutPage storeLayoutPage = new StoreLayoutPage(controllerSO, storeController, storeProductController, false);
            storeLayoutPage.Show();
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

        private void BNormalUser_Click(object sender, EventArgs e)
        {
            IBuyable buyable = controllerSO.storeOwner;
            NormalUserController normalUserController = new NormalUserController(controllerSO.storeOwner);
            NUserPage nUserPage = new NUserPage(normalUserController, controllerSO.storeOwner.controllerCart, buyable);
            nUserPage.Show();
        }

        private void BRefreshCollaboratorList_Click(object sender, EventArgs e)
        {
            OtherStores.Items.Clear();

            List<StoreRawData> StoresList = controllerSO.GetCollaboratorStores(controllerSO.storeOwner.Data.ID);

            if (StoresList == null)
                return;

            foreach (StoreRawData storeData in StoresList)
            {
                OtherStores.Items.Add(storeData.ToString());
            }
        }

        private void BOpenOtherStore_Click(object sender, EventArgs e)
        {
            String SelectedItem = OtherStores.SelectedItem.ToString();
            StoreRawData tempData = new StoreRawData();
            tempData.RefactorString(SelectedItem);
            String StoreID = tempData.ID;

            String UserID = controllerSO.storeOwner.Data.ID;
            StoreRawData storeRawData = new StoreRawData();
            storeRawData.RefactorString(OtherStores.SelectedItem.ToString());
            Statistics statistics = controllerSO.GetStoreStat(storeRawData.ID);

            UserStoreData userStoreData = new UserStoreData(UserID, storeRawData, statistics);

            Store store = new Store(userStoreData);

            StoreController storeController = new StoreController(store);
            StoreProductController storeProductController = new StoreProductController();

            StoreLayoutPage storeLayoutPage = new StoreLayoutPage(controllerSO, storeController, storeProductController, true);
            storeLayoutPage.Show();
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
