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
    public partial class Admin_Menu : Form
    {
        int A_id;
        public Admin_Menu(int a_id)
        {
            A_id = a_id;
            InitializeComponent();
        }

        private void Mange_pHBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Electric_billing_system.ManagePH  mPH = new Electric_billing_system.ManagePH(A_id);
            mPH.ShowDialog();
            this.Show();
        }

        private void Edit_Customer_Pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_customers MC = new Manage_customers(A_id);
            MC.ShowDialog();
            this.Show();
        }

        private void ManageBills_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Bills.BillsMenu bm =new  Admin.Bills.BillsMenu(A_id);
            bm.ShowDialog();
            this.Show();

        }

        private void SystemLog_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Electric_billing_system.Admin.ViewSystemlog VSL = new Electric_billing_system.Admin.ViewSystemlog();
            VSL.ShowDialog();
            this.Show();
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (DropDown_Customer.Visible == true)
            {
                DropDown_Customer.Hide();
                Logout_label.Hide();
                Logout_pictureBox.Hide();
                Quit_label.Hide();
                Quit_pictureBox.Hide();
                
            }
            else
            {
                DropDown_Customer.Show();
                Logout_label.Show();
                Logout_pictureBox.Show();
                Quit_label.Show();
                Quit_pictureBox.Show();
                
            }
        }
    }
}
