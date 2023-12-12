using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latPaswarung
{
    public partial class warung : Form
    {


        public warung()
        {
            InitializeComponent();
        }

        public string nama;
        public int harga, total;
        public int sum = 0;


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Yakin Ingin Log out ?", "log out", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                Form1 log = new Form1();
                log.Show();
                this.Hide();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void warung_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                nama = "Burger";
                int qty = Convert.ToInt32(numericUpDown1.Value);
                harga = 1000;
                total = harga * qty;
                this.dataGridView1.Rows.Add(nama, harga, qty, total);
            }
            if (checkBox2.Checked)
            {
                nama = "Burger";
                int qty = Convert.ToInt32(numericUpDown2.Value);
                harga = 1000;
                total = harga * qty;
                this.dataGridView1.Rows.Add(nama, harga, qty, total);
            }
            if (checkBox3.Checked)
            {
                nama = "Burger";
                int qty = Convert.ToInt32(numericUpDown3.Value);
                harga = 1000;
                total = harga * qty;
                this.dataGridView1.Rows.Add(nama, harga, qty, total);
            }
            if (checkBox4.Checked)
            {
                nama = "Burger";
                int qty = Convert.ToInt32(numericUpDown4.Value);
                harga = 1000;
                total = harga * qty;
                this.dataGridView1.Rows.Add(nama, harga, qty, total);
            }
            if (checkBox5.Checked)
            {
                nama = "Burger";
                int qty = Convert.ToInt32(numericUpDown5.Value);
                harga = 1000;
                total = harga * qty;
                this.dataGridView1.Rows.Add(nama, harga, qty, total);
            }
            if (checkBox6.Checked)
            {
                nama = "Burger";
                int qty = Convert.ToInt32(numericUpDown6.Value);
                harga = 1000;
                total = harga * qty;
                this.dataGridView1.Rows.Add(nama, harga, qty, total);
            }

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            textBox1.Text = sum.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            int bayar = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (bayar - total).ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            for(int i = 0; i < dataGridView1.Rows.Count;i++)
            {
                this.dataGridView1.Rows.RemoveAt(i);
            }

        }
    }
}
