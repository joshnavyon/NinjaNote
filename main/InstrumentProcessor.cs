using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DigiNote
{
    public class InstrumentProcessor : SettingsProcessor
    {

        private List<Instrument> _instrument;

        public InstrumentProcessor()
        {
            _instrument = new List<Instrument>() 
            { 
                new Piano("piano", "*piano desc", @""), 
                new Guitar("guitar", "*guitar desc", @""), 
                new Kalimba("kalimba", "*kalimba desc", @"")
            };
            InitUI();
        }

        private void InitUI()
        {
            int fontSize = Settings.MediumFont;

            TextTitle = new EText()
            {
                X = 40,
                Y = 10,
                Selected = false,
                Text = "Instrument:",
                FontSize = fontSize,
                Font = Settings.Font,
                Width = SplashKit.TextWidth("Instrument:", Settings.Font, fontSize),
                Height = SplashKit.TextHeight("Instrument:", Settings.Font, fontSize - 5),
            };

            for (int i = 0; i < _instrument.Count; i++)
            {

                EText text = new EText()
                {
                    X = 40,
                    Y = 10 + ((i+1) * 20),
                    Selected = false,
                    Text = _instrument[i].Name,
                    FontSize = fontSize,
                    Font = Settings.Font,
                    Width = SplashKit.TextWidth(_instrument[i].Name, Settings.Font, fontSize),
                    Height = SplashKit.TextHeight(_instrument[i].Name, Settings.Font, fontSize - 5),
                };

                TextElement.Add(text);
            }

            TextElement[0].Selected = true;
        }

        public Instrument GetInstrument()
        {
            foreach (Instrument instrument in _instrument)
            {
                if (instrument.AreYou(SelectedElement()))
                {
                    return instrument;
                }
            }
            return null;
        }
    }
}

