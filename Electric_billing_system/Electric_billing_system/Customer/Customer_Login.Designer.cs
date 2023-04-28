namespace Electric_billing_system
{
    partial class Login_Form
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
            this.userEmail_textbox = new System.Windows.Forms.TextBox();
            this.userPassword_textbox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Register_Link = new System.Windows.Forms.LinkLabel();
            this.User_Email = new System.Windows.Forms.Label();
            this.User_Password = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userEmail_textbox
            // 
            this.userEmail_textbox.Location = new System.Drawing.Point(216, 78);
            this.userEmail_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userEmail_textbox.Name = "userEmail_textbox";
            this.userEmail_textbox.Size = new System.Drawing.Size(270, 22);
            this.userEmail_textbox.TabIndex = 0;
            // 
            // userPassword_textbox
            // 
            this.userPassword_textbox.Location = new System.Drawing.Point(216, 121);
            this.userPassword_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPassword_textbox.Name = "userPassword_textbox";
            this.userPassword_textbox.Size = new System.Drawing.Size(270, 22);
            this.userPassword_textbox.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(306, 164);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(96, 34);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register_Link
            // 
            this.Register_Link.AutoSize = true;
            this.Register_Link.Location = new System.Drawing.Point(231, 223);
            this.Register_Link.Name = "Register_Link";
            this.Register_Link.Size = new System.Drawing.Size(248, 17);
            this.Register_Link.TabIndex = 3;
            this.Register_Link.TabStop = true;
            this.Register_Link.Text = "Don\'t have an account? Register here";
            this.Register_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_Link_LinkClicked);
            // 
            // User_Email
            // 
            this.User_Email.AutoSize = true;
            this.User_Email.Location = new System.Drawing.Point(140, 80);
            this.User_Email.Name = "User_Email";
            this.User_Email.Size = new System.Drawing.Size(73, 17);
            this.User_Email.TabIndex = 4;
            this.User_Email.Text = "Username";
            // 
            // User_Password
            // 
            this.User_Password.AutoSize = true;
            this.User_Password.Location = new System.Drawing.Point(141, 124);
            this.User_Password.Name = "User_Password";
            this.User_Password.Size = new System.Drawing.Size(69, 17);
            this.User_Password.TabIndex = 5;
            this.User_Password.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(303, 253);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 17);
            this.Label1.TabIndex = 6;
            this.Label1.TabStop = true;
            this.Label1.Text = "Forgot Password";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.User_Password);
            this.Controls.Add(this.User_Email);
            this.Controls.Add(this.Register_Link);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.userPassword_textbox);
            this.Controls.Add(this.userEmail_textbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userEmail_textbox;
        private System.Windows.Forms.TextBox userPassword_textbox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.LinkLabel Register_Link;
        private System.Windows.Forms.Label User_Email;
        private System.Windows.Forms.Label User_Password;
        private System.Windows.Forms.LinkLabel Label1;
    }
}

