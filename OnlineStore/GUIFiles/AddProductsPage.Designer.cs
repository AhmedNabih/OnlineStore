namespace OnlineStore.GUIFiles
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
            this.TbrandName = new System.Windows.Forms.TextBox();
            this.Tname = new System.Windows.Forms.TextBox();
            this.TbrandType = new System.Windows.Forms.TextBox();
            this.LbrandName = new System.Windows.Forms.Label();
            this.LbrandType = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ClearText = new System.Windows.Forms.Button();
            this.Bclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbrandName
            // 
            this.TbrandName.Location = new System.Drawing.Point(134, 25);
            this.TbrandName.Name = "TbrandName";
            this.TbrandName.Size = new System.Drawing.Size(170, 22);
            this.TbrandName.TabIndex = 0;
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(134, 81);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(170, 22);
            this.Tname.TabIndex = 1;
            // 
            // TbrandType
            // 
            this.TbrandType.Location = new System.Drawing.Point(134, 53);
            this.TbrandType.Name = "TbrandType";
            this.TbrandType.Size = new System.Drawing.Size(170, 22);
            this.TbrandType.TabIndex = 2;
            // 
            // LbrandName
            // 
            this.LbrandName.AutoSize = true;
            this.LbrandName.Location = new System.Drawing.Point(35, 30);
            this.LbrandName.Name = "LbrandName";
            this.LbrandName.Size = new System.Drawing.Size(87, 17);
            this.LbrandName.TabIndex = 3;
            this.LbrandName.Text = "Brand Name";
            // 
            // LbrandType
            // 
            this.LbrandType.AutoSize = true;
            this.LbrandType.Location = new System.Drawing.Point(35, 56);
            this.LbrandType.Name = "LbrandType";
            this.LbrandType.Size = new System.Drawing.Size(82, 17);
            this.LbrandType.TabIndex = 4;
            this.LbrandType.Text = "Brand Type";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(55, 86);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(45, 17);
            this.Lname.TabIndex = 5;
            this.Lname.Text = "Name";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(231, 119);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(105, 33);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ClearText
            // 
            this.ClearText.Location = new System.Drawing.Point(120, 119);
            this.ClearText.Name = "ClearText";
            this.ClearText.Size = new System.Drawing.Size(105, 33);
            this.ClearText.TabIndex = 7;
            this.ClearText.Text = "Clear Text";
            this.ClearText.UseVisualStyleBackColor = true;
            this.ClearText.Click += new System.EventHandler(this.ClearText_Click);
            // 
            // Bclose
            // 
            this.Bclose.Location = new System.Drawing.Point(9, 119);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(105, 33);
            this.Bclose.TabIndex = 8;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = true;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // AddProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 164);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.ClearText);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.LbrandType);
            this.Controls.Add(this.LbrandName);
            this.Controls.Add(this.TbrandType);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.TbrandName);
            this.Name = "AddProductsPage";
            this.Text = "AddProductPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbrandName;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.TextBox TbrandType;
        private System.Windows.Forms.Label LbrandName;
        private System.Windows.Forms.Label LbrandType;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button ClearText;
        private System.Windows.Forms.Button Bclose;
    }
}