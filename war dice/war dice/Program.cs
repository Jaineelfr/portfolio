using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace war_dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many rounds would you like to play");
            int rounds = int.Parse(Console.ReadLine());
            int player = 0;
            int CompSc = 0;
            Random random = new Random();
            for (int i = 0; i < rounds; i++)
            {
                int playerRoll = random.Next(1, 7);
                int CompRoll = random.Next(1, 7);
                if (playerRoll == 6 && CompRoll == 6)
                {
                    Console.WriteLine("it an Tie");
                    Console.WriteLine("Player rolled " + playerRoll);
                    Console.WriteLine("Computer Rolled " + CompRoll);

                }
                else if (CompRoll == 6 || CompRoll < playerRoll)
                {
                    Console.WriteLine("Player wins");
                    Console.WriteLine("Player rolled " + playerRoll);
                    Console.WriteLine("Computer rolled " + CompRoll);

                    player++;
                }
                else if (playerRoll == 6 || playerRoll < CompRoll)
                {
                    Console.WriteLine("Computer wins");
                    Console.WriteLine("Player rolled " + playerRoll);
                    Console.WriteLine("Computer rolled " + CompRoll);

                    CompSc++;
                }
                else if (playerRoll > CompRoll)
                {
                    Console.WriteLine("Player won");
                    Console.WriteLine("Player rolled " + playerRoll);
                    Console.WriteLine("Computer rolled " + CompRoll);

                    player++;
                }
                else if (playerRoll < CompRoll)
                {
                    Console.WriteLine("Computer wins");
                    Console.WriteLine("Player rolled " + playerRoll);
                    Console.WriteLine("Computer rolled " + CompRoll);

                    CompSc++;
                }
                else //this is for if the computer and player get same roll then its an automatic tie
                {
                    Console.WriteLine("It's a Tie");
                    Console.WriteLine("Player rolled " + playerRoll);
                    Console.WriteLine("Computer rolled " + CompRoll);

                }
                Console.ReadLine();
            }
            if (player < CompSc)
            {
                Console.WriteLine("Computer wins!!!");
                Console.WriteLine("The player scored " + player);
                Console.WriteLine("The Computer scored " + CompSc);
                Console.ReadKey();

            }
            else if (player > CompSc)
            {
                Console.WriteLine("Player wins!!!");
                Console.WriteLine("The player scored " + player);
                Console.WriteLine("The Computer scored " + CompSc);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("its a Tie try again");
                Console.WriteLine("The player scored " + player);
                Console.WriteLine("The Computer scored " + CompSc);
                Console.ReadKey();
            }

        }

    }
}
