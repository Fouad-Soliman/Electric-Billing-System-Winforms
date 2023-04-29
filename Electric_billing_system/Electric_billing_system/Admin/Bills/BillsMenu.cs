using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_billing_system.Admin.Bills
{
    public partial class BillsMenu : Form
    {
        int A_id;
        public BillsMenu(int a_id)
        {
            A_id = a_id;
            InitializeComponent();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBill CB = new CreateBill(A_id);
            CB.ShowDialog();
            this.Close();
        }

        private void Approve_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApproveBills AB = new ApproveBills(A_id);
            AB.ShowDialog();
            this.Close();
        }
    }
}
