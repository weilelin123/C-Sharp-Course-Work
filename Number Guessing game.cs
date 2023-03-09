using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Security.AccessControl;

// nested loops = loops inside of other loops
//          uses vary. Used a lot in sorting algorithms


namespace Class
{
    class Program
    {
        private static int number;

        public static void Main(string[] args)
        {
            Random randon = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            String response;


            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = " ";
                number = randon.Next(min, max);

                while (guess != number)
                {
                    //Console.WriteLine("The answer is: " + number); // The answer
                    Console.Write("Guess the number between " + min + " - " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                   

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You Won!!");
                Console.WriteLine("Guesses: " + guesses);

                //Ask the player if they want to play again
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true; //Return to the while loop.
                }
                else
                {
                    playAgain = false; //Terminte the program.
                }

            }
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();

        System.Environment.Exit(0);
        }
    }
}