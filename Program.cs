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
        private static Fruit F1;
        static private int StartMenu = 0;
        static private Timer timer = new Timer(400);

        static private int Xof = 10,Yof = 5, Width = 40, Height = 10;

        static bool GameInit = true;
        static bool ateFruit = false;

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
                Map.Setup(Xof, Yof, Width, Height);
                Map.DrawMap();

                F1 = new Fruit();
                F1.initFruit(Xof, Yof, Width, Height);
                GameInit = false;
            }


            Map.DellGameScreen();
            S1.DrawSnake();
            F1.DrawFruit();
            S1.CeckMapColision(Xof, Yof, Width, Height);
            S1.UserInput();

            ateFruit = S1.CheckFruit(F1);

            S1.MoveSnake(ateFruit);
            if (ateFruit)
            {
                F1.initFruit(Xof, Yof, Width, Height);
                ateFruit = false;
            }
            
        }
        static void SetupTimer()
        {
            timer.Elapsed += OnTimerdEvent;
            timer.AutoReset = true;
            timer.Enabled = false;
        }
    }
}