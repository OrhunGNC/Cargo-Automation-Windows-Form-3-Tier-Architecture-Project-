using BL;
using DAL;
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

namespace Kargo
{
    public partial class CustomerInterface : Form
    {
        public CustomerInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.CustomerList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Text = column.Cells["customerID"].Value.ToString();
            textBox2.Text = column.Cells["customerNameSurname"].Value.ToString();
            textBox3.Text = column.Cells["customerAdress"].Value.ToString();
            textBox4.Text = column.Cells["customerPhone"].Value.ToString();
            textBox5.Text = column.Cells["customerMail"].Value.ToString();
            textBox6.Text = column.Cells["customerPaymentStatus"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer customer =new Customer();
            customer.customerNameSurname = textBox7.Text;
            dataGridView1.DataSource=GCRUD.CustomerSearch(customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.customerID = Convert.ToInt32(textBox1.Text);
            customer.customerNameSurname = textBox2.Text;
            customer.customerAdress = textBox3.Text;
            customer.customerPhone = textBox4.Text;
            customer.customerMail = textBox5.Text;
            customer.customerPaymentStatus = textBox6.Text;
            GCRUD.CustomerUpdate(customer);
            dataGridView1.DataSource = GCRUD.CustomerList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.customerNameSurname = textBox2.Text;
            customer.customerAdress = textBox3.Text;
            customer.customerPhone = textBox4.Text;
            customer.customerMail = textBox5.Text;
            customer.customerPaymentStatus = textBox6.Text;
            GCRUD.CustomerAdd(customer);
            dataGridView1.DataSource = GCRUD.CustomerList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.customerID = Convert.ToInt32(textBox1.Text);
            GCRUD.CustomerDel(customer);
            dataGridView1.DataSource = GCRUD.CustomerList();
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
    }
}
