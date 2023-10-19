using System;
using SplashKitSDK;

namespace DigiNote
{
	public class MainPlayer 
	{
		private Tiles _tiles;
		private List<Note> _notes;
        private InstrumentProcessor _instrumentProcessor;
		private VolumeProcessor _volumeProcessor;
		private List<MouseInteractionHandler> _mouseHandler;
        private List<KeyCode> _keyBinds;
		private ThemeProcessor _themeProcessor;
		public List<KeyCode> KeyBinds 
		{
			get => _keyBinds;
		}

		public Theme Theme { get => _themeProcessor.GetTheme(); }

		public List<MouseInteractionHandler> MouseHandler { get => _mouseHandler; }
		public MainPlayer()
		{
			_tiles = new Tiles();
			_keyBinds = _tiles.MapKeyBind(
			new KeyCode[13]
			{
				KeyCode.AKey, KeyCode.WKey, KeyCode.SKey, KeyCode.EKey,
				KeyCode.DKey, KeyCode.FKey, KeyCode.TKey, KeyCode.GKey,
				KeyCode.YKey, KeyCode.HKey, KeyCode.UKey, KeyCode.JKey, KeyCode.KKey
			});
			_instrumentProcessor = new InstrumentProcessor();
			_volumeProcessor = new VolumeProcessor();
			_themeProcessor = new ThemeProcessor();
			_mouseHandler = new List<MouseInteractionHandler>()
			{
				new MouseInteractionHandler(_volumeProcessor.TextElement),
                new MouseInteractionHandler(_instrumentProcessor.TextElement),
                new MouseInteractionHandler(_themeProcessor.TextElement)
            };
            UpdateInstrument();
        }
           
		public void Draw()
		{
			_tiles.Draw(200, Win.height/2, Theme.WhiteTileColor, Theme.BlackTileColor, Theme.OutlineColor);
			_instrumentProcessor.DrawUI(Theme.TextColor);
			_volumeProcessor.DrawUI(Theme.TextColor);
			_themeProcessor.DrawUI(Theme.TextColor);
		}

		public void UpdateInstrument()
		{
            _notes = GuaranteedNotes.MapNotes(_tiles.GetTile.Count, _instrumentProcessor.GetInstrument().Notes, _volumeProcessor.SelectedElement());
        }

		public void Play(int i)
		{
			_notes[i].Play();
			_tiles.GetTile[i].Selected = true;
        }

		public void Stop(int i) 
		{
			_notes[i].Stop();
            _tiles.GetTile[i].Selected = false;
        }
		
	
	}
}

