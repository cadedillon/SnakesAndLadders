using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    class GameElements
    {
        public static string format = "\n\t";
        public static string lineBreak = "-----------------------------------------------";

        //The DiceRoll method simulates rolling two six-sided dice 
        //with the Random.Next(int, int) method overload.
        //The second int parameter is greater than 6 because it is exclusive 
        //(meaning it will generate a number upto but not equal to the second parameter)
        public static int[] DiceRoll()
        {
            Random random = new Random();
            int[] dieRoll = new int[2];
            for (int i = 0; i < dieRoll.Length; i++)
            {
                dieRoll[i] = random.Next(1, 7);
            }

            Console.WriteLine(format + $"The die rolls are: {dieRoll[0]} and {dieRoll[1]}");
            //Return the result of the DiceRoll as an int[]
            return dieRoll;
        }

        //The move piece method takes the int[] dieRoll as a parameter
        //and sums the contents together to calculate how far forward from their current space 
        //the user should move forward
        public static int MovePiece(int[] dieRoll)
        {
            int moveForward = 0;

            for (int i = 0; i < dieRoll.Length; i++)
            {
                moveForward += dieRoll[i];
            }
            //As per the rules of Snakes and Ladders, if the die roll returns two of the same number
            //The user gets to roll again and move forward the sum of all 4 die rolls
            //This if statement determines if a double condition exists, and if it does,
            //Generates a second int[] with another DiceRoll() method call
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

            //After summing the results of all die rolls, return the number of spaces the player moves forward as an integer.
            Console.WriteLine(format + $"Move forward {moveForward} spaces.");
            return moveForward;
        }

        //The check position method takes the current player's position as an integer
        //and if the position equals one of the special spaces on the board that contain a snake or a ladder,
        //the user is moved to the corresponding space and end their turn there.
        //This method also checks whether the user has overshot space 100, and if they have, calculates how far they should bounce back.
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
                Console.WriteLine(format + "Congratulations! You've hit a ladder on square 7 and moved up to square 14!");
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
            //Return the final player position as an integer
            return playerPosition;
        }
    }
}
