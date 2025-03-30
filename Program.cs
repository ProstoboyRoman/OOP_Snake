using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace OOP_Snake
{
    internal class Program
    {
        private static Snake S1;
        static private int StartMenu = 0;
        static private Timer timer = new Timer(200);



        static bool GameInit = true;

        static void Main(string[] args)
        {
            SetupTimer();


            Start_Menu.Setup(2, 1);




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
                    Start_Menu.DellScreen();
                    timer.Enabled = true;
                    StartMenu = 3;

                }

            }

        }
        static void OnTimerdEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (GameInit)
            {
                S1 = new Snake();
                S1.AddSnakeBody();
                Map.Setup(10, 5, 40, 10);
                Map.DrawMap();


                GameInit = false;
            }


            Map.DellGameScreen();
            S1.DrawSnake();


            S1.UserInput();
            S1.MoveSnake();
            

        }
        static void SetupTimer()
        {
            timer.Elapsed += OnTimerdEvent;
            timer.AutoReset = true;
            timer.Enabled = false;
        }
    }
}