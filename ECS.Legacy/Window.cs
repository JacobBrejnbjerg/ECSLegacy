using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    public class Window : IWindow
    {
        public void OpenWindow()
        {
            System.Console.WriteLine("Window opened");

        }

        public void CloseWindow()
        {
            System.Console.WriteLine("Window closed");
        }
    }
}
