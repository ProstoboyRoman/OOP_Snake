using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    static internal class Infos
    {
        static public void text()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("infos");
        }
        public static void InfoText()
        {
            Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.WindowHeight - 3);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(">Back");
            Console.ResetColor();
        }
    }
}
