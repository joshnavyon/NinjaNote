using System;
using SplashKitSDK;

namespace DigiNote
{
    public class TileBlack : Tile
    {
        public override string Type => "Black";
        
        public TileBlack()
        {
            Color = Color.Black;
            Width = 20;
            Height = 80;
        }
    }
}

