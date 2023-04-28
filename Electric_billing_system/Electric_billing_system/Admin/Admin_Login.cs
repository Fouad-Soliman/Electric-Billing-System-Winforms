using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Electric_billing_system
{
    public partial class Admin_Login : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott; Password=tiger;";
        OracleConnection conn;

        public Admin_Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select adminid,email,Adminpassword from AdminInfo where email='{Username_Textbox.Text}' and Adminpassword='{Password_Textbox.Text}'";
            cmd.CommandType = CommandType.Text;
            var r = cmd.ExecuteScalar();

            if (r == null)
            {
                MessageBox.Show("Invalid Username or password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
            else{
                MessageBox.Show("Successful", "Successful Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                Admin_Menu Am = new Admin_Menu(Convert.ToInt32(r));
                Am.ShowDialog();
             
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CustomerEdit f2 = new CustomerEdit();
            //f2.ShowDialog();
        }
    }
}
  