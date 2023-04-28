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
    public partial class CreateBill : Form
    {
        int A_ID;
        string ordb = "Data source = orcl; User Id = scott; password = tiger; ";
        OracleConnection conn;

        public CreateBill(int a_id)
        {
            A_ID = a_id;
            InitializeComponent();
        }

        private void CreateBill_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select MeterID from Meter";
            OracleDataReader reader = cmd2.ExecuteReader();
            while(reader.Read())
            {
                MeterID_comboBox.Items.Add(reader[0]);
            }
        }

        private void MeterID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "select CURRENTREADING , CustomerID from METER where meterID = :meterID";
            cmd3.Parameters.Add("meterID", MeterID_comboBox.Text.ToString());
            OracleDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                PreviousConsumption_textbox.Text = reader[0].ToString();
                CustomerID_textBox.Text = reader[1].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd4 = new OracleCommand();
            OracleCommand cmd5 = new OracleCommand();
            cmd4.Connection = conn;
            cmd5.Connection = conn;
            cmd4.CommandText = "insert into bill (Billid, MeterID, PreviousReading, IssueDate, CustomerID) values (:BilliD, :MeterID, :PreviousReading, SYSDATE, :CustomerID)";
            cmd5.CommandText = "update meter set (CURRENTREADING) = (:CURRENTREADING) , (PREVIOUSREADING) = (:PREVIOUSREADING) where MeterID = :MeterID";
            cmd4.Parameters.Add("BilliD", BilliD_textbox.Text.ToString());
            cmd4.Parameters.Add("MeterID", MeterID_comboBox.Text.ToString());
            cmd4.Parameters.Add("PreviousReading", PreviousConsumption_textbox.Text.ToString());
            cmd4.Parameters.Add("CustomerID", CustomerID_textBox.Text.ToString());
            cmd5.Parameters.Add("CurrentReading", CurrentConsumption_TextBox.Text.ToString());
            cmd5.Parameters.Add("PreviousReading", PreviousConsumption_textbox.Text.ToString());
            cmd5.Parameters.Add("MeterID", MeterID_comboBox.Text.ToString());
            int r = cmd4.ExecuteNonQuery();
            int v = cmd5.ExecuteNonQuery();
            if (r != -1 && v != -1)
            {
                MessageBox.Show("Bill added successfully");
                OracleCommand cmd6 = new OracleCommand();
                cmd6.Connection = conn;

                cmd6.CommandText = $"insert into SYSLOG (ADMINID,ACTIONDATETIME,ACTION,METERID,POWERHOUSEID) values ({A_ID}, systimestamp, 'Create Bill', {MeterID_comboBox.Text.ToString()}, Null)";
                int x = cmd6.ExecuteNonQuery();
                this.Hide();
            }
            
        }
    }
}
