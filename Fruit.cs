using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    internal class Fruit
    {
        Random rand = new Random();
        public int X, Y;

        public void initFruit(int x, int y, int Width, int Height)
        {
            X = rand.Next(x + 1, x + Width);
            Y = rand.Next(y + 3, y + 2 + Height);
        }

        public void DellFruit()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(" ");
        }

        public void DrawFruit()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("F");
        }

        
    }
}
