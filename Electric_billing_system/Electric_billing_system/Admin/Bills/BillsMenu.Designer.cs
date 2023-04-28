
namespace Electric_billing_system.Admin.Bills
{
    partial class BillsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsMenu));
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Approve_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Create_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Approve_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(267, 38);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(213, 39);
            this.Title.TabIndex = 2;
            this.Title.Text = "Manage Bills";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Create Bill";
            // 
            // Create_btn
            // 
            this.Create_btn.Image = ((System.Drawing.Image)(resources.GetObject("Create_btn.Image")));
            this.Create_btn.Location = new System.Drawing.Point(199, 123);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(98, 92);
            this.Create_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Create_btn.TabIndex = 27;
            this.Create_btn.TabStop = false;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(420, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Approve Bills";
            // 
            // Approve_btn
            // 
            this.Approve_btn.Image = ((System.Drawing.Image)(resources.GetObject("Approve_btn.Image")));
            this.Approve_btn.Location = new System.Drawing.Point(449, 123);
            this.Approve_btn.Name = "Approve_btn";
            this.Approve_btn.Size = new System.Drawing.Size(98, 92);
            this.Approve_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Approve_btn.TabIndex = 29;
            this.Approve_btn.TabStop = false;
            this.Approve_btn.Click += new System.EventHandler(this.Approve_btn_Click);
            // 
            // BillsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Approve_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.Title);
            this.Name = "BillsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.Create_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Approve_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Create_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Approve_btn;
    }
}