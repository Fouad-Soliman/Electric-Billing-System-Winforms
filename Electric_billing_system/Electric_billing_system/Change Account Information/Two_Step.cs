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
    public partial class Two_Step : Form
    {
        public Two_Step()
        {
            InitializeComponent();
        }
        string Code;
        char verified = 'F';
        public Two_Step(string code)
            
        {
            InitializeComponent();
            Code = code;

        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {
        }
        public char getStep()
        {
            return verified;
        }
        private void Two_Step_Load(object sender, EventArgs e)
        {
            siticoneButton1.Show();
            siticoneHtmlLabel1.Show();

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (Verification_textBox.Text == Code) verified = 'T'; else MessageBox.Show("Wrong Verification Code");
            this.Close();
        }
    }
}
