namespace OnlineStore
{
    partial class loginpage
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
            this.TuserName = new System.Windows.Forms.TextBox();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Blogin = new System.Windows.Forms.Button();
            this.Bback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TuserName
            // 
            this.TuserName.Location = new System.Drawing.Point(128, 36);
            this.TuserName.Name = "TuserName";
            this.TuserName.Size = new System.Drawing.Size(184, 22);
            this.TuserName.TabIndex = 12;
            // 
            // Tpassword
            // 
            this.Tpassword.Location = new System.Drawing.Point(128, 69);
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.Size = new System.Drawing.Size(184, 22);
            this.Tpassword.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Blogin
            // 
            this.Blogin.Location = new System.Drawing.Point(55, 114);
            this.Blogin.Margin = new System.Windows.Forms.Padding(4);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(100, 28);
            this.Blogin.TabIndex = 8;
            this.Blogin.Text = "Login";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // Bback
            // 
            this.Bback.Location = new System.Drawing.Point(163, 114);
            this.Bback.Margin = new System.Windows.Forms.Padding(4);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(100, 28);
            this.Bback.TabIndex = 10;
            this.Bback.Text = "Back";
            this.Bback.UseVisualStyleBackColor = true;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 163);
            this.Controls.Add(this.Bback);
            this.Controls.Add(this.Blogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.TuserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginpage";
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TuserName;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Blogin;
        private System.Windows.Forms.Button Bback;
    }
}