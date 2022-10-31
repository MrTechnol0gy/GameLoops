using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoops
{
    internal class Program
    {
        static bool gameOver;
        static int x, y;
        static int origx, origy;
        static ConsoleKeyInfo key;
        static string s;
        static void Main(string[] args)
        {
            InitializeVariables();
            while (gameOver == false)
            {
                ShowHud();
                PlayerUpdate();
                PlayerDraw(s, x, y);

            }
            Console.WriteLine();
            Console.WriteLine("The Game is now Over.");
            Console.ReadKey();

        }
        static void ShowHud()
        {
            Console.WriteLine("GameLoops");
            Console.WriteLine();            
            Console.ReadKey(true);
            Console.WriteLine();

        }
        static void PlayerUpdate()
        {            
            Console.WriteLine();
            Console.WriteLine("Press 'W' to move North, 'A' to move West, 'S' to move South, or 'D' to move East. Press 'ESC' to Quit.");
            
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }
            else if (key.Key == ConsoleKey.W)
            {
                y++;
            }
            else if (key.Key == ConsoleKey.A)
            {
                x--;
            }
            else if (key.Key == ConsoleKey.S)
            {
                y--;
            }
            else if (key.Key == ConsoleKey.D)
            {
                x++;
            }            

        }
        static void PlayerDraw(string s, int x, int y)
        {
            Console.SetCursorPosition(origx + x,origy + y);
            Console.Write(s);
        }        
        static void InitializeVariables()
        {
            gameOver = false;
            x = 0;
            y = 0;
            origx = 0;
            origy = 0;
            s = "#";
        }
    }
}
