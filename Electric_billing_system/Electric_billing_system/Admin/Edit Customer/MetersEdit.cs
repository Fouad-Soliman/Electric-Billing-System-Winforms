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
    public partial class MeterEdit : Form
    {
        string constr = "Data Source=ORCL ; User Id=scott; Password=tiger;";
        string cmdstr = "select METERID, CUSTOMERID, CONNECTIONTYPE,PAYMENTRATE,CURRENTREADING,CITY,CITYAREA,PREVIOUSREADING from meter";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        OracleConnection conn;
        DataSet ds;
        int A_id;
        public MeterEdit(int a_id)
        {
            A_id = a_id;
            InitializeComponent();
        }

        private void MeterEdit_Load(object sender, EventArgs e)
        {
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Are you sure you want to Save current Customers edits?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
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

                OracleCommand cmd6 = new OracleCommand();
                conn = new OracleConnection(constr);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd6.Connection = conn;
                cmd6.CommandText = $"insert into SYSLOG (ADMINID,ACTIONDATETIME,ACTION,METERID,POWERHOUSEID) values ({A_id}, systimestamp, 'Update Meter Database', NULL, Null)";
                int x = cmd6.ExecuteNonQuery();
            }
        }
    }
}
