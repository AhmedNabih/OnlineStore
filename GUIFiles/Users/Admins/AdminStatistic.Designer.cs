namespace OnlineStore.GUIFiles.Users.Admins
{
    partial class AdminStatistic
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
            this.Output = new System.Windows.Forms.RichTextBox();
            this.StatBox = new System.Windows.Forms.ListBox();
            this.BShowStores = new System.Windows.Forms.Button();
            this.BShowUsers = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.BShowProducts = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserStoreID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KindBox = new System.Windows.Forms.ComboBox();
            this.OperationBox = new System.Windows.Forms.ComboBox();
            this.OnWhatBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(550, 49);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(333, 276);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // StatBox
            // 
            this.StatBox.FormattingEnabled = true;
            this.StatBox.ItemHeight = 16;
            this.StatBox.Location = new System.Drawing.Point(44, 49);
            this.StatBox.Name = "StatBox";
            this.StatBox.Size = new System.Drawing.Size(352, 276);
            this.StatBox.TabIndex = 1;
            // 
            // BShowStores
            // 
            this.BShowStores.Location = new System.Drawing.Point(161, 331);
            this.BShowStores.Name = "BShowStores";
            this.BShowStores.Size = new System.Drawing.Size(111, 37);
            this.BShowStores.TabIndex = 4;
            this.BShowStores.Text = "Show Stores";
            this.BShowStores.UseVisualStyleBackColor = true;
            this.BShowStores.Click += new System.EventHandler(this.BShowStores_Click);
            // 
            // BShowUsers
            // 
            this.BShowUsers.Location = new System.Drawing.Point(44, 331);
            this.BShowUsers.Name = "BShowUsers";
            this.BShowUsers.Size = new System.Drawing.Size(111, 37);
            this.BShowUsers.TabIndex = 5;
            this.BShowUsers.Text = "Show Users";
            this.BShowUsers.UseVisualStyleBackColor = true;
            this.BShowUsers.Click += new System.EventHandler(this.BShowUsers_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(368, 510);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(100, 37);
            this.BClose.TabIndex = 10;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(485, 510);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(100, 37);
            this.BExit.TabIndex = 11;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // BShowProducts
            // 
            this.BShowProducts.Location = new System.Drawing.Point(278, 331);
            this.BShowProducts.Name = "BShowProducts";
            this.BShowProducts.Size = new System.Drawing.Size(118, 37);
            this.BShowProducts.TabIndex = 12;
            this.BShowProducts.Text = "Show Products";
            this.BShowProducts.UseVisualStyleBackColor = true;
            this.BShowProducts.Click += new System.EventHandler(this.BShowProducts_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(161, 374);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(111, 37);
            this.BClear.TabIndex = 13;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BProcess
            // 
            this.BProcess.Location = new System.Drawing.Point(664, 465);
            this.BProcess.Name = "BProcess";
            this.BProcess.Size = new System.Drawing.Size(111, 37);
            this.BProcess.TabIndex = 14;
            this.BProcess.Text = "Process";
            this.BProcess.UseVisualStyleBackColor = true;
            this.BProcess.Click += new System.EventHandler(this.BProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choose Operation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Choose kind";
            // 
            // UserStoreID
            // 
            this.UserStoreID.Location = new System.Drawing.Point(702, 437);
            this.UserStoreID.Name = "UserStoreID";
            this.UserStoreID.Size = new System.Drawing.Size(163, 22);
            this.UserStoreID.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter UserID or StoreID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 21;
            // 
            // KindBox
            // 
            this.KindBox.FormattingEnabled = true;
            this.KindBox.Items.AddRange(new object[] {
            "User",
            "Store",
            "Product"});
            this.KindBox.Location = new System.Drawing.Point(702, 338);
            this.KindBox.Name = "KindBox";
            this.KindBox.Size = new System.Drawing.Size(163, 24);
            this.KindBox.TabIndex = 22;
            // 
            // OperationBox
            // 
            this.OperationBox.FormattingEnabled = true;
            this.OperationBox.Items.AddRange(new object[] {
            "Sum",
            "Average",
            "Max",
            "Min"});
            this.OperationBox.Location = new System.Drawing.Point(702, 371);
            this.OperationBox.Name = "OperationBox";
            this.OperationBox.Size = new System.Drawing.Size(163, 24);
            this.OperationBox.TabIndex = 23;
            // 
            // OnWhatBox
            // 
            this.OnWhatBox.FormattingEnabled = true;
            this.OnWhatBox.Items.AddRange(new object[] {
            "All",
            "User",
            "Store",
            "Product"});
            this.OnWhatBox.Location = new System.Drawing.Point(702, 403);
            this.OnWhatBox.Name = "OnWhatBox";
            this.OnWhatBox.Size = new System.Drawing.Size(163, 24);
            this.OnWhatBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "OnWhat";
            // 
            // AdminStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 559);
            this.Controls.Add(this.OnWhatBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OperationBox);
            this.Controls.Add(this.KindBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserStoreID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BProcess);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BShowProducts);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BShowUsers);
            this.Controls.Add(this.BShowStores);
            this.Controls.Add(this.StatBox);
            this.Controls.Add(this.Output);
            this.Name = "AdminStatistic";
            this.Text = "AdminStatistic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.ListBox StatBox;
        private System.Windows.Forms.Button BShowStores;
        private System.Windows.Forms.Button BShowUsers;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BShowProducts;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserStoreID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KindBox;
        private System.Windows.Forms.ComboBox OperationBox;
        private System.Windows.Forms.ComboBox OnWhatBox;
        private System.Windows.Forms.Label label5;
    }
}