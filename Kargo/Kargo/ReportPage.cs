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

namespace Kargo
{
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.ShipmentCustomer();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.ShipmentVehicle();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.ShipmentPersonel();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.CustomerShipmentPersonel();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.VehicleShipmentPersonel();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.VehicleShipmentPersonelCustomer();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Reports go = new Reports();
            go.Show();
            this.Hide();
        }
    }
}
