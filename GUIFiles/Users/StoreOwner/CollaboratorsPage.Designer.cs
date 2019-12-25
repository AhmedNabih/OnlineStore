namespace OnlineStore.GUIFiles.Users.StoreOwner
{
    partial class CollaboratorsPage
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
            this.LCollaboratorsList = new System.Windows.Forms.Label();
            this.CollaboratorsList = new System.Windows.Forms.ListBox();
            this.BEditCollaborator = new System.Windows.Forms.Button();
            this.BDeleteCollaborator = new System.Windows.Forms.Button();
            this.BAddCollaborator = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.BShowCollaborator = new System.Windows.Forms.Button();
            this.TUserID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LCollaboratorsList
            // 
            this.LCollaboratorsList.AutoSize = true;
            this.LCollaboratorsList.Location = new System.Drawing.Point(144, 13);
            this.LCollaboratorsList.Name = "LCollaboratorsList";
            this.LCollaboratorsList.Size = new System.Drawing.Size(118, 17);
            this.LCollaboratorsList.TabIndex = 71;
            this.LCollaboratorsList.Text = "Collaborators List";
            // 
            // CollaboratorsList
            // 
            this.CollaboratorsList.FormattingEnabled = true;
            this.CollaboratorsList.ItemHeight = 16;
            this.CollaboratorsList.Location = new System.Drawing.Point(136, 44);
            this.CollaboratorsList.Name = "CollaboratorsList";
            this.CollaboratorsList.Size = new System.Drawing.Size(550, 260);
            this.CollaboratorsList.TabIndex = 70;
            // 
            // BEditCollaborator
            // 
            this.BEditCollaborator.Location = new System.Drawing.Point(9, 151);
            this.BEditCollaborator.Margin = new System.Windows.Forms.Padding(4);
            this.BEditCollaborator.Name = "BEditCollaborator";
            this.BEditCollaborator.Size = new System.Drawing.Size(120, 44);
            this.BEditCollaborator.TabIndex = 69;
            this.BEditCollaborator.Text = "Edit Collaborator";
            this.BEditCollaborator.UseVisualStyleBackColor = true;
            this.BEditCollaborator.Click += new System.EventHandler(this.BEditCollaborator_Click);
            // 
            // BDeleteCollaborator
            // 
            this.BDeleteCollaborator.Location = new System.Drawing.Point(9, 203);
            this.BDeleteCollaborator.Margin = new System.Windows.Forms.Padding(4);
            this.BDeleteCollaborator.Name = "BDeleteCollaborator";
            this.BDeleteCollaborator.Size = new System.Drawing.Size(120, 44);
            this.BDeleteCollaborator.TabIndex = 68;
            this.BDeleteCollaborator.Text = "Delete Collaborator";
            this.BDeleteCollaborator.UseVisualStyleBackColor = true;
            this.BDeleteCollaborator.Click += new System.EventHandler(this.BDeleteCollaborator_Click);
            // 
            // BAddCollaborator
            // 
            this.BAddCollaborator.Location = new System.Drawing.Point(13, 320);
            this.BAddCollaborator.Margin = new System.Windows.Forms.Padding(4);
            this.BAddCollaborator.Name = "BAddCollaborator";
            this.BAddCollaborator.Size = new System.Drawing.Size(120, 44);
            this.BAddCollaborator.TabIndex = 67;
            this.BAddCollaborator.Text = "Add Collaborator";
            this.BAddCollaborator.UseVisualStyleBackColor = true;
            this.BAddCollaborator.Click += new System.EventHandler(this.BAddCollaborator_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(280, 350);
            this.BClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(115, 23);
            this.BClose.TabIndex = 72;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BShowCollaborator
            // 
            this.BShowCollaborator.Location = new System.Drawing.Point(9, 99);
            this.BShowCollaborator.Margin = new System.Windows.Forms.Padding(4);
            this.BShowCollaborator.Name = "BShowCollaborator";
            this.BShowCollaborator.Size = new System.Drawing.Size(120, 44);
            this.BShowCollaborator.TabIndex = 73;
            this.BShowCollaborator.Text = "Show Collaborator";
            this.BShowCollaborator.UseVisualStyleBackColor = true;
            this.BShowCollaborator.Click += new System.EventHandler(this.BShowCollaborator_Click);
            // 
            // TUserID
            // 
            this.TUserID.Location = new System.Drawing.Point(140, 331);
            this.TUserID.Name = "TUserID";
            this.TUserID.Size = new System.Drawing.Size(109, 22);
            this.TUserID.TabIndex = 74;
            // 
            // CollaboratorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 384);
            this.Controls.Add(this.TUserID);
            this.Controls.Add(this.BShowCollaborator);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.LCollaboratorsList);
            this.Controls.Add(this.CollaboratorsList);
            this.Controls.Add(this.BEditCollaborator);
            this.Controls.Add(this.BDeleteCollaborator);
            this.Controls.Add(this.BAddCollaborator);
            this.Name = "CollaboratorsPage";
            this.Text = "CollaboratorsPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCollaboratorsList;
        private System.Windows.Forms.ListBox CollaboratorsList;
        private System.Windows.Forms.Button BEditCollaborator;
        private System.Windows.Forms.Button BDeleteCollaborator;
        private System.Windows.Forms.Button BAddCollaborator;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BShowCollaborator;
        private System.Windows.Forms.TextBox TUserID;
    }
}