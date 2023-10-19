using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiNote
{
    public class Settings 
    {
        private Font _font;
        private string _fontName;
        private int _smallFont, _mediumFont, _bigFont;
        private Bitmap _arrowBitmap;
        public string Font { get => _fontName; }
        public int SmallFont { get => _smallFont; }
        public int MediumFont { get => _mediumFont; }
        public int BigFont { get => _bigFont; }


        public Settings() 
        {
            _fontName = "Mono";
            _font = SplashKit.LoadFont(_fontName, @"..\..\..\audioSource\pixelMono.ttf");
            _smallFont = 15;
            _mediumFont = 20;
            _bigFont = 25;
            _arrowBitmap = SplashKit.LoadBitmap("arrow", @"..\..\..\sprites\redArrowSmall.png");
        }
    }
}
