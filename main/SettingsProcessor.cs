using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DigiNote
{
    public class SettingsProcessor
    {

        private DrawingOptions _ops;
        private List<EText> _textElement;
        private EText _textTitle;
        private Settings _settings;

        public List<EText> TextElement
        {
            get { return _textElement; }
        }

        public EText TextTitle
        { get { return _textTitle; } 
          set { _textTitle = value; }
        }

        public Settings Settings
        { get { return _settings; } }
        public SettingsProcessor()
        {
            _settings = new Settings();
            _ops = SplashKit.OptionScaleBmp(0.7, 0.7);
            _textElement = new List<EText>();
            _textTitle = new EText();
        }
        public void DrawUI(Color textColor)
        {
            SplashKit.DrawText(TextTitle.Text, textColor, TextTitle.Font, TextTitle.FontSize, TextTitle.X, TextTitle.Y);

            foreach (EText text in _textElement)
            {
                if (text.Hover || text.Selected)
                {
                    SplashKit.DrawBitmap("arrow", text.X - 30, text.Y - 3, _ops);
                }

                SplashKit.DrawText(text.Text, textColor, text.Font, text.FontSize, text.X, text.Y);
            }
        }
        public void DrawUI()
        {
            DrawUI(Color.Black);
        }

        public string SelectedElement()
        {
            foreach (EText text in TextElement)
            {
                if (text.Selected)
                {
                    return text.Text;
                }
            }
            return null;
        }
    }
}

