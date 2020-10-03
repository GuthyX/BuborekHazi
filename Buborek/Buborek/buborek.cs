using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buborek
{
    class buborek
    {
        Graphics g  ;
        private int x;
        private int y;
        private int size;
        public buborek(int x, int y, int size, PictureBox vaszon)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            g = vaszon.CreateGraphics();
        }
        public void create()
        {           
            g.DrawEllipse(new Pen(Color.Red, 5), x, y, size, size);
        }
        public void Move(int counter,int x ,int y, PictureBox vaszon)
        {
            lock (g)
            { g.DrawEllipse(new Pen(Color.Red, 5), x, y, size, size); }
            if (counter >0 || counter > vaszon.Width )
            {
                Move(counter - 1, x + 1, y,vaszon);
               
            }
            Thread.Sleep(50000);
            g.Clear(Color.White);

        }
    }
}
