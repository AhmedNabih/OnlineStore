using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OnlineStore.App.Stores;
using OnlineStore.App.Stores.Data;
using OnlineStore.Data;
using OnlineStore.GUIFiles.Users.StoreOwner;
using OnlineStore.Users.StoreOwners;

namespace OnlineStore.GUIFiles
{
    public partial class StoreLayoutPage : Form
    {
        private StoreController controllerStore;
        private StoreOwnerController controllerSO;
        private StoreProductController controllerStoreProduct;
        private static double price = 0.0;
        private static int amount = 0;
        private bool collMode = false;
        public static void SetPrice(double p) { price = p; }
        public static void SetAmount(int a) { amount = a; }

        public StoreLayoutPage(StoreOwnerController controllerSO, StoreController controllerStore, StoreProductController controllerStoreProduct, bool b)
        {
            InitializeComponent();
            this.collMode = b;
            this.TuserName.Text = controllerSO.storeOwner.Data.ID;
            this.Temail.Text = controllerSO.storeOwner.Data.email;
            this.Tname.Text = controllerSO.storeOwner.Data.name;
            this.Trole.Text = controllerSO.storeOwner.Data.role;
            this.controllerSO = controllerSO;
            this.controllerStore = controllerStore;
            this.controllerStoreProduct = controllerStoreProduct;
            this.TStoreName.Text = controllerStore.store.storeData.storeData.Name;
            this.TstoreType.Text = controllerStore.store.storeData.storeData.Type;
            this.TstoreLocation.Text = controllerStore.store.storeData.storeData.Location;
        }

        ///////////////////////////////////// Store Products /////////////////////////////////////

        private void BShowStoreProduct_Click(object sender, EventArgs e)
        {
            this.ProductList.Items.Clear();
            List<StoreProduct> storeProductList = controllerStoreProduct.GetStoreProducts(controllerStore.store.storeData.storeData.ID);

            if (storeProductList == null)
                return;

            foreach (StoreProduct product in storeProductList)
            {
                this.ProductList.Items.Add(product.ToString());
            }
        }

        private void BAddStoreProduct_Click(object sender, EventArgs e)
        {
            if(SystemProductsList.SelectedItem == null || SystemBrandsList.SelectedItem == null)
            {
                MessageBox.Show("Please select brand and product");
                return;
            }

            String product = SystemProductsList.SelectedItem.ToString();
            String Brand = SystemBrandsList.SelectedItem.ToString();
            
            ProductRawData productRawData = new ProductRawData();
            productRawData.RefactorString(product);

            BrandRawData brandRawData = new BrandRawData();
            brandRawData.RefactorString(Brand);

            InputData inputData = new InputData("price", "amount", "Submit Product");
            inputData.ShowDialog();

            StoreProduct storeProduct = new StoreProduct("0", controllerStore.GetStoreID(), productRawData, brandRawData, price, amount);
            bool DONE = controllerStoreProduct.AddStoreProduct(controllerStore.GetStoreID(), storeProduct);
            if (DONE)
                MessageBox.Show("Product Added");
            else
                MessageBox.Show("Product Add failed");

            BShowStoreProduct_Click(sender, e);
        }

        private void BEditStoreProduct_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void BDeleteStoreProduct_Click(object sender, EventArgs e)
        {
            if (ProductList.SelectedItem == null)
            {
                MessageBox.Show("Please select product");
                return;
            }
            String product = ProductList.SelectedItem.ToString();
            StoreProduct storeProduct = new StoreProduct();
            storeProduct.RefactorString(product);

            bool DONE = controllerStoreProduct.RemoveStoreProduct(controllerStore.GetStoreID(), storeProduct.storeProductID);
            if (DONE)
                MessageBox.Show("Product Deleted");
            else
                MessageBox.Show("Product Deleted failed");

            BShowStoreProduct_Click(sender, e);
        }

        private void BShowProductStat_Click(object sender, EventArgs e)
        {
            if (ProductList.SelectedItem == null)
            {
                MessageBox.Show("Please select product");
                return;
            }
            String product = ProductList.SelectedItem.ToString();
            StoreProduct storeProduct = new StoreProduct();
            storeProduct.RefactorString(product);

            Statistics stat = controllerStoreProduct.GetProductStat(storeProduct.storeProductID);

            this.TProductView.Text = stat.CntView.ToString();
            this.TProductSold.Text = stat.CntSold.ToString();
        }

        ///////////////////////////////////// System Products /////////////////////////////////////

        private void ShowProducts_Click(object sender, EventArgs e)
        {
            this.SystemProductsList.Items.Clear();
            List<ProductRawData> productsList = controllerSO.GetSystemProducts();
            if (productsList == null)
                return;

            foreach (ProductRawData product in productsList)
            {
                this.SystemProductsList.Items.Add(product.ToString());
            }
        }

        ///////////////////////////////////// System Brands /////////////////////////////////////

        private void BShowBrands_Click(object sender, EventArgs e)
        {
            this.SystemBrandsList.Items.Clear();
            List<BrandRawData> brandsList = controllerSO.GetSystemBrands();
            if (brandsList == null)
                return;

            foreach (BrandRawData brand in brandsList)
            {
                this.SystemBrandsList.Items.Add(brand.ToString());
            }
        }


        ///////////////////////////////////// Collaborators /////////////////////////////////////

        private void CurrentStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BCollaborators_Click(object sender, EventArgs e)
        {
            CollaboratorController collaboratorController = new CollaboratorController(controllerSO.storeOwner.Data.ID, controllerStore.store.storeData.storeData.ID);
            CollaboratorsPage collaboratorsPage = new CollaboratorsPage(collaboratorController);
            collaboratorsPage.Show();
        }

        ///////////////////////////////////// Others /////////////////////////////////////

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
