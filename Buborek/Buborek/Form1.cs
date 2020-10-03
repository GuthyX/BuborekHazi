using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buborek
{
    
    public partial class Form1 : Form
    {
       
        Random rnd;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = vaszon.CreateGraphics();
            rnd = new Random();
        }

        private void vaszon_Click(object sender, EventArgs e)
        {
       
        }

        private void vaszon_MouseClick(object sender, MouseEventArgs e)
        {
            int size = rnd.Next(1, 100);
            buborek b = new buborek(e.Location.X,e.Location.Y,size, vaszon);
            //Thread t1 = new Thread(() => b.create());
            Thread t2 = new Thread(() => b.Move(e.Location.X, e.Location.Y, size, vaszon));
            //t1.Start();
            t2.Start();
        }

        private void vaszon_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
      
    }
    class Buborek
    {
     


    }
}
