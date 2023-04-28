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
using System.Xml.Linq;

namespace Electric_billing_system
{
    public partial class registration_form : Form
    {
        static int CustomerID = 0;
        static int MeterID = 8;
        string ordb = "Data source = orcl; User Id = scott; password = tiger; ";
        OracleConnection conn;
        public registration_form()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            CustomerID++;
            MeterID++;   
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Customer (CustomerID, Nationalid, Firstname , Lastname , Email , Username, Userpassword) values( :CustomerID, :Nationalid, :Firstname , :Lastname , :Email , :Username, :Userpassword)";
                //"insert into meters (MeterID) values (:MeterID) where CustomerID = :CustomerID ";
                // + "insert into bill () values ()"
                // + "insert into customerphones () values ()"

            cmd.Parameters.Add("CustomerID", CustomerID);
            cmd.Parameters.Add("Nationalid", registeredNIDName_textbox.Text.ToString());
            cmd.Parameters.Add("Firstname", registeredFirstName_textbox.Text.ToString());
            cmd.Parameters.Add("Lastname", registeredLastName_textbox.Text.ToString());
            cmd.Parameters.Add("Email", registeredEmail_textbox.Text.ToString());
            cmd.Parameters.Add("Username", registeredUserName_textbox.Text.ToString());
            cmd.Parameters.Add("Userpassword", registeredPassword_textbox.Text.ToString());
            //cmd.Parameters.Add("MeterID", MeterID);
            //cmd.Parameters.Add("CustomerID", CustomerID);
            int r = cmd.ExecuteNonQuery();
            if (r != -1) 
            {
                MessageBox.Show("Registration successful");
                this.Hide();
            }

        }
    }
}
