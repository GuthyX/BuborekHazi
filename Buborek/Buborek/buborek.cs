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
        Random rnd;
        Graphics g  ;
        private int x;
        private int y;
        private int size;
        int timer = 0;
        int moves;
        int speed;
        public buborek(int x, int y, int size, PictureBox vaszon)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            g = vaszon.CreateGraphics();
            rnd = new Random();
            moves = rnd.Next(1,4);
            speed = rnd.Next(1,9000);
        }
        public void create()
        {
            lock (g)
            { g.DrawEllipse(new Pen(Color.Red, 5), x, y, size, size); }
          
        }
        public void Move(int x ,int y, PictureBox vaszon)
        {
           
            Thread.Sleep(50);
            g.Clear(Color.White);
            timer ++;
            lock (g)
            { g.DrawEllipse(new Pen(Color.Red, 5), x, y, size, size); }
            if (timer <= 200)
            {
                switch (moves)
                {
                    case 1:                   
                        Move(x + 1, y, vaszon);
                        break;
                    case 2:                  
                        Move(x -1, y, vaszon);
                        break;
                    case 3:                    
                        Move(x , y+1, vaszon);
                        break;
                    case 4:
                        Move(x , y-1, vaszon);
                        break;
                    default:
                        break;
                }
                if (vaszon.Width - size <= 0)
                {
                    g.Clear(Color.White);
                   
                }

            }
            else
                g.Clear(Color.White);
        

        }
        public void Bubi()
        {
           
            create();
        }
    }
}
