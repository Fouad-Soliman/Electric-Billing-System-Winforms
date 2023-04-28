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

namespace Electric_billing_system
{
    public partial class Print_Invoice : Form
    {
        int c_id;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        Electric_billing_system.Customer.Functions.MeterBillsCrystal MCR;
        public Print_Invoice(int cus_id)
        {
            c_id = cus_id;
            MCR = new Customer.Functions.MeterBillsCrystal();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MCR.SetParameterValue(0, comboBox1.Text.ToString());
            crystalReportViewer1.ReportSource = MCR;
        }

        private void Print_Invoice_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select meterID from Meter where customerId={c_id}";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { comboBox1.Items.Add(dr[0]); }
            dr.Close();
        }
    }
}
