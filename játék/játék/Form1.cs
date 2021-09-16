using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace játék
{
    public partial class Form1 : Form
    {
        List<Pipe> PipeList = new List<Pipe>();

        int gravity = -15;
        int score = 0;
        Random r = new Random();





        public Form1()
        {
            InitializeComponent();
            PipeList.Add(new Pipe(4, pipe));
            PipeList.Add(new Pipe(4, pipedown));
            PipeList.Add(new Pipe(4, pipedown2));
            PipeList.Add(new Pipe(4, pipe));
            PipeList.Add(new Pipe(4, pipedown));
            PipeList.Add(new Pipe(4, pipedown2));
            PipeList.Add(new Pipe(4, pipe));
            PipeList.Add(new Pipe(4, pipedown));
            PipeList.Add(new Pipe(4, pipedown2));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;

            for (int i = 0; i < PipeList.Count; i++)
            {
                PipeList[i].pipe.Left -= PipeList[i].pipeSpeed;
            }

            Respawn();
            
        }

        private void gameTimerEvent(object sender,EventArgs e)
        {

            bird.Top += gravity;
            for (int i = 0; i < PipeList.Count; i++)
            {
                PipeList[i].pipe.Left -= PipeList[i].pipeSpeed;
            }




        }

        private void gamekeyisdown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            { 
                gravity = -15;
            }



        }

        private void gamekeyisup(object sender,KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            if (e.KeyCode == Keys.W)
            {
                gravity = +15;
            }

      
        }

        private void Respawn()
        {
            foreach (Pipe item in PipeList)
            {
                if (item.pipe.Left <= -100)
                {
                    item.pipe.Left = r.Next(893, 1200);
                }
            }
        }
    }
}
