using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Net.Mail;

namespace Electric_billing_system
{
    public partial class Login_Form : Form
    {
        string ordb = "Data source = orcl; User Id = scott; password = tiger;";
        OracleConnection conn;
        bool CameFrom_ChangePass = false;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string userEmail = userEmail_textbox.Text;
            string userPassword = userPassword_textbox.Text;
            conn = new OracleConnection(ordb);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT CUSTOMERID,Two_step,Email FROM CUSTOMER WHERE UserName = :userEmail AND USERPASSWORD = :userPassword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(":userEmail", userEmail);
                cmd.Parameters.Add(":userPassword", userPassword);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr[0].ToString() != null)
                    {
                        if (dr[1].ToString() == "F" || CameFrom_ChangePass == true)
                        {
                            CameFrom_ChangePass = false;
                            MessageBox.Show("Login successful!");
                            Customer_Menu cm = new Customer_Menu(dr[0].ToString());
                            this.Hide();
                            cm.ShowDialog();
                        }
                        else
                        {
                            string EMAIL = dr[2].ToString();
                            string from, pass, MessageBody;
                            Random rd = new Random();
                            string randCode = rd.Next(1000000, 10000000).ToString();
                            MailMessage message = new MailMessage();
                            from = "selfdiagnosissupp@gmail.com";
                            pass = "eomootfkfmpefvut";
                            MessageBody = "Your Two Step Code is " + randCode + " .";
                            string From = from;
                            string MB = MessageBody;
                            string To;
                            string Pass = pass;
                            message.From = new MailAddress(From);
                            message.Body = MB;
                            message.Subject = "Two Step";
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
                            catch (Exception)
                            {

                            }
                            Two_Step ts = new Two_Step(randCode);
                            this.Hide();
                            ts.ShowDialog();
                            this.Show();
                            if (ts.getStep() == 'T')
                            {
                                MessageBox.Show("Login successful!");
                                Customer_Menu cm = new Customer_Menu(dr[0].ToString());
                                this.Hide();
                                cm.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

            private void Register_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registration_form CustomerEdit = new registration_form();
            CustomerEdit.ShowDialog();
            this.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
            this.Show();
            if (fp.getPassword_Changed())
            {
                userEmail_textbox.Text = fp.getUsername();
                userPassword_textbox.Text = fp.getPassword();
                CameFrom_ChangePass = true;
                Login.PerformClick();
            }
        }


    }
}
