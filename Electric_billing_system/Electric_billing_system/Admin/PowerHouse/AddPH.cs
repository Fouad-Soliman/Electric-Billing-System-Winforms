
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
    public partial class AddPH : Form
    {
       
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public AddPH()
        {
            InitializeComponent();
        }


        private void AddPH_Load(object sender, EventArgs e)
        {

        }

        private void savebut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Are you sure you want to add {nametxt.Text} Powerhouse?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"insert into power_house (power_house_name,power_house_id,MAX_capacity,Address,fuel_type,mangerid,status,launching_year) values ('{nametxt.Text.ToString()}',{idtxt.Text},{maxcaptxt.Text},'{addtxt.Text.ToString()}','{fueltxt.Text.ToString()}',{manidtxt.Text},'{Status_combo.SelectedItem.ToString()}',{textBox1.Text})";


                try
                {
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {

                        MessageBox.Show("PowerHouse Added successfully");


                    }
                }
                catch (Exception x) { MessageBox.Show(x.Message); }
            }
            this.Close();
           
        }
        public string Powerhousename
        {
            get { return nametxt.Text; }
        }
    }
}
