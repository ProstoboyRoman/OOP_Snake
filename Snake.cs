using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Snake
{
    internal class Snake
    {
        Point P1 = new Point(15, 10);

        List<Point> mySnake = new List<Point>();

        enum Dir
        {
            STOP,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        
        private Dir myDir = Dir.UP;

        public void AddSnakeBody()
        {
            mySnake.Add(P1);
            mySnake.Add(new Point(P1.X, P1.Y + 1));
        }


        public void DrawSnake()
        {
            Console.SetCursorPosition(P1.X, P1.Y);

            foreach (var item in mySnake)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write("A");
            }

        }

        public void MoveSnake()
        {
            if (true)
            {
                mySnake.Add(new Point(mySnake[0].X, mySnake[0].Y + 1));
                //mySnake.RemoveAt(mySnake.Count -1);
            }  
        }
    }
}
