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
    public partial class PersonelInterface : Form
    {
        public PersonelInterface()
        {
            InitializeComponent();
        }

        private void PersonelInterface_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.PersonelList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.personelNameSurname = textBox8.Text;
            dataGridView1.DataSource = GCRUD.PersonelSearch(personel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Text = column.Cells["personelID"].Value.ToString();
            textBox2.Text = column.Cells["personelNameSurname"].Value.ToString();
            textBox3.Text = column.Cells["personelTask"].Value.ToString();
            textBox4.Text = column.Cells["personelTitle"].Value.ToString();
            textBox5.Text = column.Cells["personelPhone"].Value.ToString();
            textBox6.Text = column.Cells["personelMail"].Value.ToString();
            textBox7.Text = column.Cells["personelSalary"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.personelNameSurname = textBox2.Text;
            personel.personelTask = textBox3.Text;
            personel.personelTitle= textBox4.Text;
            personel.personelPhone = textBox5.Text;
            personel.personelMail = textBox6.Text;
            personel.personelSalary = Convert.ToDecimal(textBox7.Text);
            GCRUD.PersonelAdd(personel);
            dataGridView1.DataSource = GCRUD.PersonelList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.personelID = Convert.ToInt32(textBox1.Text);
            GCRUD.PersonelDel(personel);
            dataGridView1.DataSource = GCRUD.PersonelList();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CargoUI go = new CargoUI();
            go.Show();
            this.Hide();
        }
    }
}
