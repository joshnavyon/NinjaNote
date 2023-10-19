using System;
using SplashKitSDK;

namespace DigiNote
{
    public class TileWhite : Tile
    {
        public override string Type
        {
            get => "White";
        }

        public TileWhite() 
        {
            Color = Color.White;
            Width = 40;
            Height = 160;
        }
    }
}

