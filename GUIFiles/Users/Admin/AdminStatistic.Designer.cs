namespace OnlineStore.GUIFiles
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
            this.RBOutput = new System.Windows.Forms.RichTextBox();
            this.StatBox = new System.Windows.Forms.ListBox();
            this.BShowStores = new System.Windows.Forms.Button();
            this.BShowUsers = new System.Windows.Forms.Button();
            this.BMax = new System.Windows.Forms.Button();
            this.BMin = new System.Windows.Forms.Button();
            this.BAverage = new System.Windows.Forms.Button();
            this.BSum = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.BShowProducts = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RBOutput
            // 
            this.RBOutput.Location = new System.Drawing.Point(432, 82);
            this.RBOutput.Name = "RBOutput";
            this.RBOutput.ReadOnly = true;
            this.RBOutput.Size = new System.Drawing.Size(333, 276);
            this.RBOutput.TabIndex = 0;
            this.RBOutput.Text = "";
            // 
            // StatBox
            // 
            this.StatBox.FormattingEnabled = true;
            this.StatBox.ItemHeight = 16;
            this.StatBox.Location = new System.Drawing.Point(39, 82);
            this.StatBox.Name = "StatBox";
            this.StatBox.Size = new System.Drawing.Size(352, 276);
            this.StatBox.TabIndex = 1;
            // 
            // BShowStores
            // 
            this.BShowStores.Location = new System.Drawing.Point(156, 364);
            this.BShowStores.Name = "BShowStores";
            this.BShowStores.Size = new System.Drawing.Size(111, 37);
            this.BShowStores.TabIndex = 4;
            this.BShowStores.Text = "Show Stores";
            this.BShowStores.UseVisualStyleBackColor = true;
            this.BShowStores.Click += new System.EventHandler(this.BShowStores_Click);
            // 
            // BShowUsers
            // 
            this.BShowUsers.Location = new System.Drawing.Point(39, 364);
            this.BShowUsers.Name = "BShowUsers";
            this.BShowUsers.Size = new System.Drawing.Size(111, 37);
            this.BShowUsers.TabIndex = 5;
            this.BShowUsers.Text = "Show Users";
            this.BShowUsers.UseVisualStyleBackColor = true;
            this.BShowUsers.Click += new System.EventHandler(this.BShowUsers_Click);
            // 
            // BMax
            // 
            this.BMax.Location = new System.Drawing.Point(502, 407);
            this.BMax.Name = "BMax";
            this.BMax.Size = new System.Drawing.Size(100, 37);
            this.BMax.TabIndex = 6;
            this.BMax.Text = "Max";
            this.BMax.UseVisualStyleBackColor = true;
            this.BMax.Click += new System.EventHandler(this.BMax_Click);
            // 
            // BMin
            // 
            this.BMin.Location = new System.Drawing.Point(608, 407);
            this.BMin.Name = "BMin";
            this.BMin.Size = new System.Drawing.Size(100, 37);
            this.BMin.TabIndex = 7;
            this.BMin.Text = "Min";
            this.BMin.UseVisualStyleBackColor = true;
            this.BMin.Click += new System.EventHandler(this.BMin_Click);
            // 
            // BAverage
            // 
            this.BAverage.Location = new System.Drawing.Point(608, 364);
            this.BAverage.Name = "BAverage";
            this.BAverage.Size = new System.Drawing.Size(100, 37);
            this.BAverage.TabIndex = 8;
            this.BAverage.Text = "Average";
            this.BAverage.UseVisualStyleBackColor = true;
            this.BAverage.Click += new System.EventHandler(this.BAverage_Click);
            // 
            // BSum
            // 
            this.BSum.Location = new System.Drawing.Point(502, 364);
            this.BSum.Name = "BSum";
            this.BSum.Size = new System.Drawing.Size(100, 37);
            this.BSum.TabIndex = 9;
            this.BSum.Text = "Sum";
            this.BSum.UseVisualStyleBackColor = true;
            this.BSum.Click += new System.EventHandler(this.BSum_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(291, 482);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(100, 37);
            this.BClose.TabIndex = 10;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(408, 482);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(100, 37);
            this.BExit.TabIndex = 11;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // BShowProducts
            // 
            this.BShowProducts.Location = new System.Drawing.Point(273, 364);
            this.BShowProducts.Name = "BShowProducts";
            this.BShowProducts.Size = new System.Drawing.Size(118, 37);
            this.BShowProducts.TabIndex = 12;
            this.BShowProducts.Text = "Show Products";
            this.BShowProducts.UseVisualStyleBackColor = true;
            this.BShowProducts.Click += new System.EventHandler(this.BShowProducts_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(156, 407);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(111, 37);
            this.BClear.TabIndex = 13;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // AdminStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 559);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BShowProducts);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BSum);
            this.Controls.Add(this.BAverage);
            this.Controls.Add(this.BMin);
            this.Controls.Add(this.BMax);
            this.Controls.Add(this.BShowUsers);
            this.Controls.Add(this.BShowStores);
            this.Controls.Add(this.StatBox);
            this.Controls.Add(this.RBOutput);
            this.Name = "AdminStatistic";
            this.Text = "AdminStatistic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RBOutput;
        private System.Windows.Forms.ListBox StatBox;
        private System.Windows.Forms.Button BShowStores;
        private System.Windows.Forms.Button BShowUsers;
        private System.Windows.Forms.Button BMax;
        private System.Windows.Forms.Button BMin;
        private System.Windows.Forms.Button BAverage;
        private System.Windows.Forms.Button BSum;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BShowProducts;
        private System.Windows.Forms.Button BClear;
    }
}