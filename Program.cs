using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    internal class Program
    {
        static private int StartMenu = 0;
        
        static void Main(string[] args)
        {

            Start_Menu.Setup(2, 1);
            Map.Setup(10, 5, 40, 10);

            Snake S1 = new Snake();

            bool GameInit = true;

            while (true)
            {
                while (StartMenu == 0)
                {
                    Start_Menu.text();

                    Start_Menu.ShowMenu();
                    StartMenu = Start_Menu.HandleInput();
                }
                while (StartMenu == 2)
                {
                    Infos.text();
                    Infos.InfoText();
                    Console.ReadKey();
                    Start_Menu.DellScreen();
                    StartMenu = 0;
                }

                while (StartMenu == 1)
                {
                    //Game

                    if (GameInit)
                    {
                        Map.DrawMap();
                        S1.AddSnakeBody();

                        GameInit = false;
                    }

                    Map.DellGameScreen();
                    S1.DrawSnake();
                    S1.MoveSnake();
                    System.Threading.Thread.Sleep(2000);



                }
                
            }
        }
    }
}
