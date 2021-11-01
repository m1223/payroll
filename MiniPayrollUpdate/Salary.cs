using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPayrollUpdate
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bonus bns = new Bonus();
            bns.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salary sl = new Salary();
            sl.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Advance adv = new Advance();
            adv.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
