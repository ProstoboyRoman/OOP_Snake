using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    static internal class Start_Menu
    {
        static int X,Y;

        enum Menu
        {
            Start,
            Infos,
            Exit
        }

        static private Menu Pos = Menu.Start;

        static public void Setup(int x, int y)
        {
            X = x;
            Y = y;
        }

        static public void text()
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine("Snake Game");
        }

        static public void ShowMenu()
        {
            for (int i = 0; i < Enum.GetNames(typeof(Menu)).Length; i++)
            {
                Menu menuOption = (Menu)i;

                if (menuOption == Pos)
                {
                    // Auswahl hervorheben
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.SetCursorPosition(X, Y + i); // Position für die Menüoption setzen
                    Console.WriteLine(">" + menuOption);
                }
                else
                {
                    // Standardfarben verwenden
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.SetCursorPosition(X, Y + i); // Position für die Menüoption setzen
                    Console.WriteLine(" " + menuOption);
                }
            }
            // Farben zurücksetzen
            Console.ResetColor();
        }
        static public int HandleInput()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.UpArrow)
            {
                if (Pos > 0)
                    Pos = Pos - 1;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                if (((int)Pos) < 2)
                    Pos = Pos + 1;
            }
            else if (key.Key == ConsoleKey.Enter )
            {
                if(Pos == Menu.Start)
                {
                    DellScreen();
                    return 1;
                }
                else if (Pos == Menu.Infos)
                {
                    DellScreen();
                    //infos();
                    return 2;
                }
                else if (Pos == Menu.Exit)
                {
                    Environment.Exit(0); // Programm beenden
                }
            }
            Console.SetCursorPosition(0, 0);
            return 0;
        }

        static public void DellScreen()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Console.WindowHeight -1; i++)
            {
                for (int j = 0; j < Console.WindowWidth -1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        // ( . )( . )
        static void infos()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Infos");

            Console.WriteLine("Programm Created by..");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Back");
            Console.ResetColor();
        }
    }
}
 