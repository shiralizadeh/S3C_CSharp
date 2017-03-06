namespace S3C_CSharp
{
    partial class frmMain
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
            this.btnAlert = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(635, 74);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(75, 23);
            this.btnAlert.TabIndex = 0;
            this.btnAlert.Text = "پیام";
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(588, 48);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(162, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(287, 45);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(128, 23);
            this.btnNewProduct.TabIndex = 2;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "New Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add To M";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 365);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAlert);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}