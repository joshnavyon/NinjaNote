using System;

using SplashKitSDK;


namespace DigiNote
{
    static class Win
    {
        public const int width = 700;
        public const int height = 500;
    }


    public class Program
    {
       
        public static void Main()
        {

            Window window = new Window("Test Window", Win.width, Win.height);
            MainPlayer mainPlayer = new MainPlayer();

            do
            {
                SplashKit.ProcessEvents();

                foreach (MouseInteractionHandler mouseHandler in mainPlayer.MouseHandler)
                {
                    mouseHandler.HandleMouseOver(SplashKit.MousePosition());
                }
                

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    foreach (MouseInteractionHandler mouseHandler in mainPlayer.MouseHandler)
                    {
                        mouseHandler.HandleMouseSelect(SplashKit.MousePosition());

                        if (mouseHandler.IsUIElementSelected(SplashKit.MousePosition()))
                        {
                            mainPlayer.UpdateInstrument();
                        };
                    }
                }

                for (int i = 0; i < mainPlayer.KeyBinds.Count; i++)
                {
                    if (SplashKit.KeyDown(mainPlayer.KeyBinds[i]))
                    {
                        mainPlayer.Play(i);
                    }
                    if (SplashKit.KeyReleased(mainPlayer.KeyBinds[i]))
                    {
                        mainPlayer.Stop(i);
                    }
                }


                SplashKit.ClearScreen(mainPlayer.Theme.BackgroundColor);

                mainPlayer.Draw();

                SplashKit.RefreshScreen();
            } while (!SplashKit.KeyDown(KeyCode.QKey));

        }
    }
}
