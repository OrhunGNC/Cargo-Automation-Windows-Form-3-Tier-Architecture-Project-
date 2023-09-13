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

namespace Kargo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection coon = new SqlConnection("Server=DESKTOP-4B2QQPV\\SQLKODLAB;Database=Cargo;Integrated Security=true;");
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandText = "select * from Login where username=@username and password=@password";
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            coon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("You have successfully logged in!");
                CargoUI go = new CargoUI();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                textBox1.Clear();
                textBox2.Clear();
            }
            coon.Close();
        }
    }
}
