using BL;
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
using DAL;

namespace Kargo
{
    public partial class VehicleInterface : Form
    {
        public VehicleInterface()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=GCRUD.VehicleList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.vehicleName = textBox7.Text;
            dataGridView1.DataSource = GCRUD.VehicleSearch(vehicle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.vehicleID = Convert.ToInt32(textBox1.Text);
            vehicle.vehicleName = textBox2.Text;
            vehicle.vehicleCapacity = textBox3.Text;
            vehicle.vehicleDriver = textBox4.Text;
            vehicle.vehicleExpense = Convert.ToDecimal(textBox5.Text);
            GCRUD.VehicleUpdate(vehicle);
            dataGridView1.DataSource = GCRUD.VehicleList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.vehicleName = textBox2.Text;
            vehicle.vehicleCapacity = textBox3.Text;
            vehicle.vehicleDriver = textBox4.Text;
            vehicle.vehicleExpense = Convert.ToDecimal(textBox5.Text);
            GCRUD.VehicleAdd(vehicle);
            dataGridView1.DataSource = GCRUD.VehicleList();
        }

        private void VehicleInterface_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Text = column.Cells["vehicleID"].Value.ToString();
            textBox2.Text = column.Cells["vehicleName"].Value.ToString();
            textBox3.Text = column.Cells["vehicleCapacity"].Value.ToString();
            textBox4.Text = column.Cells["vehicleDriver"].Value.ToString();
            textBox5.Text = column.Cells["vehicleExpense"].Value.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CargoUI go = new CargoUI();
            go.Show();
            this.Hide();
        }
    }
}
