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
            Console.SetCursorPosition(X, Y);
            Console.Write("G");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("=");
            }
            Console.Write("G");

            // Mini Menu Lin
            Console.SetCursorPosition(X, Y + 1);
            Console.WriteLine("S");
            Console.SetCursorPosition(X + Width +1, Y + 1);
            Console.WriteLine("S");


            Console.SetCursorPosition(X, Y + 2);
            Console.Write("T");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("=");
            }
            Console.Write("T");


            // Sides
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i + 3);
                Console.WriteLine("S");

                Console.SetCursorPosition(X + Width + 1, Y + i + 3);
                Console.WriteLine("S");
            }



            //last Lin
            Console.SetCursorPosition(X, Y + Height +3);
            Console.Write("G");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("=");
            }
            Console.Write("G");

            Console.SetCursorPosition(X + 2, Y + 1);
            Console.WriteLine("Snake Game");
        }
        static public void DellGameScreen()
        {
            
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X +1, Y + i + 3);
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
