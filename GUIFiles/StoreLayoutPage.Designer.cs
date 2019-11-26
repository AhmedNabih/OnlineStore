namespace OnlineStore.GUIFiles
{
    partial class StoreLayoutPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bclose = new System.Windows.Forms.Button();
            this.Lrole = new System.Windows.Forms.Label();
            this.Trole = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Lemail = new System.Windows.Forms.Label();
            this.LuserName = new System.Windows.Forms.Label();
            this.Temail = new System.Windows.Forms.TextBox();
            this.TuserName = new System.Windows.Forms.TextBox();
            this.Tname = new System.Windows.Forms.TextBox();
            this.StoreLocation = new System.Windows.Forms.Label();
            this.StoreType = new System.Windows.Forms.Label();
            this.StoreName = new System.Windows.Forms.Label();
            this.TstoreType = new System.Windows.Forms.TextBox();
            this.TStoreName = new System.Windows.Forms.TextBox();
            this.TstoreLocation = new System.Windows.Forms.TextBox();
            this.Products = new System.Windows.Forms.CheckedListBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.BRefresh = new System.Windows.Forms.Button();
            this.ShowProducts = new System.Windows.Forms.Button();
            this.MyProducts = new System.Windows.Forms.CheckedListBox();
            this.TnumSold = new System.Windows.Forms.TextBox();
            this.TnumViews = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowProductStat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bclose
            // 
            this.Bclose.Location = new System.Drawing.Point(856, 395);
            this.Bclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 23);
            this.Bclose.TabIndex = 0;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = true;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // Lrole
            // 
            this.Lrole.AutoSize = true;
            this.Lrole.Location = new System.Drawing.Point(787, 18);
            this.Lrole.Name = "Lrole";
            this.Lrole.Size = new System.Drawing.Size(37, 17);
            this.Lrole.TabIndex = 24;
            this.Lrole.Text = "Role";
            // 
            // Trole
            // 
            this.Trole.Location = new System.Drawing.Point(829, 14);
            this.Trole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Trole.Name = "Trole";
            this.Trole.ReadOnly = true;
            this.Trole.Size = new System.Drawing.Size(175, 22);
            this.Trole.TabIndex = 23;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(544, 17);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(45, 17);
            this.Lname.TabIndex = 22;
            this.Lname.Text = "Name";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(301, 17);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(42, 17);
            this.Lemail.TabIndex = 21;
            this.Lemail.Text = "Email";
            // 
            // LuserName
            // 
            this.LuserName.AutoSize = true;
            this.LuserName.Location = new System.Drawing.Point(29, 17);
            this.LuserName.Name = "LuserName";
            this.LuserName.Size = new System.Drawing.Size(75, 17);
            this.LuserName.TabIndex = 20;
            this.LuserName.Text = "UserName";
            // 
            // Temail
            // 
            this.Temail.Location = new System.Drawing.Point(349, 12);
            this.Temail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Temail.Name = "Temail";
            this.Temail.ReadOnly = true;
            this.Temail.Size = new System.Drawing.Size(175, 22);
            this.Temail.TabIndex = 19;
            // 
            // TuserName
            // 
            this.TuserName.Location = new System.Drawing.Point(109, 12);
            this.TuserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TuserName.Name = "TuserName";
            this.TuserName.ReadOnly = true;
            this.TuserName.Size = new System.Drawing.Size(175, 22);
            this.TuserName.TabIndex = 18;
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(592, 14);
            this.Tname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tname.Name = "Tname";
            this.Tname.ReadOnly = true;
            this.Tname.Size = new System.Drawing.Size(175, 22);
            this.Tname.TabIndex = 17;
            // 
            // StoreLocation
            // 
            this.StoreLocation.AutoSize = true;
            this.StoreLocation.Location = new System.Drawing.Point(589, 59);
            this.StoreLocation.Name = "StoreLocation";
            this.StoreLocation.Size = new System.Drawing.Size(100, 17);
            this.StoreLocation.TabIndex = 30;
            this.StoreLocation.Text = "Store Location";
            // 
            // StoreType
            // 
            this.StoreType.AutoSize = true;
            this.StoreType.Location = new System.Drawing.Point(313, 59);
            this.StoreType.Name = "StoreType";
            this.StoreType.Size = new System.Drawing.Size(78, 17);
            this.StoreType.TabIndex = 29;
            this.StoreType.Text = "Store Type";
            // 
            // StoreName
            // 
            this.StoreName.AutoSize = true;
            this.StoreName.Location = new System.Drawing.Point(29, 59);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(83, 17);
            this.StoreName.TabIndex = 28;
            this.StoreName.Text = "Store Name";
            // 
            // TstoreType
            // 
            this.TstoreType.Location = new System.Drawing.Point(397, 54);
            this.TstoreType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TstoreType.Name = "TstoreType";
            this.TstoreType.ReadOnly = true;
            this.TstoreType.Size = new System.Drawing.Size(175, 22);
            this.TstoreType.TabIndex = 27;
            // 
            // TStoreName
            // 
            this.TStoreName.Location = new System.Drawing.Point(117, 57);
            this.TStoreName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TStoreName.Name = "TStoreName";
            this.TStoreName.ReadOnly = true;
            this.TStoreName.Size = new System.Drawing.Size(175, 22);
            this.TStoreName.TabIndex = 26;
            // 
            // TstoreLocation
            // 
            this.TstoreLocation.Location = new System.Drawing.Point(695, 54);
            this.TstoreLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TstoreLocation.Name = "TstoreLocation";
            this.TstoreLocation.ReadOnly = true;
            this.TstoreLocation.Size = new System.Drawing.Size(175, 22);
            this.TstoreLocation.TabIndex = 25;
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(16, 112);
            this.Products.Margin = new System.Windows.Forms.Padding(4);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(403, 157);
            this.Products.TabIndex = 33;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(259, 309);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(100, 28);
            this.AddProduct.TabIndex = 35;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // BRefresh
            // 
            this.BRefresh.Location = new System.Drawing.Point(865, 289);
            this.BRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(100, 28);
            this.BRefresh.TabIndex = 36;
            this.BRefresh.Text = "Refresh";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // ShowProducts
            // 
            this.ShowProducts.Location = new System.Drawing.Point(33, 309);
            this.ShowProducts.Margin = new System.Windows.Forms.Padding(4);
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.Size = new System.Drawing.Size(177, 28);
            this.ShowProducts.TabIndex = 37;
            this.ShowProducts.Text = "Show Avaialbe Products";
            this.ShowProducts.UseVisualStyleBackColor = true;
            this.ShowProducts.Click += new System.EventHandler(this.ShowProducts_Click);
            // 
            // MyProducts
            // 
            this.MyProducts.AllowDrop = true;
            this.MyProducts.FormattingEnabled = true;
            this.MyProducts.Location = new System.Drawing.Point(592, 112);
            this.MyProducts.Margin = new System.Windows.Forms.Padding(4);
            this.MyProducts.Name = "MyProducts";
            this.MyProducts.Size = new System.Drawing.Size(403, 157);
            this.MyProducts.TabIndex = 38;
            // 
            // TnumSold
            // 
            this.TnumSold.Location = new System.Drawing.Point(402, 411);
            this.TnumSold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TnumSold.Name = "TnumSold";
            this.TnumSold.ReadOnly = true;
            this.TnumSold.Size = new System.Drawing.Size(175, 22);
            this.TnumSold.TabIndex = 39;
            // 
            // TnumViews
            // 
            this.TnumViews.Location = new System.Drawing.Point(118, 411);
            this.TnumViews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TnumViews.Name = "TnumViews";
            this.TnumViews.ReadOnly = true;
            this.TnumViews.Size = new System.Drawing.Size(175, 22);
            this.TnumViews.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Num of sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Num of Views";
            // 
            // ShowProductStat
            // 
            this.ShowProductStat.Location = new System.Drawing.Point(620, 289);
            this.ShowProductStat.Margin = new System.Windows.Forms.Padding(4);
            this.ShowProductStat.Name = "ShowProductStat";
            this.ShowProductStat.Size = new System.Drawing.Size(177, 28);
            this.ShowProductStat.TabIndex = 43;
            this.ShowProductStat.Text = "Show Product Stat.";
            this.ShowProductStat.UseVisualStyleBackColor = true;
            this.ShowProductStat.Click += new System.EventHandler(this.ShowProductStat_Click);
            // 
            // StoreLayoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.ShowProductStat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TnumViews);
            this.Controls.Add(this.TnumSold);
            this.Controls.Add(this.MyProducts);
            this.Controls.Add(this.ShowProducts);
            this.Controls.Add(this.BRefresh);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.StoreLocation);
            this.Controls.Add(this.StoreType);
            this.Controls.Add(this.StoreName);
            this.Controls.Add(this.TstoreType);
            this.Controls.Add(this.TStoreName);
            this.Controls.Add(this.TstoreLocation);
            this.Controls.Add(this.Lrole);
            this.Controls.Add(this.Trole);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.LuserName);
            this.Controls.Add(this.Temail);
            this.Controls.Add(this.TuserName);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.Bclose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StoreLayoutPage";
            this.Text = "StoreLayoutPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Label Lrole;
        private System.Windows.Forms.TextBox Trole;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label LuserName;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.TextBox TuserName;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.Label StoreLocation;
        private System.Windows.Forms.Label StoreType;
        private System.Windows.Forms.Label StoreName;
        private System.Windows.Forms.TextBox TstoreType;
        private System.Windows.Forms.TextBox TStoreName;
        private System.Windows.Forms.TextBox TstoreLocation;
        private System.Windows.Forms.CheckedListBox Products;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button BRefresh;
        private System.Windows.Forms.Button ShowProducts;
        private System.Windows.Forms.CheckedListBox MyProducts;
        private System.Windows.Forms.TextBox TnumSold;
        private System.Windows.Forms.TextBox TnumViews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowProductStat;
    }
}