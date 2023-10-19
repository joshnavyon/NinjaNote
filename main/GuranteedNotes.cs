
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiNote
{
    public class GuaranteedNotes
    {
        public static List<Note> MapNotes(int tileCount, List<Note> notes, float volume)
        {
            List<Note> returnNotes = new List<Note>();

            for (int i = 0; i < tileCount; i++)
            {
                if (i >= notes.Count) returnNotes.Add(new NullNote());
                else
                {
                    notes[i].SetVolume(volume);
                    returnNotes.Add(notes[i]);
                }
            }
             
            return returnNotes;

        }
    }
}
