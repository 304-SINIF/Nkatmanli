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
using EntityLayer;
using LogicLayer;

namespace katman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Namesurname = textBox2.Text;
            ent.City = textBox3.Text;
            ent.Department = textBox4.Text;
            ent.Wage = Convert.ToInt32(textBox5.Text);
            Logicresponse.perupdate(ent);
            listele();
        }
        void listele()
        {
            dataGridView1.DataSource = Logicresponse.Personellist();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
        Entity ent=new Entity();

        private void button1_Click(object sender, EventArgs e)
        {
            ent.Namesurname = textBox2.Text;
            ent.City=textBox3.Text;
            ent.Department=textBox4.Text;
            ent.Wage = Convert.ToInt32(textBox5.Text);
            Logicresponse.personek(ent);
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ent.Id = Convert.ToInt32(textBox1.Text);
            Logicresponse.personelsil(ent.Id);
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();  

        }
    }
}
