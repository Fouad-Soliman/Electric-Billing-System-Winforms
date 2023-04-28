namespace Electric_billing_system
{
    partial class credit
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
            this.cardNumber_txt = new System.Windows.Forms.TextBox();
            this.cvv_txt = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.month_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.year_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addcreditcard_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardNumber_txt
            // 
            this.cardNumber_txt.Location = new System.Drawing.Point(288, 94);
            this.cardNumber_txt.MaxLength = 16;
            this.cardNumber_txt.Name = "cardNumber_txt";
            this.cardNumber_txt.Size = new System.Drawing.Size(100, 20);
            this.cardNumber_txt.TabIndex = 0;
            this.cardNumber_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardNumber_txt_KeyDown);
            this.cardNumber_txt.Validating += new System.ComponentModel.CancelEventHandler(this.cardNumber_txt_Validating);
            // 
            // cvv_txt
            // 
            this.cvv_txt.Location = new System.Drawing.Point(288, 134);
            this.cvv_txt.MaxLength = 3;
            this.cvv_txt.Name = "cvv_txt";
            this.cvv_txt.Size = new System.Drawing.Size(100, 20);
            this.cvv_txt.TabIndex = 1;
            this.cvv_txt.TextChanged += new System.EventHandler(this.cvv_txt_TextChanged);
            this.cvv_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cvv_txt_KeyDown);
            this.cvv_txt.Validating += new System.ComponentModel.CancelEventHandler(this.cvv_txt_Validating);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(300, 257);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 3;
            this.submit_button.Text = "submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "card number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cvv";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(327, 299);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(0, 13);
            this.paymentLabel.TabIndex = 6;
            // 
            // month_txt
            // 
            this.month_txt.Location = new System.Drawing.Point(288, 173);
            this.month_txt.Name = "month_txt";
            this.month_txt.Size = new System.Drawing.Size(100, 20);
            this.month_txt.TabIndex = 7;
            this.month_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.month_txt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exp month";
            // 
            // year_text
            // 
            this.year_text.Location = new System.Drawing.Point(288, 210);
            this.year_text.Name = "year_text";
            this.year_text.Size = new System.Drawing.Size(100, 20);
            this.year_text.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Exp year";
            // 
            // addcreditcard_btn
            // 
            this.addcreditcard_btn.Location = new System.Drawing.Point(601, 299);
            this.addcreditcard_btn.Name = "addcreditcard_btn";
            this.addcreditcard_btn.Size = new System.Drawing.Size(89, 29);
            this.addcreditcard_btn.TabIndex = 11;
            this.addcreditcard_btn.Text = "Add Credit Card";
            this.addcreditcard_btn.UseVisualStyleBackColor = true;
            this.addcreditcard_btn.Click += new System.EventHandler(this.addcreditcard_btn_Click);
            // 
            // credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addcreditcard_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.year_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month_txt);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.cvv_txt);
            this.Controls.Add(this.cardNumber_txt);
            this.Name = "credit";
            this.Text = "credit";
            this.Load += new System.EventHandler(this.credit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardNumber_txt;
        private System.Windows.Forms.TextBox cvv_txt;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox month_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox year_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addcreditcard_btn;
    }
}