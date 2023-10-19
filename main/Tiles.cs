
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace DigiNote
{
    public class Tiles
    {
        private List<Tile>  _tiles;
        private int _start, _end;
        private int _x, _y;
        private List<KeyCode> _keyBinds;
        private readonly string[] notes = new string[7] { "C", "D", "E", "F", "G", "A", "B" };

        public List<Tile> GetTile
        {
            get { return _tiles; }
        }

        public Tiles() : this(23, 40) { }
        public Tiles(int start, int end) 
        {
            _tiles = new List<Tile>();
            _start = start;
            _end = end;
            _x = 0;
            _y = 0;
            _keyBinds = new List<KeyCode>();
            Add(_end - _start);
        }

        public List<KeyCode> MapKeyBind(KeyCode[] keyCode)
        {
            for (int i = 0; i < _tiles.Count; i++)
            {
                if (i < keyCode.Length)
                {
                    _tiles[i].Key = keyCode[i];
                    _keyBinds.Add(keyCode[i]);
                }
                else
                {
                    _keyBinds.Add(_tiles[i].Key);
                }
            }

            return _keyBinds;
        }

        private void AddProc()
        {
            
            int tileAt = 5 + _start + _tiles.Count(tile => tile is TileWhite);
            int position = tileAt / 7;
            int i = tileAt % 7;
           

            Tile whiteTile = new TileWhite();
            whiteTile.Name = notes[i];
            whiteTile.Position = position;
            whiteTile.X = _x + whiteTile.Width * _tiles.Count(tile => tile is TileWhite);
            whiteTile.Y = _y;

            _tiles.Add(whiteTile);

            switch (i)
            {
                case 2:
                case 6:
                case 7:
                    break;
                default:
                    TileBlack blackTile = new TileBlack();
                    blackTile.Name = notes[i] + "#";
                    blackTile.Position = position;
                    blackTile.X = _x + (new TileWhite().Width * _tiles.Count(tile => tile is TileWhite)) - blackTile.Width/2;
                    blackTile.Y = _y;
                    _tiles.Add(blackTile);
                    break;
            }
        }

        public void Add(int num)
        {
            for(int i =0; i < num; i++)
            {
                AddProc();
            }

            if (_tiles.Last().Type == "Black")
            {
                _tiles.RemoveAt(_tiles.Count - 1);
            }
        }

        public void Add()
        {
            Add(1);
        }

        public void Draw() { Draw(0, 0, Color.Black, Color.White, Color.Black); }
        public void Draw(int x, int y, Color whiteTile, Color blackTile, Color outline)
        {
            if (_x != x && _y != y)
            {
                _tiles = new List<Tile>();
                _x = x;
                _y = y;
                Add(_end - _start);
            }

            foreach (Tile tile in _tiles.Where(tile => tile is TileWhite))
            {
                tile.DrawOutline(outline);
                if (tile.Selected)
                {
                    tile.Draw(Color.LightPink);
                }
                else
                {
                    tile.Draw(whiteTile);
                }
                
            }

            foreach (Tile tile in _tiles.Where(tile => tile is TileBlack))
            {
                tile.DrawOutline(outline);
                if (tile.Selected)
                {
                    tile.Draw(Color.Red);
                }
                else
                {
                    tile.Draw(blackTile);
                }
                
            }
        } 
    }
}
