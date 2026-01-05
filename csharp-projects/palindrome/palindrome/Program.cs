using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter in a word");

            string word = "";
            word = Console.ReadLine();
            word = word.ToLower();

            bool isPalin = true; //currently is a palindrome

            for (int i = 0, j = word.Length - 1; i < word.Length - 1; i++, j--)//i is counter from left side, j is counter from right side. and each go "++" to show that each variable moves to see if each letter is equal
            {
                if (word[i] != word[j]) //if the letter value in 1 is not equal to that of j
                {
                    isPalin = false; //bool turns false to prove that it is not a palindrome
                    Console.WriteLine(" The Word, " + word + "is not a palindrome");
                    Console.ReadKey();
                    break;

                }
  
            }
        
            if (isPalin == true) //bool goes directly to "if its true", if it isnt able to prove the bool false in the for loop
            {
                Console.WriteLine("The word, " + word + " is a palindrome");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
