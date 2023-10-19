using System;
using SplashKitSDK;

namespace DigiNote
{
	public class ERectangle
	{

        public float X { get; set; }
        public float Y { get; set; }
        public bool Selected { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public bool Hover { get; set; }
       

        public ERectangle() : this(Color.Black, 0, 0, 100, 100) { }
		public ERectangle(Color clr, int x, int y, int width, int height)
		{
			Color = clr;
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}

        public void Draw(Color clr)
        {
            SplashKit.FillRectangle(clr, X, Y, Width, Height);
        }
        public void Draw()
        {
            Draw(Color.White);
        }

        public void DrawOutline(Color clr)
        {
            SplashKit.FillRectangle(clr, X - 2, Y - 2, Width + 4, Height + 4);
         
        }
        public void DrawOutline()
        {
            DrawOutline(Color.Black);
        }
    
        public bool isAt(Point2D pt)
        {
            return ((pt.X >= X && pt.X <= Width) && (pt.Y > Y && pt.Y < Height));
        }
    }
}

