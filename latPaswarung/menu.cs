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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void warungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warung war = new warung();
            war.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Yakin Ingin Log out ?", "Log out", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes) {
                Form1 log = new Form1();
                log.Show();
                this.Hide();
            }   
        }
    }
}
