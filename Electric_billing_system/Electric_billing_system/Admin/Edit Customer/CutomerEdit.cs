using Oracle.DataAccess.Client;
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
    public partial class CustomerEdit : Form
    {
        string constr = "Data Source=ORCL ; User Id=scott; Password=tiger;";
        string cmdstr = "select customerid,firstname,lastname,latepayment,email,username,userpassword from customer";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public CustomerEdit()
        {
            InitializeComponent();
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void save_button_Click(object sender, EventArgs e)
        {
                try
                {
                    builder = new OracleCommandBuilder(adapter);
                    adapter.Update(ds.Tables[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        
    }
}
