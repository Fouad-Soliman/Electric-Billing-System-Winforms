namespace Electric_billing_system
{
    partial class CreateBill
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
            this.CurrentConsumption_TextBox = new System.Windows.Forms.TextBox();
            this.CreateBill_Label = new System.Windows.Forms.Label();
            this.ChooseMonth_Label = new System.Windows.Forms.Label();
            this.PreviousConsumption_textbox = new System.Windows.Forms.TextBox();
            this.MeterID_label = new System.Windows.Forms.Label();
            this.MeterID_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BilliD_textbox = new System.Windows.Forms.TextBox();
            this.BilliD_label = new System.Windows.Forms.Label();
            this.CustomerID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentConsumption_TextBox
            // 
            this.CurrentConsumption_TextBox.Location = new System.Drawing.Point(623, 210);
            this.CurrentConsumption_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentConsumption_TextBox.Name = "CurrentConsumption_TextBox";
            this.CurrentConsumption_TextBox.Size = new System.Drawing.Size(220, 22);
            this.CurrentConsumption_TextBox.TabIndex = 1;
            // 
            // CreateBill_Label
            // 
            this.CreateBill_Label.AutoSize = true;
            this.CreateBill_Label.Location = new System.Drawing.Point(620, 182);
            this.CreateBill_Label.Name = "CreateBill_Label";
            this.CreateBill_Label.Size = new System.Drawing.Size(149, 17);
            this.CreateBill_Label.TabIndex = 3;
            this.CreateBill_Label.Text = "Current Consumption :";
            // 
            // ChooseMonth_Label
            // 
            this.ChooseMonth_Label.AutoSize = true;
            this.ChooseMonth_Label.Location = new System.Drawing.Point(620, 114);
            this.ChooseMonth_Label.Name = "ChooseMonth_Label";
            this.ChooseMonth_Label.Size = new System.Drawing.Size(157, 17);
            this.ChooseMonth_Label.TabIndex = 2;
            this.ChooseMonth_Label.Text = "Previous Consumption :";
            // 
            // PreviousConsumption_textbox
            // 
            this.PreviousConsumption_textbox.Location = new System.Drawing.Point(623, 142);
            this.PreviousConsumption_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousConsumption_textbox.Name = "PreviousConsumption_textbox";
            this.PreviousConsumption_textbox.ReadOnly = true;
            this.PreviousConsumption_textbox.Size = new System.Drawing.Size(220, 22);
            this.PreviousConsumption_textbox.TabIndex = 5;
            // 
            // MeterID_label
            // 
            this.MeterID_label.AutoSize = true;
            this.MeterID_label.Location = new System.Drawing.Point(24, 114);
            this.MeterID_label.Name = "MeterID_label";
            this.MeterID_label.Size = new System.Drawing.Size(61, 17);
            this.MeterID_label.TabIndex = 6;
            this.MeterID_label.Text = "Meter ID";
            // 
            // MeterID_comboBox
            // 
            this.MeterID_comboBox.FormattingEnabled = true;
            this.MeterID_comboBox.Location = new System.Drawing.Point(28, 140);
            this.MeterID_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MeterID_comboBox.Name = "MeterID_comboBox";
            this.MeterID_comboBox.Size = new System.Drawing.Size(205, 24);
            this.MeterID_comboBox.TabIndex = 7;
            this.MeterID_comboBox.SelectedIndexChanged += new System.EventHandler(this.MeterID_comboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add BIll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BilliD_textbox
            // 
            this.BilliD_textbox.Location = new System.Drawing.Point(28, 210);
            this.BilliD_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BilliD_textbox.Name = "BilliD_textbox";
            this.BilliD_textbox.Size = new System.Drawing.Size(220, 22);
            this.BilliD_textbox.TabIndex = 9;
            // 
            // BilliD_label
            // 
            this.BilliD_label.AutoSize = true;
            this.BilliD_label.Location = new System.Drawing.Point(24, 182);
            this.BilliD_label.Name = "BilliD_label";
            this.BilliD_label.Size = new System.Drawing.Size(43, 17);
            this.BilliD_label.TabIndex = 10;
            this.BilliD_label.Text = "Bill ID";
            // 
            // CustomerID_textBox
            // 
            this.CustomerID_textBox.Location = new System.Drawing.Point(264, 142);
            this.CustomerID_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerID_textBox.Name = "CustomerID_textBox";
            this.CustomerID_textBox.ReadOnly = true;
            this.CustomerID_textBox.Size = new System.Drawing.Size(220, 22);
            this.CustomerID_textBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer ID";
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerID_textBox);
            this.Controls.Add(this.BilliD_label);
            this.Controls.Add(this.BilliD_textbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MeterID_comboBox);
            this.Controls.Add(this.MeterID_label);
            this.Controls.Add(this.PreviousConsumption_textbox);
            this.Controls.Add(this.CreateBill_Label);
            this.Controls.Add(this.ChooseMonth_Label);
            this.Controls.Add(this.CurrentConsumption_TextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumption Per Month";
            this.Load += new System.EventHandler(this.CreateBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CurrentConsumption_TextBox;
        private System.Windows.Forms.Label CreateBill_Label;
        private System.Windows.Forms.Label ChooseMonth_Label;
        private System.Windows.Forms.TextBox PreviousConsumption_textbox;
        private System.Windows.Forms.Label MeterID_label;
        private System.Windows.Forms.ComboBox MeterID_comboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BilliD_textbox;
        private System.Windows.Forms.Label BilliD_label;
        private System.Windows.Forms.TextBox CustomerID_textBox;
        private System.Windows.Forms.Label label1;
    }
}