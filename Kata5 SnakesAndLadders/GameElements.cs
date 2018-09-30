using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata5_SnakesAndLadders
{
    class GameElements
    {
        public static string format = "\n\t";
        public static string lineBreak = "-----------------------------------------------";
           
        public static int[] DiceRoll()
        {
            Random ran = new Random();
            int[] dieRoll = new int[2];
            for (int i = 0; i < dieRoll.Length; i++)
            {
                dieRoll[i] = ran.Next(1, 7);
            }

            Console.WriteLine(format + $"The die rolls are: {dieRoll[0]} and {dieRoll[1]}");

            return dieRoll;
        }

        public static int MovePiece(int[] dieRoll)
        {
            int moveForward = 0;

            for (int i = 0; i < dieRoll.Length; i++)
            {
                moveForward += dieRoll[i];
            }

            if (dieRoll[0] == dieRoll[1])
            {
                Console.WriteLine(format + "For rolling a double, you get to take another roll. Press any key to roll again.");
                Console.ReadLine();
                int[] secondRoll = DiceRoll();
                for(int i = 0; i < secondRoll.Length; i++)
                {
                    moveForward += secondRoll[i];
                }
            }

            Console.WriteLine(format + $"Move forward {moveForward} spaces.");
            return moveForward;
        }

        public static int CheckPosition(int playerPosition)
        {
            if (playerPosition > 100)
            {
                playerPosition = (100 - (playerPosition - 100));
                Console.WriteLine(format + $"You've rolled greater than 100 and bounced back to square {playerPosition}.");
                playerPosition = CheckPosition(playerPosition);
            }

            else if (playerPosition == 2)
            {
                playerPosition = 38;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 2 and moved up to square 38!");
            }
            else if (playerPosition == 7)
            {
                playerPosition = 14;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 14 and moved up to square 14!");
            }
            else if (playerPosition == 8)
            {
                playerPosition = 31;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 8 and moved up to square 31!");
            }

            else if (playerPosition == 15)
            {
                playerPosition = 26;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 15 and moved up to square 26!");
            }
            else if (playerPosition == 16)
            {
                playerPosition = 6;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 16 and slid down to square 6!");
            }
            else if (playerPosition == 21)
            {
                playerPosition = 42;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 21 and moved up to square 42!");
            }
            else if (playerPosition == 28)
            {
                playerPosition = 84;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 28 and moved up to square 84!");
            }
            else if (playerPosition == 36)
            {
                playerPosition = 44;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 36 and moved up to square 44!");
            }
            else if (playerPosition == 46)
            {
                playerPosition = 25;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 46 and slid down to square 25!");
            }
            else if (playerPosition == 49)
            {
                playerPosition = 11;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 49 and slid down to square 11!");
            }
            else if (playerPosition == 51)
            {
                playerPosition = 67;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 51 and moved up to square 67!");
            }
            else if (playerPosition == 62)
            {
                playerPosition = 19;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 62 and slid down to square 19!");
            }
            else if (playerPosition == 64)
            {
                playerPosition = 60;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 64 and slid down to square 60!");
            }
            else if (playerPosition == 71)
            {
                playerPosition = 91;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 71 and moved up to square 91!");
            }
            else if (playerPosition == 74)
            {
                playerPosition = 53;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 74 and slid down to square 53!");
            }
            else if (playerPosition == 78)
            {
                playerPosition = 98;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 78 and moved up to square 98!");
            }
            else if (playerPosition == 87)
            {
                playerPosition = 94;
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 87 and moved up to square 94!");
            }
            else if (playerPosition == 89)
            {
                playerPosition = 68;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 89 and slid down to square 68!");
            }
            else if (playerPosition == 92)
            {
                playerPosition = 88;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 92 and slid down to square 88!");
            }
            else if (playerPosition == 95)
            {
                playerPosition = 75;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 95 and slid down to square 75!");
            }
            else if (playerPosition == 99)
            {
                playerPosition = 80;
                Console.WriteLine(format + "Too bad! You've hit a snake on square 99 and slid down to square 80!");
            }

            return playerPosition;
        }
    }
}
