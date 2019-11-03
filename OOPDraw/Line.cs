using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    class Line: Point
    {
        protected float X1;
        protected float Y1;
        public Line() : base()
        {
            X1 = rnd.Next(0, 700);
            Y1 = rnd.Next(0, 300);
        }
        public Line(Line line) : base(line)
        {
            X1 = line.X1;
            Y1 = line.Y1;
        }
        public Line(float x, float y, Color color, byte size, float x1, float y1) : base(x, y, color, size)
        {
            SetX1(x1);
            SetY1(y1);
        }
        public void SetX1(float x1)
        {
            X1 = x1;
        }
        public void SetY1(float y1)
        {
            Y1 = y1;
        }
        public float GetX1()
        {
            return X1;
        }
        public float GetY1()
        {
            return Y1;
        }
        public override void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color, Size);
            gr.DrawLine(pen, X, Y, X1, Y1);
        }
    }
}
