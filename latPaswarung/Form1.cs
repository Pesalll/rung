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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            menu mn = new menu();

            if ((user.Equals("konz")&&pass.Equals("topap"))||(user.Equals("anu") && pass.Equals("inu")))
            {
                MessageBox.Show("Berhasil Login");
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda Gagal Login");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
