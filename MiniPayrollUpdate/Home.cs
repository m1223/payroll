using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPayrollUpdate
{
    public partial class Home : Form
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static  string databaseName = "payrollDB.mdf";

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";

        public Home()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Users where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                if(datatable.Rows.Count == 1)
                {
                    Dashboard mainForm = new Dashboard();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Check User Name And Password.Then Try Again!","Error");
                }

            }

        }
    }

    internal class Employee
    {
    }
}
