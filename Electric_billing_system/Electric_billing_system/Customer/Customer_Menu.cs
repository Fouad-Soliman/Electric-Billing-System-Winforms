using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Electric_billing_system
{
    public partial class Customer_Menu : Form
    {
        string ordb = "Data source = orcl; User Id = scott; password = tiger;";
        OracleConnection conn;
        string c_id;
        public Customer_Menu(string cust_id)
        {
            c_id = cust_id;
            InitializeComponent();
            
        }

        private void Pay_Bills_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Electric_billing_system.Pay_Bill PB = new Electric_billing_system.Pay_Bill(c_id);
            PB.ShowDialog();
            this.Show();
        }

        private void Print_Invoices_Pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print_Invoice PI = new Print_Invoice(Convert.ToInt32( c_id));
            PI.ShowDialog();
            this.Show();
        }

        private void Print_Invoices_label_Click(object sender, EventArgs e)
        {

        }

        private void Pay_Bills_label_Click(object sender, EventArgs e)
        {

        }
        private void Customer_Menu_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT Firstname,Lastname FROM CUSTOMER WHERE customerid={Convert.ToInt32(c_id)}";
            cmd.CommandType = CommandType.Text;
           
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Welcome_label.Text+=dr[0].ToString()+" " +dr[1].ToString();
            Account_settings_label.Text = dr[0].ToString() + " " + dr[1].ToString();
            Logout_label.Hide();
            Logout_pictureBox.Hide();
            Quit_label.Hide();
            Quit_pictureBox.Hide();
            Settings_label.Hide();
            Account_Settings_pictureBox.Hide();
            DropDown_Customer.Hide();

        }

        private void Account_Settings_pic_Click(object sender, EventArgs e)
        {
            if (DropDown_Customer.Visible == true)
            {
                DropDown_Customer.Hide();
                Logout_label.Hide();
                Logout_pictureBox.Hide();
                Quit_label.Hide();
                Quit_pictureBox.Hide();
                Settings_label.Hide();
                Account_Settings_pictureBox.Hide();
            }
            else
            {
                DropDown_Customer.Show();
                Logout_label.Show();
                Logout_pictureBox.Show();
                Quit_label.Show();
                Quit_pictureBox.Show();
                Settings_label.Show();
                Account_Settings_pictureBox.Show();

            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            Account_Settings  sc = new Account_Settings((c_id));
            this.Hide();
            sc.ShowDialog();
            this.Show();
            if (sc.save_key())
            {
                UpdateCustomer(
                    c_id,
                    sc.GetFirstName(),
                    sc.GetLastName(),
                    sc.GetEmail(),
                    sc.GetUsername(),
                    sc.GetPass(),
                    sc.Getsend_email(),
                    sc.Getstep2()
                    );

                Welcome_label.Text = "Hello " + sc.GetFirstName() + " " + sc.GetLastName();
                Account_settings_label.Text = "Hello " + sc.GetFirstName() + " " + sc.GetLastName();

            }
            if (sc.logout())
            {
                this.Close();
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our system.");
            Application.Exit();
        }

        public void UpdateCustomer(string id,string FirstName,string LastName,string Email,string UserName,string Password,char Notification,char TwoStep)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Update Customer set  Firstname='{FirstName}',Lastname='{LastName}',Email='{Email}',UserName='{UserName}',USERPASSWORD='{Password}',RECEIPT_NOTIFICATION='{Notification}',TWO_STEP='{TwoStep}' Where CustomerID='{Convert.ToInt32(id)}'";
            cmd.CommandType = CommandType.Text;
            int r = cmd.ExecuteNonQuery();
        }

        private void Logout_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
