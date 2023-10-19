using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK; 

namespace DigiNote
{

    public class Theme
    {
        private Color _bgColor;
        private Color _whiteTileColor;
        private Color _blackTileColor;
        private Color _textColor;
        private Color _outlineColor;
        private string _id;

        public Color TextColor
        {
            get { return _textColor; }
        }


        public Color BackgroundColor
        {
            get { return _bgColor; }
        }

        public Color WhiteTileColor
        {
            get { return _whiteTileColor; }
        }

        public Color BlackTileColor
        {
            get { return _blackTileColor; }
        }

        public Color OutlineColor
        {
            get { return _outlineColor; }
        }

        public string Name
        {
            get { return _id; } 
        }

        public Theme(string id, Color text,Color background, Color whiteTile, Color blackTile, Color outline) 
        {
            _id = id;
            _textColor = text;
            _bgColor = background;
            _whiteTileColor = whiteTile;
            _blackTileColor = blackTile;
            _outlineColor = outline;
        }

        public bool AreYou(string id)
        {
            if (_id == id)
            {
                return true;
            }
            return false;
        }
    }
}
