using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raktar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 loginablak = new Form2();
            loginablak.ShowDialog();
            termekekToolStripMenuItem.Enabled = true;
        }

        private void termekekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Termékek= new Form3();
            Termékek.ShowDialog();

        }

        private void statisztikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Eladás = new Form4();
            Eladás.ShowDialog();
        }

        private void statisztikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 Statisztika = new Form5();
            Statisztika.ShowDialog();
        }
    }
}
