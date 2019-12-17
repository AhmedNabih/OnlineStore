namespace OnlineStore.GUIFiles.Users.Admins
{
    partial class AddBrandPage
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
            this.LBrandType = new System.Windows.Forms.Label();
            this.TBrandType = new System.Windows.Forms.TextBox();
            this.Bclose = new System.Windows.Forms.Button();
            this.ClearText = new System.Windows.Forms.Button();
            this.AddBrand = new System.Windows.Forms.Button();
            this.LBrandName = new System.Windows.Forms.Label();
            this.TBrandName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBrandType
            // 
            this.LBrandType.AutoSize = true;
            this.LBrandType.Location = new System.Drawing.Point(65, 134);
            this.LBrandType.Name = "LBrandType";
            this.LBrandType.Size = new System.Drawing.Size(82, 17);
            this.LBrandType.TabIndex = 17;
            this.LBrandType.Text = "Brand Type";
            // 
            // TBrandType
            // 
            this.TBrandType.Location = new System.Drawing.Point(164, 131);
            this.TBrandType.Name = "TBrandType";
            this.TBrandType.Size = new System.Drawing.Size(170, 22);
            this.TBrandType.TabIndex = 16;
            // 
            // Bclose
            // 
            this.Bclose.Location = new System.Drawing.Point(31, 199);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(105, 33);
            this.Bclose.TabIndex = 15;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = true;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // ClearText
            // 
            this.ClearText.Location = new System.Drawing.Point(142, 199);
            this.ClearText.Name = "ClearText";
            this.ClearText.Size = new System.Drawing.Size(105, 33);
            this.ClearText.TabIndex = 14;
            this.ClearText.Text = "Clear Text";
            this.ClearText.UseVisualStyleBackColor = true;
            this.ClearText.Click += new System.EventHandler(this.ClearText_Click);
            // 
            // AddBrand
            // 
            this.AddBrand.Location = new System.Drawing.Point(253, 199);
            this.AddBrand.Name = "AddBrand";
            this.AddBrand.Size = new System.Drawing.Size(105, 33);
            this.AddBrand.TabIndex = 13;
            this.AddBrand.Text = "Add Brand";
            this.AddBrand.UseVisualStyleBackColor = true;
            this.AddBrand.Click += new System.EventHandler(this.AddBrand_Click);
            // 
            // LBrandName
            // 
            this.LBrandName.AutoSize = true;
            this.LBrandName.Location = new System.Drawing.Point(65, 106);
            this.LBrandName.Name = "LBrandName";
            this.LBrandName.Size = new System.Drawing.Size(87, 17);
            this.LBrandName.TabIndex = 12;
            this.LBrandName.Text = "Brand Name";
            // 
            // TBrandName
            // 
            this.TBrandName.Location = new System.Drawing.Point(164, 103);
            this.TBrandName.Name = "TBrandName";
            this.TBrandName.Size = new System.Drawing.Size(170, 22);
            this.TBrandName.TabIndex = 11;
            // 
            // AddBrandPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.LBrandType);
            this.Controls.Add(this.TBrandType);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.ClearText);
            this.Controls.Add(this.AddBrand);
            this.Controls.Add(this.LBrandName);
            this.Controls.Add(this.TBrandName);
            this.Name = "AddBrandPage";
            this.Text = "AddBrandPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBrandType;
        private System.Windows.Forms.TextBox TBrandType;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Button ClearText;
        private System.Windows.Forms.Button AddBrand;
        private System.Windows.Forms.Label LBrandName;
        private System.Windows.Forms.TextBox TBrandName;
    }
}