namespace Electric_billing_system
{
    partial class Customer_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Menu));
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Account_Settings_pic = new System.Windows.Forms.PictureBox();
            this.Pay_Bills_pic = new System.Windows.Forms.PictureBox();
            this.Print_Invoices_Pic = new System.Windows.Forms.PictureBox();
            this.Pay_Bills_label = new System.Windows.Forms.Label();
            this.Print_Invoices_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Account_Settings_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pay_Bills_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Print_Invoices_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(11, 19);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(105, 39);
            this.Welcome_label.TabIndex = 2;
            this.Welcome_label.Text = "Hello ";
            // 
            // Account_Settings_pic
            // 
            this.Account_Settings_pic.Image = ((System.Drawing.Image)(resources.GetObject("Account_Settings_pic.Image")));
            this.Account_Settings_pic.Location = new System.Drawing.Point(646, 12);
            this.Account_Settings_pic.Name = "Account_Settings_pic";
            this.Account_Settings_pic.Size = new System.Drawing.Size(53, 55);
            this.Account_Settings_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Account_Settings_pic.TabIndex = 7;
            this.Account_Settings_pic.TabStop = false;
            this.Account_Settings_pic.Click += new System.EventHandler(this.Account_Settings_pic_Click);
            // 
            // Pay_Bills_pic
            // 
            this.Pay_Bills_pic.Image = ((System.Drawing.Image)(resources.GetObject("Pay_Bills_pic.Image")));
            this.Pay_Bills_pic.Location = new System.Drawing.Point(171, 157);
            this.Pay_Bills_pic.Name = "Pay_Bills_pic";
            this.Pay_Bills_pic.Size = new System.Drawing.Size(89, 92);
            this.Pay_Bills_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pay_Bills_pic.TabIndex = 8;
            this.Pay_Bills_pic.TabStop = false;
            this.Pay_Bills_pic.Click += new System.EventHandler(this.Pay_Bills_pic_Click);
            // 
            // Print_Invoices_Pic
            // 
            this.Print_Invoices_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Print_Invoices_Pic.Image")));
            this.Print_Invoices_Pic.Location = new System.Drawing.Point(459, 157);
            this.Print_Invoices_Pic.Name = "Print_Invoices_Pic";
            this.Print_Invoices_Pic.Size = new System.Drawing.Size(89, 92);
            this.Print_Invoices_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Print_Invoices_Pic.TabIndex = 9;
            this.Print_Invoices_Pic.TabStop = false;
            this.Print_Invoices_Pic.Click += new System.EventHandler(this.Print_Invoices_Pic_Click);
            // 
            // Pay_Bills_label
            // 
            this.Pay_Bills_label.AutoSize = true;
            this.Pay_Bills_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_Bills_label.ForeColor = System.Drawing.Color.White;
            this.Pay_Bills_label.Location = new System.Drawing.Point(157, 270);
            this.Pay_Bills_label.Name = "Pay_Bills_label";
            this.Pay_Bills_label.Size = new System.Drawing.Size(118, 31);
            this.Pay_Bills_label.TabIndex = 10;
            this.Pay_Bills_label.Text = "Pay Bills";
            this.Pay_Bills_label.Click += new System.EventHandler(this.Pay_Bills_label_Click);
            // 
            // Print_Invoices_label
            // 
            this.Print_Invoices_label.AutoSize = true;
            this.Print_Invoices_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Invoices_label.ForeColor = System.Drawing.Color.White;
            this.Print_Invoices_label.Location = new System.Drawing.Point(423, 270);
            this.Print_Invoices_label.Name = "Print_Invoices_label";
            this.Print_Invoices_label.Size = new System.Drawing.Size(178, 31);
            this.Print_Invoices_label.TabIndex = 11;
            this.Print_Invoices_label.Text = "Print Invoices";
            this.Print_Invoices_label.Click += new System.EventHandler(this.Print_Invoices_label_Click);
            // 
            // Customer_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.Print_Invoices_label);
            this.Controls.Add(this.Pay_Bills_label);
            this.Controls.Add(this.Print_Invoices_Pic);
            this.Controls.Add(this.Pay_Bills_pic);
            this.Controls.Add(this.Account_Settings_pic);
            this.Controls.Add(this.Welcome_label);
            this.Name = "Customer_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Menu";
            this.Load += new System.EventHandler(this.Customer_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Account_Settings_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pay_Bills_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Print_Invoices_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.PictureBox Account_Settings_pic;
        private System.Windows.Forms.PictureBox Pay_Bills_pic;
        private System.Windows.Forms.PictureBox Print_Invoices_Pic;
        private System.Windows.Forms.Label Pay_Bills_label;
        private System.Windows.Forms.Label Print_Invoices_label;
    }
}