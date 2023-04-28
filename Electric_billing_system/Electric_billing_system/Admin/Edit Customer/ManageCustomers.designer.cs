
namespace Electric_billing_system
{
    partial class Manage_customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_customers));
            this.Edit_Meter_Btn = new System.Windows.Forms.PictureBox();
            this.Edit_Customers_btn = new System.Windows.Forms.PictureBox();
            this.View_btn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Meter_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Customers_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_Meter_Btn
            // 
            this.Edit_Meter_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Meter_Btn.Image")));
            this.Edit_Meter_Btn.Location = new System.Drawing.Point(217, 117);
            this.Edit_Meter_Btn.Name = "Edit_Meter_Btn";
            this.Edit_Meter_Btn.Size = new System.Drawing.Size(98, 92);
            this.Edit_Meter_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Meter_Btn.TabIndex = 21;
            this.Edit_Meter_Btn.TabStop = false;
            this.Edit_Meter_Btn.Click += new System.EventHandler(this.viewbut_Click);
            // 
            // Edit_Customers_btn
            // 
            this.Edit_Customers_btn.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Customers_btn.Image")));
            this.Edit_Customers_btn.Location = new System.Drawing.Point(447, 117);
            this.Edit_Customers_btn.Name = "Edit_Customers_btn";
            this.Edit_Customers_btn.Size = new System.Drawing.Size(98, 92);
            this.Edit_Customers_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Customers_btn.TabIndex = 24;
            this.Edit_Customers_btn.TabStop = false;
            this.Edit_Customers_btn.Click += new System.EventHandler(this.Edit_Customers_btn_Click);
            // 
            // View_btn
            // 
            this.View_btn.AutoSize = true;
            this.View_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_btn.ForeColor = System.Drawing.Color.White;
            this.View_btn.Location = new System.Drawing.Point(200, 213);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(133, 58);
            this.View_btn.TabIndex = 25;
            this.View_btn.Text = "Add & Edit\r\nMeters";
            this.View_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.View_btn.UseMnemonic = false;
            this.View_btn.Click += new System.EventHandler(this.viewbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 58);
            this.label3.TabIndex = 28;
            this.label3.Text = "Edit & Delete\r\nCustomers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            this.label3.Click += new System.EventHandler(this.Edit_Customers_btn_Click);
            // 
            // Manage_customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.Edit_Customers_btn);
            this.Controls.Add(this.Edit_Meter_Btn);
            this.Name = "Manage_customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerHouse Details";
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Meter_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Customers_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Edit_Meter_Btn;
        private System.Windows.Forms.PictureBox Edit_Customers_btn;
        private System.Windows.Forms.Label View_btn;
        private System.Windows.Forms.Label label3;
    }
}

