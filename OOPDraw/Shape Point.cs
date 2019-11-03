using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    public abstract class Shape_Point
    {
        protected float X;
        protected float Y;
        protected Color Color = new Color();
        protected byte Size;
        protected Random rnd = new Random();

        public Shape_Point()
        {
            X = rnd.Next(0, 700);
            Y = rnd.Next(0, 300);
            Color = Color.Red;
            Size = 3;
        }

        public Shape_Point(Shape_Point sp)
        {
            X = sp.X;
            Y = sp.Y;
            Color = sp.Color;
            Size = sp.Size;
        }
        public Shape_Point(float x, float y, Color color, byte size)
        {
            SetX(x);
            SetY(y);
            SetColor(color);
        }
        public void SetX(float x)
        {
            X = x;
        }
        public void SetY(float y)
        {
            Y = y;
        }
        public void SetColor(Color color)
        {
            Color = color;
        }
        public void SetSize(byte size)
        {
            Size = size;
        }
        public float GetX()
        {
            return X;
        }
        public float GetY()
        {
            return Y;
        }
        public Color GetColor()
        {
            return Color;
        }
        public byte GetSize()
        {
            return Size;
        }
        public abstract void Draw(Graphics gr);
    }
}
