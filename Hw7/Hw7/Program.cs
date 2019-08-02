using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7
{
    class Program
    {

        static private void StratGamePage()
        {
            int cur_left = 26;
            int cur_top = 4;
            string cur = "■";
            ConsoleKey c;

            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(cur_left, cur_top);
                Console.Write(cur);
                Console.SetCursorPosition(25, 1);
                Console.WriteLine("The Dungeon");
                Console.SetCursorPosition(28, 4);
                Console.WriteLine("New game");
                Console.SetCursorPosition(28, 6);
                Console.WriteLine("Continue");

                c = Console.ReadKey().Key;

                if (c == ConsoleKey.UpArrow || c == ConsoleKey.DownArrow)
                {
                    if (cur_top == 4)
                    {
                        cur_top = 6;
                    }
                    else if (cur_top == 6)
                    {
                        cur_top = 4;
                    }
                }
            } while (c != ConsoleKey.Enter);

            if(cur_top == 4)
            {
            
                // new state
            }
            else if(cur_top == 6)
            {
                // load state
            }
        }

        static void Main(string[] args)
        {
            StratGamePage();
            //while (true)
            //{

            //}       
        }
    }
}
