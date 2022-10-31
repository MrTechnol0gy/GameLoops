using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoops
{
    internal class Program
    {
        static bool gameOver = false;
        static int x, y;        
        static void Main(string[] args)
        {
            while (gameOver == false)
            {
                ShowHud();
                PlayerChoice();

            }

        }
        static void ShowHud()
        {
            Console.WriteLine("GameLoops");
            Console.WriteLine();
            PlayerChoice();
            Console.ReadKey(true);
            Console.WriteLine();

        }
        static void PlayerChoice()
        {            
            Console.WriteLine();
            Console.WriteLine("Press 'W' to move North, 'A' to move West, 'S' to move South, or 'D' to move East. Press 'ESC' to Quit.");
            Console.ReadKey();
            if (Console.ReadKey().Key = ConsoleKey.Escape)
            {
                gameOver = true;
            }
            else if (cki = ConsoleKey.W)
            {

            }
            else if (cki = ConsoleKey.A)
            {

            }
            else if (cki = ConsoleKey.S)
            {

            }
            else if (cki = ConsoleKey.D)
            {

            }

        }
        static void PlayerDraw(int x, int y)
        {

        }
        static void PlayerUpdate()
        {

        }
    }
}
