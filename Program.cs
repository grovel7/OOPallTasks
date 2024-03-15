using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            //local variable of type Shape

            Shape myShape = new Shape();
            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                //check if the left button is clicked

                if(SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }

                //check if user and clicked the spacebar or not

                //if(SplashKit.KeyTyped(KeyCode.SpaceKey))
                //{
                //    if (myShape.IsAt(SplashKit.MousePosition())
                //        {
                //        myShape.Color = Color.Random();
                //        }
                //}
                if (myShape.IsAt(SplashKit.MousePosition()))
                {
                    if (SplashKit.KeyDown(KeyCode.SpaceKey))
                    {
                        myShape.Color = Color.RandomRGB(255);
                    }
                }

                //draw itself

                myShape.Draw();
                //screen is refreshed
                SplashKit.RefreshScreen();


            }
            while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }
}
