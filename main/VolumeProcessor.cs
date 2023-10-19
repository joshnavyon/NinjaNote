using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiNote
{
    public class VolumeProcessor : SettingsProcessor
    {
        private List<string> _volume;

        public VolumeProcessor()
        {
            _volume = new List<string>() { "00", "20", "40", "60", "80", "100" };
            InitUI();
        }

        private void InitUI()
        {
            int fontSize = Settings.MediumFont;

            TextTitle = new EText()
            {
                X = 550,
                Y = 10,
                Selected = false,
                Text = "Volume:",
                FontSize = fontSize,
                Font = Settings.Font,
                Width = SplashKit.TextWidth("Volume:", Settings.Font, fontSize),
                Height = SplashKit.TextHeight("Volume:", Settings.Font, fontSize - 5),
            };

            for (int i = 0; i < _volume.Count; i++)
            {

                EText text = new EText()
                {
                    X = 550,
                    Y = 10 + ((i+1) * 20),
                    Selected = false,
                    Text = _volume[i],
                    FontSize = fontSize,
                    Font = Settings.Font,
                    Width = SplashKit.TextWidth(_volume[i], Settings.Font, fontSize),
                    Height = SplashKit.TextHeight(_volume[i], Settings.Font, fontSize - 5),
                };

                TextElement.Add(text);
            }

            TextElement.Last().Selected = true;
        }

        public new float SelectedElement()
        {
            if (float.TryParse(base.SelectedElement(), out float floatValue))
            {
                return floatValue / 100;
            }
            return 0.0f;
        }
    }
}

