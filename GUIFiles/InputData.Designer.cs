namespace OnlineStore.GUIFiles
{
    partial class InputData
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
            this.DataInput = new System.Windows.Forms.Label();
            this.Pricee = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataInput
            // 
            this.DataInput.AutoSize = true;
            this.DataInput.Location = new System.Drawing.Point(40, 30);
            this.DataInput.Name = "DataInput";
            this.DataInput.Size = new System.Drawing.Size(10, 13);
            this.DataInput.TabIndex = 0;
            this.DataInput.Text = "[";
            // 
            // Pricee
            // 
            this.Pricee.Location = new System.Drawing.Point(12, 64);
            this.Pricee.Name = "Pricee";
            this.Pricee.Size = new System.Drawing.Size(100, 20);
            this.Pricee.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(145, 64);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // InputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 158);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Pricee);
            this.Controls.Add(this.DataInput);
            this.Name = "InputData";
            this.Text = "InputData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataInput;
        private System.Windows.Forms.TextBox Pricee;
        private System.Windows.Forms.Button Submit;
    }
}