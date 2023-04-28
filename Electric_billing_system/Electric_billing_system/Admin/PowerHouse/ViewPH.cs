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
    public partial class ViewPH : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        string phName;
        public ViewPH(string phName)
        {
            InitializeComponent();
            this.phName=phName;
        }

        private void ViewPH_Load(object sender, EventArgs e)
        {
            Save_btn.Hide();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select power_house_name,power_house_id,max_capacity,address,fuel_type,mangerid,status,launching_year from power_house where power_house_name='{phName}'";
            cmd.CommandType = CommandType.Text;


            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nametxt.Text = dr[0].ToString();
                idtxt.Text = dr[1].ToString();
                captxt.Text = dr[2].ToString();
                addresstxt.Text = dr[3].ToString();
                fueltxt.Text = dr[4].ToString();
                manidtxt.Text = dr[5].ToString();
                Status_combo.Text = dr[6].ToString();
                launchtxt.Text = dr[7].ToString();

            }
            dr.Close();
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            captxt.ReadOnly = false;
            fueltxt.ReadOnly = false;
            manidtxt.ReadOnly = false;
            Status_combo.Enabled = true;
            Save_btn.Show();
            
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Are you sure you want to Edit {nametxt.Text} Powerhouse?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = $"update power_house set max_capacity=:cap, fuel_type=:type,mangerid=:manid, status=:stat where power_house_name='{phName}' ";
                c.Parameters.Add("cap", captxt.Text);
                c.Parameters.Add("type", fueltxt.Text);
                c.Parameters.Add("manid", manidtxt.Text);
                c.Parameters.Add("stat", Status_combo.SelectedItem.ToString());
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("Power House modified successfully.");
                }
                this.Close();
            }
        }
    }
}
