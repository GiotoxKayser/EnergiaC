using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        int x = 150;
        int y = 100;
        int dx = 3;
        int dy = 2;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(paintBall);
            this.DoubleBuffered = true;
        }
        private void paintBall(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            SolidBrush blueBallBrush = new SolidBrush(Color.Blue);
            graphics.FillEllipse(blueBallBrush, x, y, 10, 10);
        }
        private void MoveBall()
        {
            int newBall_x = x + dx;
            int newBall_y = y + dy;

            if (newBall_x < -5 || newBall_x > this.ClientSize.Width) dx = -dx;
            if (newBall_y < 0 || newBall_y > this.ClientSize.Height) dy = -dy;

            x += dx;
            y += dy;
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveBall();
        }
    }
}
