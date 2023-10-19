	using System;
using SplashKitSDK;

namespace DigiNote
{
	public abstract class Instrument
	{
		private List<Note> _notes;
		private string _name;
		private string _description;
		private string _folderPath;
		public string Name => _name;
		public string Description => _description;
		public string FolderPath 
		{
			get => _folderPath;
			set => _folderPath = value;
		}

		public List<Note> Notes => _notes;

        public Instrument(string name, string description, string audioPath)
		{
			_name = name.ToLower();
			_description = description;
			_folderPath = audioPath;
			_notes = new List<Note>();
			
        }

      

		public void Play(int note)
		{
			_notes[note].Play();
		}

		public void Stop(int note)
		{
			_notes[note].Stop();
		}

		public bool AreYou(string id)
		{
			if (_name == id)
			{
				return true;
			}
			return false;
		}
	}
}

