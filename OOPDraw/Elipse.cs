using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    class Elipse: Circle
    {
        protected float Width;
        public Elipse() : base()
        {
            Width = rnd.Next(0, 170);
        }
        public Elipse(Elipse elipse) : base(elipse)
        {
            Width = elipse.Width;
        }
        public Elipse(float x, float y, Color color, byte size, float rad, float width) : base(x,y, color, size, rad)
        {
            SetWidth(width);
        }
        public void SetWidth(float width)
        {
            Width = width;
        }
        public float GetWidth()
        {
            return Width;
        }
        public override void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color, Size);
            gr.DrawEllipse(pen, X, Y, Width, Rad);
        }
    }
}
