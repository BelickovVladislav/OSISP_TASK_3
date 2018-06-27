using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSISP_TASK_3
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;
        private bool draw;
        private int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            draw = false;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                g.DrawLine(pen, x, y, e.X, e.Y);
            }
            x = e.X;
            y = e.Y;
        }
    }
}
