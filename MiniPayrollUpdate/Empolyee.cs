using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MiniPayrollUpdate
{
    public partial class Form2 : Form
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "payrollDB.mdf";
        SqlConnection Con = new SqlConnection(@"Data Source=(Localdb)\MSSQLLocalDB; AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True;");

        public Form2()
        {
            InitializeComponent();

            ShowEmployee();
        }

        internal void show(Form2 frm2)
        {
            throw new NotImplementedException();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
        private void ShowEmployee()
        {
            Con.Open();
            string Query = "Select * from Employees";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if(name.Text == "" || phone.Text == "" || gender.SelectedIndex == -1 || address.Text == "" || basic_salary.Text == "" || qualification.SelectedIndex == -1 || position.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string inserting = "insert into Employees(name,gender,address,phone,qualification,dob,position,join_date,basic_salary) values(@NA,@GE,@AD,@PH,@QU,@DOB,@PO,@JD,@BS)";
                    SqlCommand cmd = new SqlCommand(inserting,Con);
                    cmd.Parameters.AddWithValue("@NA", name.Text);
                    cmd.Parameters.AddWithValue("@GE", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AD", address.Text);
                    cmd.Parameters.AddWithValue("@PH", phone.Text);
                    cmd.Parameters.AddWithValue("@QU", qualification.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DOB", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@PO", position.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", join_date.Value.Date);
                    cmd.Parameters.AddWithValue("@BS", basic_salary.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved");
                    Con.Close();
                    ShowEmployee();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bonus bns = new Bonus();
            bns.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Advance adv = new Advance();
            adv.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salary sl = new Salary();
            sl.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
