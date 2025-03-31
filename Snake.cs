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

        private int counter = 0; 

        enum Dir
        {
            STOP,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        
        private Dir myDir = Dir.STOP;

        private Dir LastDir = Dir.STOP;

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

        public void MoveSnake(bool RemoveLast)
        {
            counter ++;

            if (myDir == Dir.UP && counter % 2 == 0)
            {
                mySnake.Insert(0, new Point(mySnake[0].X, mySnake[0].Y - 1));
            }
            else if (myDir == Dir.DOWN && counter % 2 == 0)
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

            // Remove Last Teail 
            if (RemoveLast)
            {
                return;
            }
            else
            {
                if (myDir != Dir.STOP && (myDir != Dir.UP && myDir != Dir.DOWN))
                    mySnake.RemoveAt(mySnake.Count - 1);
                else if ((myDir == Dir.UP || myDir == Dir.DOWN) && counter % 2 == 0)
                    mySnake.RemoveAt(mySnake.Count - 1);
            }
        }

        public void UserInput() 
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow && myDir != Dir.LEFT)
                {
                    myDir = Dir.LEFT;
                }
                else if (key.Key == ConsoleKey.RightArrow && myDir != Dir.RIGHT)
                {
                    myDir = Dir.RIGHT;
                }
                else if (key.Key == ConsoleKey.UpArrow && myDir != Dir.UP)
                {
                    myDir = Dir.UP;
                }
                else if (key.Key == ConsoleKey.DownArrow && myDir != Dir.DOWN)
                {
                    myDir = Dir.DOWN;
                }
            }
        }

        public void CeckMapColision (int X, int Y, int Width, int Height)
        {
            if ((mySnake[0].X <= X + 1 && myDir == Dir.LEFT) || (mySnake[0].X >= X + Width && myDir == Dir.RIGHT))
            {
                myDir = Dir.STOP;
            }
            else if ((mySnake[0].Y <= Y + 3 && myDir == Dir.UP) || (mySnake[0].Y >= Y + 2 + Height && myDir == Dir.DOWN))
            {
                myDir = Dir.STOP;
            }

        }

        public void CheckSelfColision()
        {
            // Cant check without fruits
        }

        public bool CheckFruit(Fruit myFruit)
        {
            if (mySnake[0].X == myFruit.X && mySnake[0].Y == myFruit.Y)
            {
                return true;
            }
            return false;
        }
    }
}
