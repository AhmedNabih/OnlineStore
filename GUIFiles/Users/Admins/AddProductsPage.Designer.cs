namespace OnlineStore.GUIFiles.Users.Admins
{
    partial class AddProductsPage
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
            this.TProductName = new System.Windows.Forms.TextBox();
            this.LProductName = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ClearText = new System.Windows.Forms.Button();
            this.Bclose = new System.Windows.Forms.Button();
            this.LProductType = new System.Windows.Forms.Label();
            this.TProductType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TProductName
            // 
            this.TProductName.Location = new System.Drawing.Point(142, 73);
            this.TProductName.Name = "TProductName";
            this.TProductName.Size = new System.Drawing.Size(170, 22);
            this.TProductName.TabIndex = 1;
            // 
            // LProductName
            // 
            this.LProductName.AutoSize = true;
            this.LProductName.Location = new System.Drawing.Point(43, 76);
            this.LProductName.Name = "LProductName";
            this.LProductName.Size = new System.Drawing.Size(98, 17);
            this.LProductName.TabIndex = 5;
            this.LProductName.Text = "Product Name";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(231, 169);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(105, 33);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ClearText
            // 
            this.ClearText.Location = new System.Drawing.Point(120, 169);
            this.ClearText.Name = "ClearText";
            this.ClearText.Size = new System.Drawing.Size(105, 33);
            this.ClearText.TabIndex = 7;
            this.ClearText.Text = "Clear Text";
            this.ClearText.UseVisualStyleBackColor = true;
            this.ClearText.Click += new System.EventHandler(this.ClearText_Click);
            // 
            // Bclose
            // 
            this.Bclose.Location = new System.Drawing.Point(9, 169);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(105, 33);
            this.Bclose.TabIndex = 8;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = true;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // LProductType
            // 
            this.LProductType.AutoSize = true;
            this.LProductType.Location = new System.Drawing.Point(43, 104);
            this.LProductType.Name = "LProductType";
            this.LProductType.Size = new System.Drawing.Size(93, 17);
            this.LProductType.TabIndex = 10;
            this.LProductType.Text = "Product Type";
            // 
            // TProductType
            // 
            this.TProductType.Location = new System.Drawing.Point(142, 101);
            this.TProductType.Name = "TProductType";
            this.TProductType.Size = new System.Drawing.Size(170, 22);
            this.TProductType.TabIndex = 9;
            // 
            // AddProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 229);
            this.Controls.Add(this.LProductType);
            this.Controls.Add(this.TProductType);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.ClearText);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.LProductName);
            this.Controls.Add(this.TProductName);
            this.Name = "AddProductsPage";
            this.Text = "AddProductPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TProductName;
        private System.Windows.Forms.Label LProductName;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button ClearText;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Label LProductType;
        private System.Windows.Forms.TextBox TProductType;
    }
}