using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    static internal class Map
    {
        static private int X, Y;
        static private int Width, Height;
        static public void Setup(int x, int y, int width, int height)
        {
            X = x; 
            Y = y;
            Width = width; 
            Height = height;
        }
       
        static public void DrawMap()
        {

            // First Lin
            Console.SetCursorPosition(X +1, Y);
            for (int i = 0; i < Width - 2; i++)
            {
                Console.Write("=");
            }
            // Mini Menu Lin

            Console.SetCursorPosition(X, Y + 1);
            Console.WriteLine("S");
            Console.SetCursorPosition(X + Width -1, Y + 1);
            Console.WriteLine("S");


            Console.SetCursorPosition(X + 1, Y + 2);
            for (int i = 0; i < Width - 2; i++)
            {
                Console.Write("=");
            }


            // Sides
            for (int i = 0; i < Height - 3; i++)
            {
                Console.SetCursorPosition(X, Y+i + 3);
                Console.WriteLine("S");

                Console.SetCursorPosition(X + Width - 1, Y + i + 3);
                Console.WriteLine("S");
            }



            //last Lin
            Console.SetCursorPosition(X + 1, Y + Height);
            for (int i = 0; i < Width - 2; i++)
            {
                Console.Write("=");
            }

        }
    }
}
