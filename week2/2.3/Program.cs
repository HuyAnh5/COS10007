using System;
using program;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);

            Shape myshape = new Shape();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myshape.Draw();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myshape.X = (float)SplashKit.MousePosition().X;
                    myshape.Y = (float)SplashKit.MousePosition().Y;
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    if (myshape.IsAt(SplashKit.MousePosition()))
                    {
                        myshape.Color = Color.RandomRGB(255);
                    }
                }

                

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }


    }
}
