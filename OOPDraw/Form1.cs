using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Cursor = Cursors.Arrow;
            InitializeComponent();
            pictureBox.Width = 760;
            pictureBox.Height = 380;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            Random rnd = new Random();
            Shape_Point[] shapes = new Shape_Point[20];
            for(int i = 0; i<shapes.Length; i++)
            {
                int shape = rnd.Next(1, 5);
                int x = rnd.Next(0, 700);
                int y = rnd.Next(0 ,300);
                int x1 = rnd.Next(0, 700);
                int y1 = rnd.Next(0, 300);
                int rad = rnd.Next(0, 170);
                int width = rnd.Next(0, 170);
                switch (shape)
                {
                    case 1:
                        {
                            shapes[i] = new Point(x, y, pen.Color, Convert.ToByte(pen.Width));
                            shapes[i].Draw(gr);
                        }break;
                    case 2:
                        {
                            shapes[i] = new Line(x, y, pen.Color, Convert.ToByte(pen.Width), x1, y1);
                            shapes[i].Draw(gr);
                        }
                        break;
                    case 3:
                        {
                            shapes[i] = new Rectangle(x, y, pen.Color, Convert.ToByte(pen.Width), x1, y1);
                            shapes[i].Draw(gr);
                        }
                        break;
                    case 4:
                        {
                            shapes[i] = new Circle(x, y, pen.Color, Convert.ToByte(pen.Width), rad);
                            shapes[i].Draw(gr);
                        }
                        break;
                    case 5:
                        {
                            shapes[i] = new Elipse(x, y, pen.Color, Convert.ToByte(pen.Width), width, rad);
                            shapes[i].Draw(gr);
                        }
                        break;
                }
            }
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
           pictureBox.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
