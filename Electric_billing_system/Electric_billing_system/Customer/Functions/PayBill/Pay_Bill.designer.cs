namespace Electric_billing_system
{
    partial class Pay_Bill
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
            this.pay_button = new System.Windows.Forms.Button();
            this.meter_choice = new System.Windows.Forms.ComboBox();
            this.current_reading = new System.Windows.Forms.TextBox();
            this.Previous_read_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Current_read_label = new System.Windows.Forms.Label();
            this.Previous_reading = new System.Windows.Forms.TextBox();
            this.creditCard_rdio = new System.Windows.Forms.RadioButton();
            this.Cash_rdio = new System.Windows.Forms.RadioButton();
            this.Connection_type = new System.Windows.Forms.Label();
            this.Connection_Type_txtbox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.billidcmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(277, 282);
            this.pay_button.Margin = new System.Windows.Forms.Padding(4);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(100, 28);
            this.pay_button.TabIndex = 2;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // meter_choice
            // 
            this.meter_choice.FormattingEnabled = true;
            this.meter_choice.Location = new System.Drawing.Point(151, 33);
            this.meter_choice.Margin = new System.Windows.Forms.Padding(4);
            this.meter_choice.Name = "meter_choice";
            this.meter_choice.Size = new System.Drawing.Size(160, 24);
            this.meter_choice.TabIndex = 3;
            this.meter_choice.SelectedIndexChanged += new System.EventHandler(this.meter_choice_SelectedIndexChanged);
            // 
            // current_reading
            // 
            this.current_reading.Location = new System.Drawing.Point(487, 126);
            this.current_reading.Margin = new System.Windows.Forms.Padding(4);
            this.current_reading.Name = "current_reading";
            this.current_reading.ReadOnly = true;
            this.current_reading.Size = new System.Drawing.Size(132, 22);
            this.current_reading.TabIndex = 6;
            // 
            // Previous_read_label
            // 
            this.Previous_read_label.AutoSize = true;
            this.Previous_read_label.Location = new System.Drawing.Point(39, 133);
            this.Previous_read_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Previous_read_label.Name = "Previous_read_label";
            this.Previous_read_label.Size = new System.Drawing.Size(115, 17);
            this.Previous_read_label.TabIndex = 12;
            this.Previous_read_label.Text = "Previous reading";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Meter ID";
            // 
            // fees
            // 
            this.fees.Location = new System.Drawing.Point(275, 172);
            this.fees.Margin = new System.Windows.Forms.Padding(4);
            this.fees.Name = "fees";
            this.fees.ReadOnly = true;
            this.fees.Size = new System.Drawing.Size(132, 22);
            this.fees.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fees";
            // 
            // Current_read_label
            // 
            this.Current_read_label.AutoSize = true;
            this.Current_read_label.Location = new System.Drawing.Point(375, 133);
            this.Current_read_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Current_read_label.Name = "Current_read_label";
            this.Current_read_label.Size = new System.Drawing.Size(105, 17);
            this.Current_read_label.TabIndex = 21;
            this.Current_read_label.Text = "current reading";
            // 
            // Previous_reading
            // 
            this.Previous_reading.Location = new System.Drawing.Point(156, 127);
            this.Previous_reading.Margin = new System.Windows.Forms.Padding(4);
            this.Previous_reading.Name = "Previous_reading";
            this.Previous_reading.ReadOnly = true;
            this.Previous_reading.Size = new System.Drawing.Size(132, 22);
            this.Previous_reading.TabIndex = 20;
            // 
            // creditCard_rdio
            // 
            this.creditCard_rdio.AutoSize = true;
            this.creditCard_rdio.Location = new System.Drawing.Point(335, 241);
            this.creditCard_rdio.Margin = new System.Windows.Forms.Padding(4);
            this.creditCard_rdio.Name = "creditCard_rdio";
            this.creditCard_rdio.Size = new System.Drawing.Size(100, 21);
            this.creditCard_rdio.TabIndex = 1;
            this.creditCard_rdio.TabStop = true;
            this.creditCard_rdio.Text = "Credit Card";
            this.creditCard_rdio.UseVisualStyleBackColor = true;
            // 
            // Cash_rdio
            // 
            this.Cash_rdio.AutoSize = true;
            this.Cash_rdio.Location = new System.Drawing.Point(257, 241);
            this.Cash_rdio.Margin = new System.Windows.Forms.Padding(4);
            this.Cash_rdio.Name = "Cash_rdio";
            this.Cash_rdio.Size = new System.Drawing.Size(61, 21);
            this.Cash_rdio.TabIndex = 0;
            this.Cash_rdio.TabStop = true;
            this.Cash_rdio.Text = "Cash";
            this.Cash_rdio.UseVisualStyleBackColor = true;
            // 
            // Connection_type
            // 
            this.Connection_type.AutoSize = true;
            this.Connection_type.Location = new System.Drawing.Point(39, 85);
            this.Connection_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Connection_type.Name = "Connection_type";
            this.Connection_type.Size = new System.Drawing.Size(110, 17);
            this.Connection_type.TabIndex = 25;
            this.Connection_type.Text = "Connection type";
            // 
            // Connection_Type_txtbox
            // 
            this.Connection_Type_txtbox.Location = new System.Drawing.Point(151, 81);
            this.Connection_Type_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.Connection_Type_txtbox.Name = "Connection_Type_txtbox";
            this.Connection_Type_txtbox.ReadOnly = true;
            this.Connection_Type_txtbox.Size = new System.Drawing.Size(132, 22);
            this.Connection_Type_txtbox.TabIndex = 24;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(375, 86);
            this.Address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(60, 17);
            this.Address_label.TabIndex = 23;
            this.Address_label.Text = "Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(487, 80);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(132, 22);
            this.Address.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Payment Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Bill ID";
            // 
            // billidcmb
            // 
            this.billidcmb.FormattingEnabled = true;
            this.billidcmb.Location = new System.Drawing.Point(487, 32);
            this.billidcmb.Margin = new System.Windows.Forms.Padding(4);
            this.billidcmb.Name = "billidcmb";
            this.billidcmb.Size = new System.Drawing.Size(160, 24);
            this.billidcmb.TabIndex = 27;
            // 
            // Pay_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.billidcmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Connection_type);
            this.Controls.Add(this.Connection_Type_txtbox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Current_read_label);
            this.Controls.Add(this.Previous_reading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Previous_read_label);
            this.Controls.Add(this.current_reading);
            this.Controls.Add(this.meter_choice);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.creditCard_rdio);
            this.Controls.Add(this.Cash_rdio);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pay_Bill";
            this.Text = "Pay Bill";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.ComboBox meter_choice;
        private System.Windows.Forms.TextBox current_reading;
        private System.Windows.Forms.Label Previous_read_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Current_read_label;
        private System.Windows.Forms.TextBox Previous_reading;
        private System.Windows.Forms.RadioButton creditCard_rdio;
        private System.Windows.Forms.RadioButton Cash_rdio;
        private System.Windows.Forms.Label Connection_type;
        private System.Windows.Forms.TextBox Connection_Type_txtbox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox billidcmb;
    }
}