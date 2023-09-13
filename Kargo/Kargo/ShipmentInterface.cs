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
using DAL;
using System.Data.SqlClient;

namespace Kargo
{
    public partial class ShipmentInterface : Form
    {
        public ShipmentInterface()
        {
            InitializeComponent();
        }

        private void ShipmentInterface_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=GCRUD.ShipmentList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            shipment.shipmentName = textBox7.Text;
            dataGridView1.DataSource = GCRUD.ShipmentSearch(shipment);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            shipment.shipmentID = Convert.ToInt32(textBox1.Text);
            shipment.shipmentName = textBox2.Text;
            shipment.shipmentPickupPoint = textBox3.Text;
            shipment.shipmentTransportationPoint = textBox4.Text;
            shipment.shipmentDistance = Convert.ToInt32(textBox5.Text);
            shipment.shipmentFee = Convert.ToDecimal(textBox6.Text);
            shipment.customerID = Convert.ToInt32(textBox8.Text);
            shipment.personelID = Convert.ToInt32(textBox9.Text);
            shipment.vehicleID= Convert.ToInt32(textBox10.Text);
            GCRUD.ShipmentUpdate(shipment);
            dataGridView1.DataSource = GCRUD.ShipmentList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Text = column.Cells["shipmentID"].Value.ToString();
            textBox2.Text = column.Cells["shipmentName"].Value.ToString();
            textBox3.Text = column.Cells["shipmentPickupPoint"].Value.ToString();
            textBox4.Text = column.Cells["shipmentTransportationPoint"].Value.ToString();
            textBox5.Text = column.Cells["shipmentDistance"].Value.ToString();
            textBox6.Text = column.Cells["shipmentFee"].Value.ToString();
            textBox8.Text = column.Cells["customerID"].Value.ToString();
            textBox9.Text = column.Cells["personelID"].Value.ToString();
            textBox10.Text = column.Cells["vehicleID"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            shipment.shipmentName = textBox2.Text;
            shipment.shipmentPickupPoint = textBox3.Text;
            shipment.shipmentTransportationPoint = textBox4.Text;
            shipment.shipmentDistance = Convert.ToInt32(textBox5.Text);
            shipment.shipmentFee = Convert.ToDecimal(textBox6.Text);
            shipment.customerID = Convert.ToInt32(textBox8.Text);
            shipment.personelID = Convert.ToInt32(textBox9.Text);
            shipment.vehicleID = Convert.ToInt32(textBox10.Text);
            GCRUD.ShipmentAdd(shipment);
            dataGridView1.DataSource = GCRUD.ShipmentList();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CargoUI go = new CargoUI();
            go.Show();
            this.Hide();
        }
    }
}
