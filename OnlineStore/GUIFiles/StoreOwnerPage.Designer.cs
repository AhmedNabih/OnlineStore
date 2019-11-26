namespace OnlineStore
{
    partial class StoreOwnerPage
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
            this.AddStore = new System.Windows.Forms.Button();
            this.MyStores = new System.Windows.Forms.CheckedListBox();
            this.ShowStore = new System.Windows.Forms.Button();
            this.RefreshStoreList = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Bexit = new System.Windows.Forms.Button();
            this.DeleteStores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lrole
            // 
            this.Lrole.AutoSize = true;
            this.Lrole.Location = new System.Drawing.Point(774, 19);
            this.Lrole.Name = "Lrole";
            this.Lrole.Size = new System.Drawing.Size(37, 17);
            this.Lrole.TabIndex = 16;
            this.Lrole.Text = "Role";
            // 
            // Trole
            // 
            this.Trole.Location = new System.Drawing.Point(817, 14);
            this.Trole.Name = "Trole";
            this.Trole.ReadOnly = true;
            this.Trole.Size = new System.Drawing.Size(174, 22);
            this.Trole.TabIndex = 15;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(532, 17);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(45, 17);
            this.Lname.TabIndex = 14;
            this.Lname.Text = "Name";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(290, 17);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(42, 17);
            this.Lemail.TabIndex = 13;
            this.Lemail.Text = "Email";
            // 
            // LuserName
            // 
            this.LuserName.AutoSize = true;
            this.LuserName.Location = new System.Drawing.Point(17, 17);
            this.LuserName.Name = "LuserName";
            this.LuserName.Size = new System.Drawing.Size(75, 17);
            this.LuserName.TabIndex = 12;
            this.LuserName.Text = "UserName";
            // 
            // Temail
            // 
            this.Temail.Location = new System.Drawing.Point(338, 12);
            this.Temail.Name = "Temail";
            this.Temail.ReadOnly = true;
            this.Temail.Size = new System.Drawing.Size(174, 22);
            this.Temail.TabIndex = 11;
            // 
            // TuserName
            // 
            this.TuserName.Location = new System.Drawing.Point(98, 12);
            this.TuserName.Name = "TuserName";
            this.TuserName.ReadOnly = true;
            this.TuserName.Size = new System.Drawing.Size(174, 22);
            this.TuserName.TabIndex = 10;
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(580, 14);
            this.Tname.Name = "Tname";
            this.Tname.ReadOnly = true;
            this.Tname.Size = new System.Drawing.Size(174, 22);
            this.Tname.TabIndex = 9;
            // 
            // AddStore
            // 
            this.AddStore.Location = new System.Drawing.Point(194, 363);
            this.AddStore.Name = "AddStore";
            this.AddStore.Size = new System.Drawing.Size(171, 40);
            this.AddStore.TabIndex = 17;
            this.AddStore.Text = "Add Store";
            this.AddStore.UseVisualStyleBackColor = true;
            this.AddStore.Click += new System.EventHandler(this.AddStore_Click);
            // 
            // MyStores
            // 
            this.MyStores.FormattingEnabled = true;
            this.MyStores.Location = new System.Drawing.Point(29, 81);
            this.MyStores.Name = "MyStores";
            this.MyStores.Size = new System.Drawing.Size(323, 276);
            this.MyStores.TabIndex = 18;
            // 
            // ShowStore
            // 
            this.ShowStore.Location = new System.Drawing.Point(20, 363);
            this.ShowStore.Name = "ShowStore";
            this.ShowStore.Size = new System.Drawing.Size(168, 40);
            this.ShowStore.TabIndex = 19;
            this.ShowStore.Text = "Show My Stores";
            this.ShowStore.UseVisualStyleBackColor = true;
            this.ShowStore.Click += new System.EventHandler(this.ShowStore_Click);
            // 
            // RefreshStoreList
            // 
            this.RefreshStoreList.Location = new System.Drawing.Point(20, 409);
            this.RefreshStoreList.Name = "RefreshStoreList";
            this.RefreshStoreList.Size = new System.Drawing.Size(168, 40);
            this.RefreshStoreList.TabIndex = 20;
            this.RefreshStoreList.Text = "Refresh Store List";
            this.RefreshStoreList.UseVisualStyleBackColor = true;
            this.RefreshStoreList.Click += new System.EventHandler(this.RefreshStoreList_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(360, 470);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(152, 27);
            this.Logout.TabIndex = 21;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Bexit
            // 
            this.Bexit.Location = new System.Drawing.Point(518, 470);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(152, 27);
            this.Bexit.TabIndex = 22;
            this.Bexit.Text = "Exit";
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // DeleteStores
            // 
            this.DeleteStores.Location = new System.Drawing.Point(197, 409);
            this.DeleteStores.Name = "DeleteStores";
            this.DeleteStores.Size = new System.Drawing.Size(168, 40);
            this.DeleteStores.TabIndex = 23;
            this.DeleteStores.Text = "Delete Selected Stores";
            this.DeleteStores.UseVisualStyleBackColor = true;
            this.DeleteStores.Click += new System.EventHandler(this.DeleteStores_Click);
            // 
            // StoreOwnerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 522);
            this.Controls.Add(this.DeleteStores);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.RefreshStoreList);
            this.Controls.Add(this.ShowStore);
            this.Controls.Add(this.MyStores);
            this.Controls.Add(this.AddStore);
            this.Controls.Add(this.Lrole);
            this.Controls.Add(this.Trole);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.LuserName);
            this.Controls.Add(this.Temail);
            this.Controls.Add(this.TuserName);
            this.Controls.Add(this.Tname);
            this.Name = "StoreOwnerPage";
            this.Text = "StoreOwnerPage";
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
        private System.Windows.Forms.Button AddStore;
        private System.Windows.Forms.CheckedListBox MyStores;
        private System.Windows.Forms.Button ShowStore;
        private System.Windows.Forms.Button RefreshStoreList;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.Button DeleteStores;
    }
}