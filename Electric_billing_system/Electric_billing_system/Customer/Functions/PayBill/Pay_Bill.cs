using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Electric_billing_system
{
    public partial class Pay_Bill : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int CustID;

        public Pay_Bill(string c_id)
        {
            CustID= Convert.ToInt32( c_id);
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select MeterID from Bill where  Approved <> 'y' and  CustomerID={CustID} ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                meter_choice.Items.Add(dr[0]);
            }
            dr.Close();
        }
        private void meter_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select currentreading , ABS(TotalFees),city,cityarea,connectiontype,previousreading from meter where meterid=:id";
            cmd.Parameters.Add("id", meter_choice.SelectedItem.ToString());


            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                current_reading.Text = dr[0].ToString();
                fees.Text = dr[1].ToString();
                Connection_Type_txtbox.Text = dr[4].ToString();
                Address.Text = dr[2].ToString()+","+dr[3].ToString();
                Previous_reading.Text = dr[5].ToString();
            }
            dr.Close();

        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            if (creditCard_rdio.Checked)
            {
                credit c = new credit(CustID);
                c.ShowDialog();
            }
            else if (Cash_rdio.Checked)
            {
                char status = 'n';
              
                //cid = Convert.ToInt32(result);
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "update bill set approved='n',paymenttype='cash' where meterid=:id ";


              cmd2.Parameters.Add("id", meter_choice.SelectedItem.ToString());
                int r=cmd2.ExecuteNonQuery();
                if (r!=-1)
                {
                    MessageBox.Show("Your payment is processing and an email will be sent once approved");

                }
              
                }


              
            }
        }






         
    }

