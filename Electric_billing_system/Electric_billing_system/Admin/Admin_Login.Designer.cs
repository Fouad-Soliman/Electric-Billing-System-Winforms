namespace Electric_billing_system
{
    partial class Admin_Login
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
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Admin_Email_label = new System.Windows.Forms.Label();
            this.Admin_Password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Location = new System.Drawing.Point(159, 78);
            this.Username_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(260, 22);
            this.Username_Textbox.TabIndex = 0;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(159, 123);
            this.Password_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(260, 22);
            this.Password_Textbox.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(234, 176);
            this.login_button.Margin = new System.Windows.Forms.Padding(4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 28);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Location = new System.Drawing.Point(403, 166);
            this.Error_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(0, 16);
            this.Error_label.TabIndex = 3;
            // 
            // Admin_Email_label
            // 
            this.Admin_Email_label.AutoSize = true;
            this.Admin_Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Email_label.Location = new System.Drawing.Point(48, 78);
            this.Admin_Email_label.Name = "Admin_Email_label";
            this.Admin_Email_label.Size = new System.Drawing.Size(103, 20);
            this.Admin_Email_label.TabIndex = 4;
            this.Admin_Email_label.Text = "Admin Email";
            // 
            // Admin_Password_label
            // 
            this.Admin_Password_label.AutoSize = true;
            this.Admin_Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Password_label.Location = new System.Drawing.Point(49, 126);
            this.Admin_Password_label.Name = "Admin_Password_label";
            this.Admin_Password_label.Size = new System.Drawing.Size(83, 20);
            this.Admin_Password_label.TabIndex = 5;
            this.Admin_Password_label.Text = "Password";
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 324);
            this.Controls.Add(this.Admin_Password_label);
            this.Controls.Add(this.Admin_Email_label);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label Error_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Admin_Email_label;
        private System.Windows.Forms.Label Admin_Password_label;
    }
}

