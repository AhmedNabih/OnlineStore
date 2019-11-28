namespace OnlineStore
{
    partial class AdminPage
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
            this.AddNewProduct = new System.Windows.Forms.Button();
            this.Tname = new System.Windows.Forms.TextBox();
            this.TuserName = new System.Windows.Forms.TextBox();
            this.Temail = new System.Windows.Forms.TextBox();
            this.LuserName = new System.Windows.Forms.Label();
            this.Lemail = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Lrole = new System.Windows.Forms.Label();
            this.Trole = new System.Windows.Forms.TextBox();
            this.ShowReq = new System.Windows.Forms.Button();
            this.StoresReq = new System.Windows.Forms.CheckedListBox();
            this.AddCheckedStoresReq = new System.Windows.Forms.Button();
            this.ProductsList = new System.Windows.Forms.CheckedListBox();
            this.RefreshProductsList = new System.Windows.Forms.Button();
            this.RemoveCheckedProduct = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.RemoveCheckedStoresReq = new System.Windows.Forms.Button();
            this.Statistic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.Location = new System.Drawing.Point(75, 401);
            this.AddNewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(149, 50);
            this.AddNewProduct.TabIndex = 0;
            this.AddNewProduct.Text = "Add New Products";
            this.AddNewProduct.UseVisualStyleBackColor = true;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(575, 16);
            this.Tname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tname.Name = "Tname";
            this.Tname.ReadOnly = true;
            this.Tname.Size = new System.Drawing.Size(175, 22);
            this.Tname.TabIndex = 1;
            // 
            // TuserName
            // 
            this.TuserName.Location = new System.Drawing.Point(93, 14);
            this.TuserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TuserName.Name = "TuserName";
            this.TuserName.ReadOnly = true;
            this.TuserName.Size = new System.Drawing.Size(175, 22);
            this.TuserName.TabIndex = 2;
            // 
            // Temail
            // 
            this.Temail.Location = new System.Drawing.Point(333, 14);
            this.Temail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Temail.Name = "Temail";
            this.Temail.ReadOnly = true;
            this.Temail.Size = new System.Drawing.Size(175, 22);
            this.Temail.TabIndex = 3;
            // 
            // LuserName
            // 
            this.LuserName.AutoSize = true;
            this.LuserName.Location = new System.Drawing.Point(12, 18);
            this.LuserName.Name = "LuserName";
            this.LuserName.Size = new System.Drawing.Size(75, 17);
            this.LuserName.TabIndex = 4;
            this.LuserName.Text = "UserName";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(285, 18);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(42, 17);
            this.Lemail.TabIndex = 5;
            this.Lemail.Text = "Email";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(527, 18);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(45, 17);
            this.Lname.TabIndex = 6;
            this.Lname.Text = "Name";
            // 
            // Lrole
            // 
            this.Lrole.AutoSize = true;
            this.Lrole.Location = new System.Drawing.Point(769, 21);
            this.Lrole.Name = "Lrole";
            this.Lrole.Size = new System.Drawing.Size(37, 17);
            this.Lrole.TabIndex = 8;
            this.Lrole.Text = "Role";
            // 
            // Trole
            // 
            this.Trole.Location = new System.Drawing.Point(812, 16);
            this.Trole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Trole.Name = "Trole";
            this.Trole.ReadOnly = true;
            this.Trole.Size = new System.Drawing.Size(175, 22);
            this.Trole.TabIndex = 7;
            // 
            // ShowReq
            // 
            this.ShowReq.Location = new System.Drawing.Point(667, 345);
            this.ShowReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowReq.Name = "ShowReq";
            this.ShowReq.Size = new System.Drawing.Size(149, 50);
            this.ShowReq.TabIndex = 9;
            this.ShowReq.Text = "Show New Stores Request";
            this.ShowReq.UseVisualStyleBackColor = true;
            this.ShowReq.Click += new System.EventHandler(this.ShowReq_Click);
            // 
            // StoresReq
            // 
            this.StoresReq.FormattingEnabled = true;
            this.StoresReq.Location = new System.Drawing.Point(645, 62);
            this.StoresReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StoresReq.Name = "StoresReq";
            this.StoresReq.Size = new System.Drawing.Size(375, 259);
            this.StoresReq.TabIndex = 10;
            // 
            // AddCheckedStoresReq
            // 
            this.AddCheckedStoresReq.Location = new System.Drawing.Point(852, 345);
            this.AddCheckedStoresReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCheckedStoresReq.Name = "AddCheckedStoresReq";
            this.AddCheckedStoresReq.Size = new System.Drawing.Size(149, 50);
            this.AddCheckedStoresReq.TabIndex = 11;
            this.AddCheckedStoresReq.Text = "Add Checked Stores Request";
            this.AddCheckedStoresReq.UseVisualStyleBackColor = true;
            this.AddCheckedStoresReq.Click += new System.EventHandler(this.AddCheckedStoresReq_Click);
            // 
            // ProductsList
            // 
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Location = new System.Drawing.Point(60, 62);
            this.ProductsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(375, 259);
            this.ProductsList.TabIndex = 12;
            // 
            // RefreshProductsList
            // 
            this.RefreshProductsList.Location = new System.Drawing.Point(75, 345);
            this.RefreshProductsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshProductsList.Name = "RefreshProductsList";
            this.RefreshProductsList.Size = new System.Drawing.Size(149, 50);
            this.RefreshProductsList.TabIndex = 13;
            this.RefreshProductsList.Text = "Refresh Products List";
            this.RefreshProductsList.UseVisualStyleBackColor = true;
            this.RefreshProductsList.Click += new System.EventHandler(this.RefreshProductsList_Click);
            // 
            // RemoveCheckedProduct
            // 
            this.RemoveCheckedProduct.Location = new System.Drawing.Point(267, 345);
            this.RemoveCheckedProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveCheckedProduct.Name = "RemoveCheckedProduct";
            this.RemoveCheckedProduct.Size = new System.Drawing.Size(149, 50);
            this.RemoveCheckedProduct.TabIndex = 14;
            this.RemoveCheckedProduct.Text = "Rrmove Checked Products";
            this.RemoveCheckedProduct.UseVisualStyleBackColor = true;
            this.RemoveCheckedProduct.Click += new System.EventHandler(this.RemoveCheckedProduct_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(566, 492);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(83, 30);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(477, 492);
            this.LogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(83, 30);
            this.LogOut.TabIndex = 16;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // RemoveCheckedStoresReq
            // 
            this.RemoveCheckedStoresReq.Location = new System.Drawing.Point(852, 401);
            this.RemoveCheckedStoresReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveCheckedStoresReq.Name = "RemoveCheckedStoresReq";
            this.RemoveCheckedStoresReq.Size = new System.Drawing.Size(149, 50);
            this.RemoveCheckedStoresReq.TabIndex = 17;
            this.RemoveCheckedStoresReq.Text = "Remove New Stores Request";
            this.RemoveCheckedStoresReq.UseVisualStyleBackColor = true;
            this.RemoveCheckedStoresReq.Click += new System.EventHandler(this.RemoveCheckedStoresReq_Click);
            // 
            // Statistic
            // 
            this.Statistic.Location = new System.Drawing.Point(388, 492);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(83, 30);
            this.Statistic.TabIndex = 18;
            this.Statistic.Text = "Statistic";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.RemoveCheckedStoresReq);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RemoveCheckedProduct);
            this.Controls.Add(this.RefreshProductsList);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.AddCheckedStoresReq);
            this.Controls.Add(this.StoresReq);
            this.Controls.Add(this.ShowReq);
            this.Controls.Add(this.Lrole);
            this.Controls.Add(this.Trole);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.LuserName);
            this.Controls.Add(this.Temail);
            this.Controls.Add(this.TuserName);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.AddNewProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPage";
            this.Text = "Admin panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.TextBox TuserName;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.Label LuserName;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lrole;
        private System.Windows.Forms.TextBox Trole;
        private System.Windows.Forms.Button ShowReq;
        private System.Windows.Forms.CheckedListBox StoresReq;
        private System.Windows.Forms.Button AddCheckedStoresReq;
        private System.Windows.Forms.CheckedListBox ProductsList;
        private System.Windows.Forms.Button RefreshProductsList;
        private System.Windows.Forms.Button RemoveCheckedProduct;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button RemoveCheckedStoresReq;
        private System.Windows.Forms.Button Statistic;
    }
}