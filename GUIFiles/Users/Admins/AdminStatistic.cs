using OnlineStore.App.Stores.Data;
using OnlineStore.Data;
using OnlineStore.Users.Admins;
using OnlineStore.Users.Admins.AdminStatisticsSystem;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles.Users.Admins
{
    public partial class AdminStatistic : Form
    {
        private AdminsController controllerAdmin;
        private AdminStatisticsController controllerStatistic;
        private bool Users, Store;

        public AdminStatistic(AdminsController controllerAdmin, AdminStatisticsController controllerStatistic)
        {
            this.controllerAdmin = controllerAdmin;
            this.controllerStatistic = controllerStatistic;
            this.Users = false;
            this.Store = false;
            InitializeComponent();

            TuserName.Text = controllerAdmin.admin.Data.userName;
            Temail.Text = controllerAdmin.admin.Data.email;
            Tname.Text = controllerAdmin.admin.Data.name;
            Trole.Text = controllerAdmin.admin.Data.role;
        }
        
        private void BShowUsers_Click(object sender, EventArgs e)
        {
            this.Users = true;
            this.Store = false;
            StatBox.Items.Clear();

            // UserID, UserName, Name, Email, Role
            List<UserData> userList = controllerStatistic.GetAllUsersData();

            if (userList == null)
                return;

            StatBox.Items.Add("All");
            foreach (UserData user in userList)
            {
                StatBox.Items.Add(user.ToString());
            }
        }

        private void BShowStores_Click(object sender, EventArgs e)
        {
            String SelectedString;

            if (StatBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Something.");
            }
            else
            {
                List<UserStoreData> userStoresList = new List<UserStoreData>();
                SelectedString = StatBox.SelectedItem.ToString();
                if (this.Users && SelectedString != "All")
                {
                    UserData tempUserData = new UserData();
                    tempUserData.RefactorString(SelectedString);
                    // UserID, StoreID, StoreName, StoreType, StoreLocation, StoreInfo, statID, noOfview, noOfSold
                    userStoresList = controllerStatistic.GetUserStores(tempUserData.ID);
                }
                else
                {
                    // UserID, UserName, StoreID, StoreName, StoreType, StoreLocation, StoreInfo
                    userStoresList = controllerStatistic.GetAllUserStores();
                }

                if (userStoresList == null)
                    return;

                this.Users = false;
                this.Store = true;
                StatBox.Items.Clear();
                StatBox.Items.Add("All");
                foreach (UserStoreData data in userStoresList)
                {
                    StatBox.Items.Add(data.ToString());
                }
            }

        }

        private void BShowProducts_Click(object sender, EventArgs e)
        {
            String SelectedString;

            if (StatBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Something.");
            }
            else
            {
                List<StoreProduct> storeProductsList = new List<StoreProduct>();
                SelectedString = StatBox.SelectedItem.ToString();
                if (this.Store && SelectedString != "All")
                {
                    UserStoreData tempUserStoreData = new UserStoreData();
                    tempUserStoreData.RefactorString(SelectedString);
                    // TODO
                    storeProductsList = controllerStatistic.GetProductsInStore(tempUserStoreData.storeData.ID);
                }
                else
                {
                    // TODO
                    storeProductsList = controllerStatistic.GetAllProductsInStore();
                }

                if (storeProductsList == null)
                    return;

                this.Users = false;
                this.Store = false;
                StatBox.Items.Clear();
                StatBox.Items.Add("All");
                foreach (StoreProduct data in storeProductsList)
                {
                    StatBox.Items.Add(data.ToString());
                }
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            this.Users = false;
            this.Store = false;
            StatBox.Items.Clear();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BProcess_Click(object sender, EventArgs e)
        {
            // kind operation onwhat
            if (OperationBox.SelectedItem == null || KindBox.SelectedItem == null || OnWhatBox.SelectedItem == null)
                MessageBox.Show("select select everything");
            else
            {
                
                String arg1 = KindBox.SelectedItem.ToString() + " " + OperationBox.SelectedItem.ToString() + " " + OnWhatBox.SelectedItem.ToString();
                String arg2 = UserStoreID.Text == "" ? null : UserStoreID.Text;

                String res = controllerStatistic.Statistic(OperationBox.SelectedItem.ToString(), arg1, arg2);
                
                String screen = Output.Text + "\n" + res;
                Output.Text = screen;
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
