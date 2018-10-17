using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    //The PlayGame class contains the methods that do most of the work in the Application
class PlayGame
    {
        public static string format = "\n\t";
        public static string lineBreak = "-----------------------------------------------";

        //GameStart initializes the players and their positions (both start at 0)
        //and then enters into a while loop based on the winner boolean
        //While winner is false, the while loop will call the PlayerTurn method once for player 1 and once for player 2
        //If one of the players ends their turn on square 100, winner becomes = true and the loop ends
        public static void GameStart()
        {
            int player1 = 1;
            int player2 = 2;
            int player1Position = 0;
            int player2Position = 0;
            bool winner = false;
            Console.WriteLine(format + "New Game Start!");
            Console.WriteLine(format + lineBreak);

            while (winner != true)
            {
                Console.WriteLine(format + "Player 1 turn. Press any key to roll the dice.");
                Console.WriteLine("\t" + lineBreak);
                Console.ReadLine();

                player1Position = PlayerTurn(1, player1Position);
                if (player1Position == 100)
                {
                    Console.WriteLine(format + $"Player {player1} has won the game!");
                    winner = true;
                    break;
                }

                Console.WriteLine(format + "Player 2 turn. Press any key to roll the dice.");
                Console.WriteLine("\t" + lineBreak);
                Console.ReadLine();

                player2Position = PlayerTurn(2, player2Position);
                if (player2Position == 100)
                {
                    Console.WriteLine(format + $"Player {player2} has won the game!");
                    winner = true;
                    break;
                }

            }
            //At the end of GameStart, control is passed to PlayAgain
            //which is a simple method that asks the user if they want to play again
            //if yes, the program starts over at GameStart()
            //if no, the program exits gracefully
            PlayAgain();
        }

        //The PlayerTurn method takes the current player and their position as parameters
        //It creates a new instance of the GameElements class and generates the value of a dice roll
        //By initializing an array with the results of the DiceRoll() method.
        //It then calculates how many positions to move forward based on the dice roll
        //and then calculates the final position of the player at the end of their turn.
        public static int PlayerTurn(int player, int position)
        {
            GameElements game = new GameElements();
            int[] dieRoll = GameElements.DiceRoll();

            int initPos = position + GameElements.MovePiece(dieRoll);

            int finalPos = GameElements.CheckPosition(initPos);

            Console.WriteLine(format + $"Player {player} has ended their turn on square {finalPos}");
            Console.WriteLine(format + lineBreak);
            return finalPos;
        }
        //PlayAgain is a simple method that asks if the user wants to play another game of Snakes and Ladders
        //returning control to the GameStart method if they do.
        //If they don't want to play again, the method returns void and control is passed to the finally block of the Main method.
        public static void PlayAgain()
        {
            Console.WriteLine(format + "Would you like to play again?");
            Console.WriteLine(format + "Enter 1 to play again, any other key to exit.");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                PlayGame.GameStart();
            }
            else return;
        }

    }
}
