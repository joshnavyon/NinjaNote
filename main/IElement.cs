using System;
using SplashKitSDK;

namespace DigiNote
{
    public interface IElement
    {
        public float X { get; set; }
        public float Y { get; set; }
        public bool Selected { get; set; }

        public bool Hover { get; set; }
        public void Draw() { }
    }
}

