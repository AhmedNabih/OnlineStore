using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using OnlineStore.App.Stores.Data;
using OnlineStore.Data;
using OnlineStore.Users.Admins;
using OnlineStore.Users.Admins.AdminStatisticsSystem;

namespace OnlineStore.GUIFiles.Users.Admins
{
    public partial class AdminPage : Form
    {
        private AdminsController controller;

        public AdminPage(AdminsController controller)
        {

            this.controller = controller;
            InitializeComponent();

            TuserName.Text = controller.admin.Data.userName;
            Temail.Text = controller.admin.Data.email;
            Tname.Text = controller.admin.Data.name;
            Trole.Text = controller.admin.Data.role;
        }

        ///////////////////////////////////// Product /////////////////////////////////////

        private void RefreshProductsList_Click(object sender, EventArgs e)
        {
            ProductsList.Items.Clear();

            List<ProductRawData> productList = controller.GetProductsData();

            if (productList == null)
                return;

            foreach (ProductRawData product in productList)
            {
                ProductsList.Items.Add(product.ToString());
            }
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            AddProductsPage app = new AddProductsPage(controller);
            app.ShowDialog();
            RefreshProductsList_Click(sender, e);
        }

        private void RemoveCheckedProduct_Click(object sender, EventArgs e)
        {
            List<ProductRawData> removeList = new List<ProductRawData>();
            for (int i = 0; i < ProductsList.Items.Count; i++)
            {
                if (ProductsList.GetItemChecked(i))
                {
                    ProductRawData tempData = new ProductRawData();
                    tempData.RefactorString(ProductsList.Items[i].ToString());
                    removeList.Add(tempData);
                }
            }

            for (int i = 0; i < removeList.Count; i++)
            {
                bool DONE = controller.RemoveProduct(removeList[i].ID);
                if (DONE)
                    MessageBox.Show(removeList[i].ToString() + " Removed");
                else
                    MessageBox.Show(removeList[i].ToString() + " Remove Failed");
            }

            RefreshProductsList_Click(sender, e);
        }

        private void BEditProduct_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////// Brand /////////////////////////////////////

        private void BRefreshBrandList_Click(object sender, EventArgs e)
        {
            BrandList.Items.Clear();

            List<BrandRawData> brandList = controller.GetBrandsData();

            if (brandList == null)
                return;

            foreach (BrandRawData brand in brandList)
            {
                BrandList.Items.Add(brand.ToString());
            }
        }

        private void BAddNewBrand_Click(object sender, EventArgs e)
        {
            AddBrandPage addBrandPage = new AddBrandPage(controller);
            addBrandPage.ShowDialog();
            BRefreshBrandList_Click(sender, e);
        }

        private void BRemoveBrand_Click(object sender, EventArgs e)
        {
            List<BrandRawData> removeList = new List<BrandRawData>();
            for (int i = 0; i < BrandList.Items.Count; i++)
            {
                if (BrandList.GetItemChecked(i))
                {
                    BrandRawData tempData = new BrandRawData();
                    tempData.RefactorString(BrandList.Items[i].ToString());
                    removeList.Add(tempData);
                }
            }

            for (int i = 0; i < removeList.Count; i++)
            {
                bool DONE = controller.RemoveBrand(removeList[i].ID);
                if (DONE)
                    MessageBox.Show(removeList[i].ToString() + " Removed");
                else
                    MessageBox.Show(removeList[i].ToString() + " Remove Failed");
            }

            BRefreshBrandList_Click(sender, e);
        }

        private void BEditBrand_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////// Store Request /////////////////////////////////////

        private void ShowReq_Click(object sender, EventArgs e)
        {
            StoresReq.Items.Clear();

            List<StoreRequest> StoreRequestList = controller.GetStoreRequest();

            if (StoreRequestList == null)
                return;

            foreach (StoreRequest request in StoreRequestList)
            {
                StoresReq.Items.Add(request.ToString());
            }
        }

        private void AddCheckedStoresReq_Click(object sender, EventArgs e)
        {
            List<StoreRequest> addList = new List<StoreRequest>();
            for (int i = 0; i < StoresReq.Items.Count; i++)
            {
                if (StoresReq.GetItemChecked(i))
                {
                    StoreRequest tempData = new StoreRequest();
                    tempData.RefactorString(StoresReq.Items[i].ToString());
                    addList.Add(tempData);
                }
            }

            for (int i = 0; i < addList.Count; i++)
            {
                bool DONE = controller.AcceptStore(addList[i].storeRequestID, addList[i].userID, addList[i].storeData.ID);
                if (DONE)
                    MessageBox.Show(addList[i].ToString() + " Added");
                else
                    MessageBox.Show(addList[i].ToString() + " Add Failed");
            }

            ShowReq_Click(sender, e);
        }

        private void RemoveCheckedStoresReq_Click(object sender, EventArgs e)
        {
            List<StoreRequest> removeList = new List<StoreRequest>();
            for (int i = 0; i < StoresReq.Items.Count; i++)
            {
                if (StoresReq.GetItemChecked(i))
                {
                    StoreRequest tempData = new StoreRequest();
                    tempData.RefactorString(StoresReq.Items[i].ToString());
                    removeList.Add(tempData);
                }
            }

            for (int i = 0; i < removeList.Count; i++)
            {
                bool DONE = controller.RejectStore(removeList[i].storeRequestID,removeList[i].storeData.ID);
                if (DONE)
                    MessageBox.Show(removeList[i].ToString() + " Removed");
                else
                    MessageBox.Show(removeList[i].ToString() + " Remove Failed");
            }

            ShowReq_Click(sender, e);
        }

        ///////////////////////////////////// Page /////////////////////////////////////

        private void LogOut_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            AdminStatisticsController controllerStatistic = new AdminStatisticsController();
            AdminStatistic adminStatistic = new AdminStatistic(controller, controllerStatistic);
            adminStatistic.Show();
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
