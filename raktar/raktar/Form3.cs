using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace raktar
{
    public partial class Form3 : Form
    {
        List<termek> termeklista = new List<termek>();

        public Form3()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            {
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Cíkkszám";
                dataGridView1.Columns[1].Name = "Terméknév";

                StreamReader sr = new StreamReader("termekek.txt");
                while (!sr.EndOfStream)
                {
                    string[] darabok = sr.ReadLine().Split(';');
                    dataGridView1.Rows.Add(darabok);
                    termek t = new termek();
                    t.cikkszam = Convert.ToInt32( darabok[0]);
                    t.termeknev = darabok[1];
                    termeklista.Add(t);

                }
                sr.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bekertszam = Convert.ToInt32(textBox3.Text);
            int torolindex = -1;
            for (int i = 0; i < termeklista.Count; i++)
            {
                if (termeklista[i].cikkszam==bekertszam)
                {
                    torolindex = i;

                }
            }
            termeklista.RemoveAt(torolindex);
            StreamWriter sw = new StreamWriter("termekek.txt",false);
            foreach (var item in termeklista)
            { sw.WriteLine(item.cikkszam + ";" + item.termeknev); }
            sw.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            termeklista.RemoveAt();
            StreamWriter sw = new StreamWriter("termekek.txt", false);
            foreach (var item in termeklista)
            { sw.WriteLine(item.cikkszam + ";" + item.termeknev); }
            sw.Close();

        }
    }
}
