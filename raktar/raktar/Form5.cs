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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.ColumnCount = 2;
                    dataGridView1.Columns[0].Name = "Termék";
                    dataGridView1.Columns[1].Name = "Összmennyiség";

                    StreamReader sr = new StreamReader("eladasok.txt");
                    while (!sr.EndOfStream)
                    {
                        string[] darabok = sr.ReadLine().Split(' ');
                        dataGridView1.Rows.Add(darabok);

                    }
                    sr.Close();
                }
            

        }
    }
}
