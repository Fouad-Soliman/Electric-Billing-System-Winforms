using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_billing_system
{
    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void Customer_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form customer_Login = new Login_Form();
            customer_Login.ShowDialog();
            this.Show();

        }

        private void Customer_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form customer_Login = new Login_Form();
            customer_Login.ShowDialog();
            this.Show();
            
        }

        private void Admin_login_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            this.Hide();
            admin.ShowDialog();
            this.Show();

        }

        private void Admin_pic_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
