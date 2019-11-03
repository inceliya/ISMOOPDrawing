using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    class Rectangle: Line
    {
        public Rectangle(): base()
        {

        }
        public Rectangle(Rectangle rectangle) : base(rectangle)
        {

        }
        public Rectangle(float x, float y, Color color, byte size, float x1, float y1) : base(x,y,color,size,x1,y1)
        {

        }
        public override void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color, Size);
            gr.DrawRectangle(pen, X, Y, Math.Abs(X1-X), Math.Abs(Y1-Y));
        }
    }
}
