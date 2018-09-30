using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata5_SnakesAndLadders
{
    class PlayGame
    {
        public static string format = "\n\t";
        public static string lineBreak = "-----------------------------------------------";

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

            PlayAgain();
        }

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
