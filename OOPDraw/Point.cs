using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    class Point : Shape_Point
    {
        public Point() : base()
        {

        }
        public Point(Point point) :base(point)
        {

        }
        public Point(float x, float y, Color color, byte size) :base(x, y, color, size)
        {

        }
        public override void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color, Size);
            gr.DrawLine(pen, X, Y, X + 1, Y);
        }
    }
}
