using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays for available players
            string[] QB = { "Josh Allen", "Lamar Jackson", "Patrick Mahomes", "Jalen Hurts" };
            string[] qbsplit1 = { "", "" };  // Array to store 2 QBs for Team Jaineel
            string[] qbsplit2 = { "", "" };  // Array to store 2 QBs for Team McGuire

            string[] RB = { "Christian McCafferey", "Breece Hall", "Travis Etienne", "Rachaad White", "Kyren Williams", "Alvin Kamara", "Joe Mixon" };
            string[] rbsplit1 = { "", "", "", "" };  // Array to store 4 RBs for Team Jaineel
            string[] rbsplit2 = { "", "", "" };     // Array to store 3 RBs for Team McGuire

            string[] WR = { "CeeDee Lamb", "Tyreek Hill", "Amon-Ra St. Brown", "Cooper Kupp", "A.J Brown", "Ja'Marr Chase", "Justin Jefferson" };
            string[] wrsplit1 = { "", "", "" };     // Array to store 3 WRs for Team Jaineel
            string[] wrsplit2 = { "", "", "", "" }; // Array to store 4 WRs for Team McGuire

            string[] TE = { "Travis Kelce", "Sam LaPorta" };
            string[] tesplit1 = { "" };  // Array to store 1 TE for Team Jaineel
            string[] tesplit2 = { "" };  // Array to store 1 TE for Team McGuire

            // Create a random object for randomly assigning players
            Random box = new Random();

            // Counters for tracking the number of players added to each team
            int counterqb1 = 0;
            int counterqb2 = 0;
            int counterrb1 = 0;
            int counterrb2 = 0;
            int counterwr1 = 0;
            int counterwr2 = 0;
            int counterte1 = 0;
            int counterte2 = 0;

            // Randomly select 2 QBs for Team Jaineel
            while (counterqb1 < 2)
            {
                int numqb = box.Next(0, QB.Length);  // Pick a random index from the QB array

                if (QB[numqb] != "gone")  // Ensure the QB hasn't already been picked
                {
                    qbsplit1[counterqb1] = QB[numqb];  // Assign QB to Team Jaineel
                    QB[numqb] = "gone";  // Mark the QB as picked
                    counterqb1++;
                }
            }

            // Randomly select 2 QBs for Team McGuire
            while (counterqb2 < 2)
            {
                int numqb = box.Next(0, QB.Length);

                if (QB[numqb] != "gone")
                {
                    qbsplit2[counterqb2] = QB[numqb];  // Assign QB to Team McGuire
                    QB[numqb] = "gone";
                    counterqb2++;
                }
            }

            // Randomly select 4 RBs for Team Jaineel
            while (counterrb1 < 4)
            {
                int numrb = box.Next(0, RB.Length);

                if (RB[numrb] != "gone")
                {
                    rbsplit1[counterrb1] = RB[numrb];  // Assign RB to Team Jaineel
                    RB[numrb] = "gone";
                    counterrb1++;
                }
            }

            // Randomly select 3 RBs for Team McGuire
            while (counterrb2 < 3)
            {
                int numrb = box.Next(0, RB.Length);

                if (RB[numrb] != "gone")
                {
                    rbsplit2[counterrb2] = RB[numrb];  // Assign RB to Team McGuire
                    RB[numrb] = "gone";
                    counterrb2++;
                }
            }

            // Randomly select 3 WRs for Team Jaineel
            while (counterwr1 < 3)
            {
                int numwr = box.Next(0, WR.Length);

                if (WR[numwr] != "gone")
                {
                    wrsplit1[counterwr1] = WR[numwr];  // Assign WR to Team Jaineel
                    WR[numwr] = "gone";
                    counterwr1++;
                }
            }

            // Randomly select 4 WRs for Team McGuire
            while (counterwr2 < 4)
            {
                int numwr = box.Next(0, WR.Length);

                if (WR[numwr] != "gone")
                {
                    wrsplit2[counterwr2] = WR[numwr];  // Assign WR to Team McGuire
                    WR[numwr] = "gone";
                    counterwr2++;
                }
            }

            // Randomly select 1 TE for Team Jaineel
            while (counterte1 < 1)
            {
                int numte = box.Next(0, TE.Length);

                if (TE[numte] != "gone")
                {
                    tesplit1[counterte1] = TE[numte];  // Assign TE to Team Jaineel
                    TE[numte] = "gone";
                    counterte1++;
                }
            }

            // Randomly select 1 TE for Team McGuire
            while (counterte2 < 1)
            {
                int numte = box.Next(0, TE.Length);

                if (TE[numte] != "gone")
                {
                    tesplit2[counterte2] = TE[numte];  // Assign TE to Team McGuire
                    TE[numte] = "gone";
                    counterte2++;
                }
            }

            // Display the final teams
            Console.WriteLine("The NFL 2024 All-Star teams: ");

            Console.WriteLine("");
            Thread.Sleep(1000);  // Adds a 1-second delay before displaying the teams
            Console.ForegroundColor = ConsoleColor.Red;

            // Display Team Jaineel's players
            Console.WriteLine("Team Jaineel QB's: " + string.Join(",", qbsplit1));
            Console.WriteLine("Team Jaineel RB's: " + string.Join(",", rbsplit1));
            Console.WriteLine("Team Jaineel WR's: " + string.Join(",", wrsplit1));
            Console.WriteLine("Team Jaineel TE: " + string.Join(",", tesplit1));

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;

            // Display Team McGuire's players
            Console.WriteLine("Team McGuire QB's: " + string.Join(",", qbsplit2));
            Console.WriteLine("Team McGuire RB's: " + string.Join(",", rbsplit2));
            Console.WriteLine("Team McGuire WR's: " + string.Join(",", wrsplit2));
            Console.WriteLine("Team McGuire TE: " + string.Join(",", tesplit2));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit");

            // Wait for the user to press a key before closing the program
            Console.ReadKey();
        }
    }


    
}
