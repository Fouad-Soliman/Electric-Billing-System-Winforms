using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_billing_system
{
    public partial class credit : Form
    {
        int cid;
        string ordb = "Data Source=ORCL; User Id=scott; Password=tiger;";
        OracleConnection conn;
        public credit(int c_id)
        {
            cid = c_id;
            InitializeComponent();
        }
      


        private void credit_Load(object sender, EventArgs e)
        {
            addcreditcard_btn.Hide();

        }
        
        private void cardNumber_txt_Validating(object sender, CancelEventArgs e)
        {
            bool valid = true;
            if (cardNumber_txt.Text.Length != 16)
            {
                valid = false;

            }
            if (!valid)
            {
                DialogResult result = MessageBox.Show("Card Number must be 16 digits", "Invalid Number", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    cardNumber_txt.Focus();
                }


            }
            else
            {
                cvv_txt.Focus();
            }
        }

          private void cvv_txt_TextChanged(object sender, EventArgs e)
           {

              
    } 

        private void cardNumber_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // suppress the "beep" sound
                e.Handled = true; // prevent the "Enter" key from being entered into the textbox
                this.SelectNextControl((Control)sender, true, true, true, true); // move focus to the next control

            }
        }


        private void cvv_txt_Validating(object sender, CancelEventArgs e)
        {
            bool valid = true;
            if (cvv_txt.Text.Length != 3)
            {
                valid = false;

            }
            if (!valid)
            {
                DialogResult result = MessageBox.Show("cvv must be 3 digits", "Invalid Number", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    cvv_txt.Focus();
                }
            }
            else
            {
                month_txt.Focus();
            }

        }

        private void cvv_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                e.Handled = true; 
                this.SelectNextControl((Control)sender, true, true, true, true); 

            }
        }



        private void submit_button_Click(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select customerid from payment_details where card_number=:cardnum and cvv=:Cvv and valid=TO_DATE('{year_text.Text}-{month_txt.Text}-01','YYYY-MM-DD')";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("cardnum" , cardNumber_txt.Text);
            cmd.Parameters.Add("Cvv", cvv_txt.Text);
            //string dateText = month_txt.Text;
            //string format = "dd/MM/yyyy";
            //ateTime date = DateTime.ParseExact(dateText , format , CultureInfo.InvariantCulture);
            //cmd.Parameters.Add("expDate", month_txt.Text);
            
            object result=cmd.ExecuteScalar();
            
            if (result!= null)
            {
                cid = Convert.ToInt32(result);
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText ="update bill set paymentdate=sysdate ,approved='y' where customerid=:id and paymenttype='Visa'";
            
                cmd2.Parameters.Add("id", cid);
               // cmd2.CommandText = "updatePaymentDate";
                //cmd2.CommandType = CommandType.StoredProcedure;
                //cmd2.Parameters.Add("customerID", cid);
                paymentLabel.Text = "payment successfull";
                paymentLabel.ForeColor = System.Drawing.Color.Green;
                cmd2.ExecuteNonQuery();

            }
            else {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = $"Select customerid from payment_details where card_number=:cardnum  and valid=TO_DATE('{year_text.Text}-{month_txt.Text}-01','YYYY-MM-DD')";
                cmd2.CommandType = CommandType.Text;
                //paymentLabel.Text = "payment re check your card info";
                //pymentLabel.ForeColor = System.Drawing.Color.Red;
                cmd2.Parameters.Add("cardnum", cardNumber_txt.Text);
                object result2 = cmd2.ExecuteScalar();
                if (result2==null)
                {
                    
                 DialogResult res=MessageBox.Show("Card data doesn't exist,would you like to add a new one?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        OracleCommand cmd3 = new OracleCommand();
                        cmd3.Connection = conn;
                        cmd3.CommandText =$"insert into payment_details values({cardNumber_txt.Text},:cvv,TO_DATE('{year_text.Text}-{month_txt.Text}-01','YYYY-MM-DD'),'visa',:C)";
                        cmd3.CommandType = CommandType.Text;
                        ///cmd3.Parameters.Add("cardnum", cardNumber_txt.Text);
                        cmd3.Parameters.Add("cvv", cvv_txt.Text);
                        //cmd3.Parameters.Add("CID", cid);
                       int r= cmd3.ExecuteNonQuery();
                        if (r!=1)
                        {
                            MessageBox.Show("Credit Card Added Successfully \n Kindly click pay if you want to complete your payment process");

                        }
                        else
                        {
                            MessageBox.Show("sorry we can't complete your payment process,either check your card data or Add a new one !", "Rejection");
                        }
                        
                    }
                }
            }
        }

        private void month_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }

        private void addcreditcard_btn_Click(object sender, EventArgs e)
        {

        }
    }
}




