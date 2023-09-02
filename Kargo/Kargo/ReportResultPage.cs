using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kargo
{
    public partial class ReportResultPage : Form
    {
        public ReportResultPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            DataSet dataSet = new DataSet();
            XmlReader xmlFile = XmlReader.Create(@"personel.xml",new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            dataGridView1.DataSource = dataSet.Tables[0];
            xmlFile.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"customer.xml",new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            dataGridView1.DataSource = dataSet.Tables[0];
            xmlFile.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            DataSet dataSet = new DataSet();
            XmlReader xmlFile = XmlReader.Create(@"shipment.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            dataGridView1.DataSource = dataSet.Tables[0];
            xmlFile.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            DataSet dataSet = new DataSet();
            XmlReader xmlFile = XmlReader.Create(@"vehicle.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            dataGridView1.DataSource = dataSet.Tables[0];
            xmlFile.Close();
        }
    }
}
