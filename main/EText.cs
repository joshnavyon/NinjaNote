using System;
using SplashKitSDK;

namespace DigiNote
{
    public class EText
    {
        public float X { get; set; }
        public float Y { get; set; }
        public bool Selected { get; set; }
        public string Text { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int FontSize { get; set; }

        public bool Hover { get; set; }
        public string Font { get; set; }

        public bool MouseOver(Point2D mousePos)
        {
            return mousePos.X >= X && mousePos.X <= X + Width && mousePos.Y >= Y && mousePos.Y <= Y + Height;
        }
    }
}

