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
            this.SuspendLayout();
            // 
            // LCollaboratorsList
            // 
            this.LCollaboratorsList.AutoSize = true;
            this.LCollaboratorsList.Location = new System.Drawing.Point(211, 40);
            this.LCollaboratorsList.Name = "LCollaboratorsList";
            this.LCollaboratorsList.Size = new System.Drawing.Size(118, 17);
            this.LCollaboratorsList.TabIndex = 71;
            this.LCollaboratorsList.Text = "Collaborators List";
            // 
            // CollaboratorsList
            // 
            this.CollaboratorsList.FormattingEnabled = true;
            this.CollaboratorsList.ItemHeight = 16;
            this.CollaboratorsList.Location = new System.Drawing.Point(203, 71);
            this.CollaboratorsList.Name = "CollaboratorsList";
            this.CollaboratorsList.Size = new System.Drawing.Size(550, 260);
            this.CollaboratorsList.TabIndex = 70;
            // 
            // BEditCollaborator
            // 
            this.BEditCollaborator.Location = new System.Drawing.Point(76, 179);
            this.BEditCollaborator.Margin = new System.Windows.Forms.Padding(4);
            this.BEditCollaborator.Name = "BEditCollaborator";
            this.BEditCollaborator.Size = new System.Drawing.Size(120, 44);
            this.BEditCollaborator.TabIndex = 69;
            this.BEditCollaborator.Text = "Edit Collaborator";
            this.BEditCollaborator.UseVisualStyleBackColor = true;
            // 
            // BDeleteCollaborator
            // 
            this.BDeleteCollaborator.Location = new System.Drawing.Point(76, 231);
            this.BDeleteCollaborator.Margin = new System.Windows.Forms.Padding(4);
            this.BDeleteCollaborator.Name = "BDeleteCollaborator";
            this.BDeleteCollaborator.Size = new System.Drawing.Size(120, 44);
            this.BDeleteCollaborator.TabIndex = 68;
            this.BDeleteCollaborator.Text = "Delete Collaborator";
            this.BDeleteCollaborator.UseVisualStyleBackColor = true;
            // 
            // BAddCollaborator
            // 
            this.BAddCollaborator.Location = new System.Drawing.Point(76, 127);
            this.BAddCollaborator.Margin = new System.Windows.Forms.Padding(4);
            this.BAddCollaborator.Name = "BAddCollaborator";
            this.BAddCollaborator.Size = new System.Drawing.Size(120, 44);
            this.BAddCollaborator.TabIndex = 67;
            this.BAddCollaborator.Text = "Add Collaborator";
            this.BAddCollaborator.UseVisualStyleBackColor = true;
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(316, 381);
            this.BClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(115, 23);
            this.BClose.TabIndex = 72;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            // 
            // CollaboratorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 415);
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
    }
}