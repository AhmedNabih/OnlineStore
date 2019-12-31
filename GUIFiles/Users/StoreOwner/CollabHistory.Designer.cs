namespace OnlineStore.GUIFiles.Users.StoreOwner
{
    partial class CollabHistory
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
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.BUndo = new System.Windows.Forms.Button();
            this.Bclose = new System.Windows.Forms.Button();
            this.BShowStoreHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryList
            // 
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.ItemHeight = 16;
            this.HistoryList.Location = new System.Drawing.Point(35, 24);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(1108, 292);
            this.HistoryList.TabIndex = 50;
            // 
            // BUndo
            // 
            this.BUndo.Location = new System.Drawing.Point(511, 323);
            this.BUndo.Margin = new System.Windows.Forms.Padding(4);
            this.BUndo.Name = "BUndo";
            this.BUndo.Size = new System.Drawing.Size(120, 44);
            this.BUndo.TabIndex = 61;
            this.BUndo.Text = "Undo";
            this.BUndo.UseVisualStyleBackColor = true;
            this.BUndo.Click += new System.EventHandler(this.BUndo_Click);
            // 
            // Bclose
            // 
            this.Bclose.Location = new System.Drawing.Point(997, 403);
            this.Bclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(115, 23);
            this.Bclose.TabIndex = 62;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = true;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // BShowStoreHistory
            // 
            this.BShowStoreHistory.Location = new System.Drawing.Point(70, 331);
            this.BShowStoreHistory.Margin = new System.Windows.Forms.Padding(4);
            this.BShowStoreHistory.Name = "BShowStoreHistory";
            this.BShowStoreHistory.Size = new System.Drawing.Size(326, 28);
            this.BShowStoreHistory.TabIndex = 68;
            this.BShowStoreHistory.Text = "Show Store History";
            this.BShowStoreHistory.UseVisualStyleBackColor = true;
            this.BShowStoreHistory.Click += new System.EventHandler(this.BShowStoreHistory_Click);
            // 
            // CollabHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 437);
            this.Controls.Add(this.BShowStoreHistory);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.BUndo);
            this.Controls.Add(this.HistoryList);
            this.Name = "CollabHistory";
            this.Text = "CollabHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.Button BUndo;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Button BShowStoreHistory;
    }
}