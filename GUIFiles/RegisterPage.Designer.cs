namespace OnlineStore.GUIFiles
{
    partial class RegisterPage
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
            this.Bback = new System.Windows.Forms.Button();
            this.Bregister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Temail = new System.Windows.Forms.TextBox();
            this.Tname = new System.Windows.Forms.TextBox();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.TuserName = new System.Windows.Forms.TextBox();
            this.Trole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bback
            // 
            this.Bback.Location = new System.Drawing.Point(499, 336);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(75, 23);
            this.Bback.TabIndex = 19;
            this.Bback.Text = "Back";
            this.Bback.UseVisualStyleBackColor = true;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // Bregister
            // 
            this.Bregister.Location = new System.Drawing.Point(309, 336);
            this.Bregister.Name = "Bregister";
            this.Bregister.Size = new System.Drawing.Size(75, 23);
            this.Bregister.TabIndex = 18;
            this.Bregister.Text = "Register";
            this.Bregister.UseVisualStyleBackColor = true;
            this.Bregister.Click += new System.EventHandler(this.Bregister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // Temail
            // 
            this.Temail.Location = new System.Drawing.Point(570, 211);
            this.Temail.Name = "Temail";
            this.Temail.Size = new System.Drawing.Size(100, 22);
            this.Temail.TabIndex = 13;
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(197, 213);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(100, 22);
            this.Tname.TabIndex = 12;
            // 
            // Tpassword
            // 
            this.Tpassword.Location = new System.Drawing.Point(556, 96);
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.Size = new System.Drawing.Size(100, 22);
            this.Tpassword.TabIndex = 11;
            // 
            // TuserName
            // 
            this.TuserName.Location = new System.Drawing.Point(210, 96);
            this.TuserName.Name = "TuserName";
            this.TuserName.Size = new System.Drawing.Size(100, 22);
            this.TuserName.TabIndex = 10;
            // 
            // Trole
            // 
            this.Trole.FormattingEnabled = true;
            this.Trole.Items.AddRange(new object[] {
            "NormalUser",
            "StoreOwner"});
            this.Trole.Location = new System.Drawing.Point(351, 164);
            this.Trole.Name = "Trole";
            this.Trole.Size = new System.Drawing.Size(121, 24);
            this.Trole.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Choose Role";
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Trole);
            this.Controls.Add(this.Bback);
            this.Controls.Add(this.Bregister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Temail);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.TuserName);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bback;
        private System.Windows.Forms.Button Bregister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.TextBox TuserName;
        private System.Windows.Forms.ComboBox Trole;
        private System.Windows.Forms.Label label5;
    }
}