using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using System.Runtime.InteropServices;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            int X = 200;
            int Y = 200;

            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            Shapes.Move(eat, X, Y);

            Random rnd = new Random();
            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= X && Turtle.X <= X+10 && Turtle.Y >= Y && Turtle.Y <= Y + 10)
                {
                    X = rnd.Next(0, GraphicsWindow.Width);
                    Y = rnd.Next(0, GraphicsWindow.Height);

                    Shapes.Move(eat, X , Y);
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
                Turtle.Angle = 0;
            else if (GraphicsWindow.LastKey == "Right")
                Turtle.Angle = 90;
            else if (GraphicsWindow.LastKey == "Down")
                Turtle.Angle = 180;
            else if (GraphicsWindow.LastKey == "Left")
                    Turtle.Angle = 270;
            
        }
    }
}
