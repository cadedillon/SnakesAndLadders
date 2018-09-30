using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata5_SnakesAndLadders
{
    class Program
    {
        public static string format = "\n\t";
        public static string lineBreak = "-----------------------------------------------";

        static void Main(string[] args)
        {
            Console.WriteLine(format + "Welcome to Cade's take on the classic game : 'Snakes and Ladders!'");
            Console.WriteLine(format + "This humble application began as a CodeWars challenge, but I was having fun and so I fleshed it out.");
            Console.WriteLine(format + "The map for the Gameboard in this app can be found at: ");
            Console.Write("\t" + "https://raw.githubusercontent.com/adrianeyre/codewars/master/Ruby/Authored/snakesandladdersboard.jpg");
            Console.WriteLine();
            Console.WriteLine(format + "Please, enjoy with a friend or coworker =)");
            Console.ReadLine();
            try
            {
                PlayGame.GameStart();
            }

            catch (FormatException fEx)
            {
                Console.WriteLine(format + fEx.Message);
            }

            finally
            {
                Console.WriteLine(format + "Thanks so much for checking out my application!");
                Console.WriteLine(format + "Be sure to check out the rest of my portfolio at github.com/cadedillon!");
            }
            




        }
    }
}
