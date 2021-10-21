using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raktar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("termekek.txt");
          
            while (!sr.EndOfStream)

            {
               
                string s = sr.ReadLine();
                comboBox1.Items.Add(s);
            }
            sr.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("eladasok.txt", true);
            sw.WriteLine("A szöveg amit összeállítottál a szövegdobozokból!");
            sw.Close();
        }
    }
}
