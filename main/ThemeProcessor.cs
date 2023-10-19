using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DigiNote
{
    public class ThemeProcessor : SettingsProcessor
    {
        private List<Theme> _theme;

        public ThemeProcessor()
        {
            _theme = new List<Theme>() 
            { 
                new Theme("Default", Color.Black, Color.White, Color.White, Color.Black, Color.Black),
                new Theme("Dark Mode", Color.White, Color.Black, Color.Black, Color.White, Color.White),
                new Theme("Golden Symphony", Color.Gold, Color.Black, Color.Yellow, Color.SaddleBrown, Color.DarkGoldenrod),
                new Theme("Mystic Twilight", Color.HotPink, Color.Lavender, Color.PaleGreen, Color.Magenta, Color.Purple)
            };
            InitUI();
        }

        private void InitUI()
        {
            int fontSize = Settings.MediumFont;

            TextTitle = new EText()
            {
                X = Win.width/2 - 75,
                Y = 10,
                Selected = false,
                Text = "Theme:",
                FontSize = fontSize,
                Font = Settings.Font,
                Width = SplashKit.TextWidth("Theme:", Settings.Font, fontSize),
                Height = SplashKit.TextHeight("Theme:", Settings.Font, fontSize - 5),
            };

            for (int i = 0; i < _theme.Count; i++)
            {

                EText text = new EText()
                {
                    X = Win.width/2 - 75,
                    Y = 10 + ((i+1) * 20),
                    Selected = false,
                    Text = _theme[i].Name,
                    FontSize = fontSize,
                    Font = Settings.Font,
                    Width = SplashKit.TextWidth(_theme[i].Name, Settings.Font, fontSize),
                    Height = SplashKit.TextHeight(_theme[i].Name, Settings.Font, fontSize - 5),
                };

                TextElement.Add(text);
            }

            TextElement.First().Selected = true;
        }

        public Theme GetTheme()
        {
            foreach (Theme theme in _theme)
            {
                if (theme.AreYou(SelectedElement()))
                {
                    return theme;
                }
            }
            return null;
        }
    }
}

