using System;
using SplashKitSDK;

namespace DigiNote
{

	public abstract class Tile : ERectangle
	{
		private int _position;
		private string _name;
		private Note? _notes;
		private KeyCode _key;


		public int Position
		{
			get { return _position; }
			set { _position = value; }
		}

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public KeyCode Key
		{
			get => _key; 
			set => _key = value;
		}

		public abstract string Type { get; }
		public Tile() : this("Unknown", 0, null) { }

		public Tile(string name, int position, Note note)
		{
			_name = name;
			_position = position;
			_notes = note;
			_key = KeyCode.UnknownKey;
		}

		public void Draw()
		{

			base.Draw();
		}
	}
}

