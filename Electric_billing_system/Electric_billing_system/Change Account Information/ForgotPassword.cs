

namespace Electric_billing_system
{
    using System;
    using System.ComponentModel;
    using System.Collections;
    using System.Windows.Forms;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Net;
    using System.Net.Mail;
    using System.Windows.Forms;
    using AForge;
    using AForge.Video;
    using AForge.Video.DirectShow;
    using DarrenLee.Media;
    using System.IO;
    using System.Drawing.Imaging;
    using System.Drawing.Drawing2D;
    using Oracle.DataAccess.Client;
    using System.Collections.Generic;
    public partial class ForgotPassword : Form
    {

        string EMAIL;
        string Username;
        public string getUsername()
        {
            return Username;
        }
        string Password;
        public string getPassword()
        {
            return Password;
        }
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Code_Password_textBox;
        private Label Email_Code_Password_label;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Label Reenter_Password_label;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Reenter_Password_textBox;
        public ForgotPassword()
        {
            InitializeComponent();
        }
        string Code;
        string ID;
        bool Password_Changed = false;
        public bool getPassword_Changed()
        {
            return Password_Changed;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (Email_Code_Password_label.Text == "Email:")
            {
                if (Code_Password_textBox.Text != "")
                {
                    MessageBox.Show("An email will be sent if the address written is correct");
                    bool Password_Changed = false;
                    EMAIL=Code_Password_textBox.Text;
                    string from, pass, MessageBody;
                    Random rd = new Random();
                    string randCode = rd.Next(1000000, 10000000).ToString();
                    MailMessage message = new MailMessage();
                    from = "selfdiagnosissupp@gmail.com";
                    pass = "eomootfkfmpefvut";
                    MessageBody = "Your Password Change Code is " + randCode + " .";
                    string From = from;
                    string MB = MessageBody;
                    string To;
                    string Pass = pass;
                    message.From = new MailAddress(From);
                    message.Body = MB;
                    message.Subject = "Change Password";
                    To = EMAIL;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    message.To.Add(To);
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(From, Pass);
                    try
                    {
                        smtp.SendMailAsync(message);
                        message.To.Clear();
                    }
                    catch (Exception )
                    {

                    }
                    Code = randCode;
                    Email_Code_Password_label.Text = "Code:";
                    siticoneButton1.Text = "Verify";
                    Code_Password_textBox.Text = "";
                }

            }
            else if (Email_Code_Password_label.Text == "Code:")
            {
                if (Code_Password_textBox.Text == Code)
                {
                    Email_Code_Password_label.Text = "New Password";
                    Code_Password_textBox.Text = "";
                    Reenter_Password_label.Show();
                    Reenter_Password_textBox.Show();
                    siticoneButton1.Text = "Enter";

                }
                else
                {
                    MessageBox.Show("Code Incorrect");
                }
            }
            else if(Email_Code_Password_label.Text == "New Password")
            {
                if (Code_Password_textBox.Text != "")
                {
                    if (Code_Password_textBox.Text == Reenter_Password_textBox.Text)
                    {
                        if (Code_Password_textBox.Text != Username)
                        {
                            Password = Reenter_Password_textBox.Text;
                            Password_Changed = true;
                            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
                            OracleConnection conn = new OracleConnection(ordb);
                            conn.Open();
                            OracleCommand c = new OracleCommand();
                            c.Connection = conn;
                            EMAIL = EMAIL.ToLower();

                            c.CommandText = $"Update Customer set USERPASSWORD='{Password}' Where Email='{EMAIL}'";
                            c.CommandType = CommandType.Text;
                            int r = c.ExecuteNonQuery();

                            MessageBox.Show("Password changed succesfully");
                            OracleCommand cmd = new OracleCommand();
                            c.Connection = conn;
                            c.CommandText = $"Select USERNAME from Customer where Email='{EMAIL}'";
                            c.CommandType = CommandType.Text;
                            OracleDataReader dr = c.ExecuteReader();
                            while(dr.Read())
                            Username = dr[0].ToString();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Password cannot be the same as Username");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords dont match");
                    }
                }
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            Reenter_Password_label.Hide();
            Reenter_Password_textBox.Hide();
        }
    }
}
