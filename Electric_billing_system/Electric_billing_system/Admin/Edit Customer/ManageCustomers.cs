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
    public partial class Manage_customers : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int a_id;
        public Manage_customers(int a)
        {
            a_id = a;
            InitializeComponent();
        }

     
      

      


        

        private void viewbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeterEdit ME = new MeterEdit(a_id);
            ME.ShowDialog();
            this.Show();

        }

       

      

        private void Edit_Customers_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Electric_billing_system.CustomerEdit CE = new CustomerEdit(a_id);
            CE.ShowDialog();
            this.Show();
        }
    }
}
