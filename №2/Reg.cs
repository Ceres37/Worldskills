using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceres\source\repos\№2\№2\Database1.mdf;Integrated Security=True");

            SqlCommand loginQuery = new SqlCommand(@"INSERT INTO Users (Login, Password) VALUES(@Login,@Password)", con);

            loginQuery.Parameters.AddWithValue(@"Login", textBox1.Text);

            loginQuery.Parameters.AddWithValue(@"Password", textBox3.Text);

            try
            {
                con.Open();
                loginQuery.ExecuteNonQuery();
                MessageBox.Show("New Client was successfully added!", "");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }

        }
    }
}
