namespace OnlineStore.GUIFiles
{
    partial class addStorePage
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
            this.StoreName = new System.Windows.Forms.TextBox();
            this.StoreType = new System.Windows.Forms.TextBox();
            this.StoreInfo = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Bclose = new System.Windows.Forms.Button();
            this.StoreLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StoreName
            // 
            this.StoreName.Location = new System.Drawing.Point(119, 21);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(186, 22);
            this.StoreName.TabIndex = 0;
            // 
            // StoreType
            // 
            this.StoreType.Location = new System.Drawing.Point(119, 77);
            this.StoreType.Name = "StoreType";
            this.StoreType.Size = new System.Drawing.Size(186, 22);
            this.StoreType.TabIndex = 2;
            // 
            // StoreInfo
            // 
            this.StoreInfo.Location = new System.Drawing.Point(119, 105);
            this.StoreInfo.Name = "StoreInfo";
            this.StoreInfo.Size = new System.Drawing.Size(186, 22);
            this.StoreInfo.TabIndex = 3;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(30, 24);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(83, 17);
            this.Lname.TabIndex = 4;
            this.Lname.Text = "Store Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Store type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Info";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(54, 140);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(102, 23);
            this.Submit.TabIndex = 9;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Bclose
            // 
            this.Bclose.Location = new System.Drawing.Point(172, 140);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(102, 23);
            this.Bclose.TabIndex = 10;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = true;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // StoreLocation
            // 
            this.StoreLocation.FormattingEnabled = true;
            this.StoreLocation.Items.AddRange(new object[] {
            "Online",
            "Onsite"});
            this.StoreLocation.Location = new System.Drawing.Point(119, 47);
            this.StoreLocation.Name = "StoreLocation";
            this.StoreLocation.Size = new System.Drawing.Size(186, 24);
            this.StoreLocation.TabIndex = 11;
            // 
            // addStorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 175);
            this.Controls.Add(this.StoreLocation);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.StoreInfo);
            this.Controls.Add(this.StoreType);
            this.Controls.Add(this.StoreName);
            this.Name = "addStorePage";
            this.Text = "addStorePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StoreName;
        private System.Windows.Forms.TextBox StoreType;
        private System.Windows.Forms.TextBox StoreInfo;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.ComboBox StoreLocation;
    }
}