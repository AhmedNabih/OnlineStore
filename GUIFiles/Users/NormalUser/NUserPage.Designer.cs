﻿namespace OnlineStore
{
    partial class NUserPage
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
            this.Lrole = new System.Windows.Forms.Label();
            this.Trole = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Lemail = new System.Windows.Forms.Label();
            this.LuserName = new System.Windows.Forms.Label();
            this.Temail = new System.Windows.Forms.TextBox();
            this.TuserName = new System.Windows.Forms.TextBox();
            this.Tname = new System.Windows.Forms.TextBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BRefresh = new System.Windows.Forms.Button();
            this.OpenStore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.ViewCart = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.Store = new System.Windows.Forms.ListBox();
            this.Products = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lrole
            // 
            this.Lrole.AutoSize = true;
            this.Lrole.Location = new System.Drawing.Point(792, 18);
            this.Lrole.Name = "Lrole";
            this.Lrole.Size = new System.Drawing.Size(37, 17);
            this.Lrole.TabIndex = 16;
            this.Lrole.Text = "Role";
            // 
            // Trole
            // 
            this.Trole.Location = new System.Drawing.Point(834, 13);
            this.Trole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Trole.Name = "Trole";
            this.Trole.ReadOnly = true;
            this.Trole.Size = new System.Drawing.Size(175, 22);
            this.Trole.TabIndex = 15;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(549, 15);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(45, 17);
            this.Lname.TabIndex = 14;
            this.Lname.Text = "Name";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(308, 15);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(42, 17);
            this.Lemail.TabIndex = 13;
            this.Lemail.Text = "Email";
            // 
            // LuserName
            // 
            this.LuserName.AutoSize = true;
            this.LuserName.Location = new System.Drawing.Point(34, 15);
            this.LuserName.Name = "LuserName";
            this.LuserName.Size = new System.Drawing.Size(75, 17);
            this.LuserName.TabIndex = 12;
            this.LuserName.Text = "UserName";
            // 
            // Temail
            // 
            this.Temail.Location = new System.Drawing.Point(356, 11);
            this.Temail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Temail.Name = "Temail";
            this.Temail.ReadOnly = true;
            this.Temail.Size = new System.Drawing.Size(175, 22);
            this.Temail.TabIndex = 11;
            // 
            // TuserName
            // 
            this.TuserName.Location = new System.Drawing.Point(116, 11);
            this.TuserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TuserName.Name = "TuserName";
            this.TuserName.ReadOnly = true;
            this.TuserName.Size = new System.Drawing.Size(175, 22);
            this.TuserName.TabIndex = 10;
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(597, 13);
            this.Tname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tname.Name = "Tname";
            this.Tname.ReadOnly = true;
            this.Tname.Size = new System.Drawing.Size(175, 22);
            this.Tname.TabIndex = 9;
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(58, 730);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(100, 28);
            this.LogOut.TabIndex = 20;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(164, 730);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 28);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BRefresh
            // 
            this.BRefresh.Location = new System.Drawing.Point(381, 338);
            this.BRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(100, 28);
            this.BRefresh.TabIndex = 25;
            this.BRefresh.Text = "Refresh";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // OpenStore
            // 
            this.OpenStore.Location = new System.Drawing.Point(510, 338);
            this.OpenStore.Margin = new System.Windows.Forms.Padding(4);
            this.OpenStore.Name = "OpenStore";
            this.OpenStore.Size = new System.Drawing.Size(100, 28);
            this.OpenStore.TabIndex = 24;
            this.OpenStore.Text = "Open Store";
            this.OpenStore.UseVisualStyleBackColor = true;
            this.OpenStore.Click += new System.EventHandler(this.OpenStore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Available stores";
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(447, 654);
            this.AddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(100, 28);
            this.AddToCart.TabIndex = 27;
            this.AddToCart.Text = "AddToCart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // ViewCart
            // 
            this.ViewCart.Location = new System.Drawing.Point(847, 709);
            this.ViewCart.Margin = new System.Windows.Forms.Padding(4);
            this.ViewCart.Name = "ViewCart";
            this.ViewCart.Size = new System.Drawing.Size(100, 28);
            this.ViewCart.TabIndex = 28;
            this.ViewCart.Text = "ViewCart";
            this.ViewCart.UseVisualStyleBackColor = true;
            this.ViewCart.Click += new System.EventHandler(this.ViewCart_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(272, 730);
            this.BClose.Margin = new System.Windows.Forms.Padding(4);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(100, 28);
            this.BClose.TabIndex = 29;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // Store
            // 
            this.Store.FormattingEnabled = true;
            this.Store.ItemHeight = 16;
            this.Store.Location = new System.Drawing.Point(37, 87);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(935, 244);
            this.Store.TabIndex = 48;
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.ItemHeight = 16;
            this.Products.Location = new System.Drawing.Point(37, 403);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(935, 244);
            this.Products.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Available Products in store";
            // 
            // NUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 771);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Store);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.ViewCart);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.BRefresh);
            this.Controls.Add(this.OpenStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Lrole);
            this.Controls.Add(this.Trole);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.LuserName);
            this.Controls.Add(this.Temail);
            this.Controls.Add(this.TuserName);
            this.Controls.Add(this.Tname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NUserPage";
            this.Text = "NUserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lrole;
        private System.Windows.Forms.TextBox Trole;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label LuserName;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.TextBox TuserName;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button BRefresh;
        private System.Windows.Forms.Button OpenStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Button ViewCart;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.ListBox Store;
        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.Label label2;
    }
}