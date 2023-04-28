using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_billing_system.Admin
{
    public partial class ViewSystemlog : Form
    {
        SYSTEM_LOG_REPORT CR;
        public ViewSystemlog()
        {
            InitializeComponent();
        }

        private void ViewSystemlog_Load(object sender, EventArgs e)
        {
            CR = new SYSTEM_LOG_REPORT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
