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
    public partial class ManagePH : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public ManagePH()
        {
            InitializeComponent();
        }

        private void ManagePH_Load(object sender, EventArgs e)
        {
           
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select power_house_name from power_house";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { cmbph.Items.Add(dr[0]); }
            dr.Close();

           

        }

        private void addbut_Click(object sender, EventArgs e)
        {
            Electric_billing_system.AddPH addf = new Electric_billing_system.AddPH();
           
            addf.ShowDialog();
            cmbph.Items.Add(addf.Powerhousename);
           
           
        }

        private void cmbph_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void delbut_Click(object sender, EventArgs e)
        {
            if (cmbph.Text != "Select PowerHouse")
            {
                DialogResult res = MessageBox.Show($"Are you sure you want to delete {cmbph.Text} Powerhouse?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;

                    c.CommandText = "Delete from power_house where power_house_name=:name ";
                    c.Parameters.Add("name", cmbph.Text);
                    int r = c.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Power house deleted successfully.");
                        cmbph.Items.RemoveAt(cmbph.SelectedIndex);

                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a PowerHouse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void viewbut_Click(object sender, EventArgs e)
        {
            if (cmbph.Text != "Select PowerHouse")
            {
                string selectedphName = cmbph.SelectedItem.ToString();
                Electric_billing_system.ViewPH viewf = new Electric_billing_system.ViewPH(selectedphName);
                viewf.Show();
            }
            else
            {
                MessageBox.Show("Please select a PowerHouse","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

       

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
