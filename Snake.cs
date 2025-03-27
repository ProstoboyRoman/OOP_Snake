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
        
        private Dir myDir = Dir.LEFT;

        public void AddSnakeBody()
        {
            mySnake.Add(P1);
            mySnake.Add(new Point(P1.X, P1.Y + 1));
            mySnake.Add(new Point(P1.X, P1.Y + 2));
        }


        public void DrawSnake()
        {
            Console.SetCursorPosition(P1.X, P1.Y);

            foreach (var item in mySnake)
            {
                if (item == mySnake[0])
                {
                    Console.SetCursorPosition(item.X, item.Y);
                    Console.Write("@");
                }
                else
                {
                    Console.SetCursorPosition(item.X, item.Y);
                    Console.Write("A");
                }
                
            }

        }

        public void MoveSnake()
        {
            if (myDir == Dir.UP)
            {
                mySnake.Insert(0, new Point(mySnake[0].X, mySnake[0].Y - 1));
            }
            else if (myDir == Dir.DOWN)
            {
                mySnake.Insert(0, new Point(mySnake[0].X, mySnake[0].Y + 1));
            }
            else if (myDir == Dir.LEFT)
            {
                mySnake.Insert(0, new Point(mySnake[0].X - 1, mySnake[0].Y));
            }
            else if (myDir == Dir.RIGHT)
            {
                mySnake.Insert(0, new Point(mySnake[0].X + 1, mySnake[0].Y));
            }
            mySnake.RemoveAt(mySnake.Count - 1);
        }

        public void UserInput()
        {
        }
    }
}
