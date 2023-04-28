
namespace Electric_billing_system
{
    partial class ManagePH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePH));
            this.cmbph = new System.Windows.Forms.ComboBox();
            this.clsbtn = new System.Windows.Forms.Button();
            this.Edit_Customer_Pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.View_btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Customer_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbph
            // 
            this.cmbph.FormattingEnabled = true;
            this.cmbph.Location = new System.Drawing.Point(253, 55);
            this.cmbph.Name = "cmbph";
            this.cmbph.Size = new System.Drawing.Size(263, 24);
            this.cmbph.TabIndex = 0;
            this.cmbph.Text = "Select PowerHouse";
            this.cmbph.SelectedIndexChanged += new System.EventHandler(this.cmbph_SelectedIndexChanged);
            // 
            // clsbtn
            // 
            this.clsbtn.Location = new System.Drawing.Point(314, 292);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(122, 48);
            this.clsbtn.TabIndex = 20;
            this.clsbtn.Text = "Close";
            this.clsbtn.UseVisualStyleBackColor = true;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // Edit_Customer_Pic
            // 
            this.Edit_Customer_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Customer_Pic.Image")));
            this.Edit_Customer_Pic.Location = new System.Drawing.Point(135, 117);
            this.Edit_Customer_Pic.Name = "Edit_Customer_Pic";
            this.Edit_Customer_Pic.Size = new System.Drawing.Size(98, 92);
            this.Edit_Customer_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Customer_Pic.TabIndex = 21;
            this.Edit_Customer_Pic.TabStop = false;
            this.Edit_Customer_Pic.Click += new System.EventHandler(this.viewbut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.addbut_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(527, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.delbut_Click);
            // 
            // View_btn
            // 
            this.View_btn.AutoSize = true;
            this.View_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_btn.ForeColor = System.Drawing.Color.White;
            this.View_btn.Location = new System.Drawing.Point(114, 213);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(143, 29);
            this.View_btn.TabIndex = 25;
            this.View_btn.Text = "View & Edit";
            this.View_btn.UseMnemonic = false;
            this.View_btn.Click += new System.EventHandler(this.viewbut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Add";
            this.label1.Click += new System.EventHandler(this.addbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(533, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Delete";
            this.label3.Click += new System.EventHandler(this.delbut_Click);
            // 
            // ManagePH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Edit_Customer_Pic);
            this.Controls.Add(this.clsbtn);
            this.Controls.Add(this.cmbph);
            this.Name = "ManagePH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerHouse Details";
            this.Load += new System.EventHandler(this.ManagePH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Customer_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbph;
        private System.Windows.Forms.Button clsbtn;
        private System.Windows.Forms.PictureBox Edit_Customer_Pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label View_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

