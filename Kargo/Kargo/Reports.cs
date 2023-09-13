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
using DAL;
using BL;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace Kargo
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        SqlConnection coon = new SqlConnection("Server=DESKTOP-38T2N6J;Database=Cargo;Integrated Security=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand("select * from Personel", coon);
            XmlDocument xml = new XmlDocument();
            XmlElement root = xml.CreateElement("Personels");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement personel = xml.CreateElement("Personel");

                XmlAttribute personelNameSurname = xml.CreateAttribute("personelNameSurname");
                personelNameSurname.Value = reader["personelNameSurname"].ToString();

                XmlAttribute personelTask = xml.CreateAttribute("personelTask");
                personelTask.Value = reader["personelTask"].ToString();

                XmlAttribute personelTitle = xml.CreateAttribute("personelTitle");
                personelTitle.Value = reader["personelTitle"].ToString();

                XmlAttribute personelPhone = xml.CreateAttribute("personelPhone");
                personelPhone.Value = reader["personelPhone"].ToString();

                XmlAttribute personelMail = xml.CreateAttribute("personelMail");
                personelMail.Value = reader["personelMail"].ToString();

                XmlAttribute personelSalary = xml.CreateAttribute("personelSalary");
                personelSalary.Value = reader["personelSalary"].ToString();

                personel.Attributes.Append(personelNameSurname);
                personel.Attributes.Append(personelTask);
                personel.Attributes.Append(personelTitle);
                personel.Attributes.Append(personelPhone);
                personel.Attributes.Append(personelMail);
                personel.Attributes.Append(personelSalary);
                root.AppendChild(personel);
            }
            xml.AppendChild(root);
            string xmlname = textBox1.Text;
            xml.Save(xmlname);
            coon.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Customer", coon);
            coon.Open();
            XmlDocument xml = new XmlDocument();
            XmlElement root = xml.CreateElement("Customers");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement customer = xml.CreateElement("Customer");
                XmlAttribute customername = xml.CreateAttribute("customerNameSurname");
                customername.Value = reader["customerNameSurname"].ToString();

                XmlAttribute customerAdress = xml.CreateAttribute("customerAdress");
                customerAdress.Value = reader["customerAdress"].ToString();

                XmlAttribute customerPhone = xml.CreateAttribute("customerPhone");
                customerPhone.Value = reader["customerPhone"].ToString();

                XmlAttribute customerMail = xml.CreateAttribute("customerMail");
                customerMail.Value = reader["customerMail"].ToString();

                XmlAttribute customerPaymentStatus = xml.CreateAttribute("customerPaymentStatus");
                customerPaymentStatus.Value = reader["customerPaymentStatus"].ToString();

                customer.Attributes.Append(customername);
                customer.Attributes.Append(customerAdress);
                customer.Attributes.Append(customerPhone);
                customer.Attributes.Append(customerMail);
                customer.Attributes.Append(customerPaymentStatus);
                root.AppendChild(customer);
            }
            xml.AppendChild(root);
            string xmlname = textBox2.Text;
            xml.Save(xmlname);
            coon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand("select * from Shipment", coon);
            XmlDocument xml = new XmlDocument();
            XmlElement root = xml.CreateElement("Shipments");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement shipment = xml.CreateElement("Shipment");
                XmlAttribute shipmentName = xml.CreateAttribute("shipmentName");
                shipmentName.Value = reader["shipmentName"].ToString();

                XmlAttribute shipmentPickupPoint = xml.CreateAttribute("shipmentPickupPoint");
                shipmentPickupPoint.Value = reader["shipmentPickupPoint"].ToString();

                XmlAttribute shipmentTransportationPoint = xml.CreateAttribute("shipmentTransportationPoint");
                shipmentTransportationPoint.Value = reader["shipmentTransportationPoint"].ToString();

                XmlAttribute shipmentDistance = xml.CreateAttribute("shipmentDistance");
                shipmentDistance.Value = reader["shipmentDistance"].ToString();

                XmlAttribute shipmentFee = xml.CreateAttribute("shipmentFee");
                shipmentFee.Value = reader["shipmentFee"].ToString();

                shipment.Attributes.Append(shipmentName);
                shipment.Attributes.Append(shipmentPickupPoint);
                shipment.Attributes.Append(shipmentTransportationPoint);
                shipment.Attributes.Append(shipmentDistance);
                shipment.Attributes.Append(shipmentFee);
                root.AppendChild(shipment);
            }
            xml.AppendChild(root);
            string xmlname = textBox3.Text;
            xml.Save(xmlname);
            coon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand("select * from Vehicle", coon);
            XmlDocument xml = new XmlDocument();
            XmlElement root = xml.CreateElement("Vehicles");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement vehicle = xml.CreateElement("Vehicle");
                
                XmlAttribute vehicleName = xml.CreateAttribute("vehicleName");
                vehicleName.Value = reader["vehicleName"].ToString();

                XmlAttribute vehicleCapacity = xml.CreateAttribute("vehicleCapacity");
                vehicleCapacity.Value = reader["vehicleCapacity"].ToString();

                XmlAttribute vehicleDriver = xml.CreateAttribute("vehicleDriver");
                vehicleDriver.Value = reader["vehicleDriver"].ToString();

                XmlAttribute vehicleExpense = xml.CreateAttribute("vehicleExpense");
                vehicleExpense.Value = reader["vehicleExpense"].ToString();

                vehicle.Attributes.Append(vehicleName);
                vehicle.Attributes.Append(vehicleCapacity);
                vehicle.Attributes.Append(vehicleDriver);
                vehicle.Attributes.Append(vehicleExpense);
                root.AppendChild(vehicle);
            }
            xml.AppendChild(root);
            string xmlname = textBox4.Text;
            xml.Save(xmlname);
            coon.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportResultPage go = new ReportResultPage();
            go.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportPage go = new ReportPage();
            go.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CargoUI go = new CargoUI();
            go.Show();
            this.Hide();
        }
    }
}
