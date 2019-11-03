using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    class Circle: Point
    {
        protected float Rad;

        public Circle() : base()
        {
            Rad = rnd.Next(0, 170);
        }
        public Circle(Circle circle) : base(circle)
        {
            Rad = circle.Rad;
        }
        public Circle(float x, float y, Color color, byte size, float rad) : base(x,y,color,size)
        {
            SetRad(rad);
        }
        public void SetRad(float rad)
        {
            Rad = rad;
        }
        public float GetRad()
        {
            return Rad;
        }
        public override void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color, Size);
            gr.DrawEllipse(pen, X, Y, Rad, Rad);
        }
    }
}
