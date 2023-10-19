using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiNote
{
    public class MouseInteractionHandler
    {
        private List<EText> _textElements;

        public MouseInteractionHandler(List<EText> textElements)
        {
            _textElements = textElements;
        }

        public void HandleMouseOver(Point2D pt)
        {
            foreach (EText text in _textElements)
            {
                text.Hover = text.MouseOver(pt);
            }
        }

        public void HandleMouseSelect(Point2D pt)
        {
            if (IsUIElementSelected(pt))
            {
                foreach (EText text in _textElements)
                {
                    text.Selected = text.MouseOver(pt);
                }
            }
        }

        public bool IsUIElementSelected(Point2D pt)
        {
            foreach (EText text in _textElements)
            {
                if (text.MouseOver(pt))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
