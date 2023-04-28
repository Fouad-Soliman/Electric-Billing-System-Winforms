
namespace Electric_billing_system
{
    partial class Welcome_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Form));
            this.Welcome_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_pic = new System.Windows.Forms.PictureBox();
            this.Customer_pic = new System.Windows.Forms.PictureBox();
            this.Admin_login = new System.Windows.Forms.Label();
            this.Customer_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(50, 23);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(700, 52);
            this.Welcome_label.TabIndex = 0;
            this.Welcome_label.Text = "Welcome To Electric billing system";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login As";
            // 
            // Admin_pic
            // 
            this.Admin_pic.Image = ((System.Drawing.Image)(resources.GetObject("Admin_pic.Image")));
            this.Admin_pic.Location = new System.Drawing.Point(139, 160);
            this.Admin_pic.Name = "Admin_pic";
            this.Admin_pic.Size = new System.Drawing.Size(194, 163);
            this.Admin_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Admin_pic.TabIndex = 2;
            this.Admin_pic.TabStop = false;
            this.Admin_pic.Click += new System.EventHandler(this.Admin_pic_Click);
            // 
            // Customer_pic
            // 
            this.Customer_pic.Image = ((System.Drawing.Image)(resources.GetObject("Customer_pic.Image")));
            this.Customer_pic.Location = new System.Drawing.Point(456, 160);
            this.Customer_pic.Name = "Customer_pic";
            this.Customer_pic.Size = new System.Drawing.Size(194, 163);
            this.Customer_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Customer_pic.TabIndex = 3;
            this.Customer_pic.TabStop = false;
            this.Customer_pic.Click += new System.EventHandler(this.Customer_pic_Click);
            // 
            // Admin_login
            // 
            this.Admin_login.AutoSize = true;
            this.Admin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_login.ForeColor = System.Drawing.Color.White;
            this.Admin_login.Location = new System.Drawing.Point(195, 342);
            this.Admin_login.Name = "Admin_login";
            this.Admin_login.Size = new System.Drawing.Size(90, 31);
            this.Admin_login.TabIndex = 4;
            this.Admin_login.Text = "Admin";
            this.Admin_login.Click += new System.EventHandler(this.Admin_login_Click);
            // 
            // Customer_label
            // 
            this.Customer_label.AutoSize = true;
            this.Customer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_label.ForeColor = System.Drawing.Color.White;
            this.Customer_label.Location = new System.Drawing.Point(486, 342);
            this.Customer_label.Name = "Customer_label";
            this.Customer_label.Size = new System.Drawing.Size(132, 31);
            this.Customer_label.TabIndex = 5;
            this.Customer_label.Text = "Customer";
            this.Customer_label.Click += new System.EventHandler(this.Customer_label_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Customer_label);
            this.Controls.Add(this.Admin_login);
            this.Controls.Add(this.Customer_pic);
            this.Controls.Add(this.Admin_pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome_label);
            this.Name = "Welcome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrical Billing System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Admin_pic;
        private System.Windows.Forms.PictureBox Customer_pic;
        private System.Windows.Forms.Label Admin_login;
        private System.Windows.Forms.Label Customer_label;
    }
}

