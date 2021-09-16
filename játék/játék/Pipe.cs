using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace játék
{
    class Pipe
    {
        public int pipeSpeed;
        public PictureBox pipe;
        public bool behind;

        public Pipe(int pipeSpeed, PictureBox pipe, bool behind = false)
        {
            this.pipeSpeed = pipeSpeed;
            this.pipe = pipe;
            this.behind = behind;
        }
    }
}
