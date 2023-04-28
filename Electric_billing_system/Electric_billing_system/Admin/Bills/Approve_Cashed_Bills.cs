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
    public partial class ApproveBills : Form
    {
        string ordb = "Data source = orcl; User Id = scott; password = tiger; ";
        OracleConnection conn;
        public ApproveBills()
        {
            InitializeComponent();
        }

        private void ApproveBills_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select BillID from Bill where  PAYMENTTYPE = 'CASH' and PAYMENTSTATUS = 'n' ";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BilliD_comboBox.Items.Add(reader[0]);
            }
            
           
        }

        private void BilliD_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd2 = conn.CreateCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select * from Bill where BillID = :BillID ";
            cmd2.Parameters.Add("BillId", BilliD_comboBox.Text.ToString());
            OracleDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                MeterID_textBox.Text = reader2[1].ToString();
                CustomerID_textBox.Text = reader2[2].ToString();
                PreviousReading_textBox.Text = reader2[3].ToString();
                IssueDate_textBox.Text = reader2[4].ToString();
                PaymentDate_textBox.Text = reader2[5].ToString();
                PaymentType_textBox.Text = reader2[6].ToString();
            }
            
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn; 
            cmd3.CommandText = "select abs (TOTALFEES) from meter where MeterID = :MeterID";
            cmd3.Parameters.Add("MeterID", MeterID_textBox.Text.ToString());
            OracleDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                TotalFees_textBox.Text = reader3[0].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = conn;
            cmd4.CommandText = "update bill set PAYMENTSTATUS = 'y' where Billid = :Billid";
            cmd4.Parameters.Add("Billid", BilliD_comboBox.SelectedItem.ToString());
            int r = cmd4.ExecuteNonQuery();
            if (r != -1) 
            {
                MessageBox.Show("Bill Approved");
                BilliD_comboBox.Items.Remove(BilliD_comboBox.SelectedItem);
                BilliD_comboBox.Text = "";
                MeterID_textBox.Text = "";
                CustomerID_textBox.Text = "";
                PreviousReading_textBox.Text = "";
                IssueDate_textBox.Text = "";
                PaymentDate_textBox.Text = "";
                PaymentType_textBox.Text = "";
                TotalFees_textBox.Text = "";
            }
        }
    }
}
