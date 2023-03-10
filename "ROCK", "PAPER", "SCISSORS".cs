using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Security.AccessControl;
using System.ComponentModel;

// Use While loop to make a "Rock,Paper,Scissors" game   

namespace Class
{
    class Program
    {

        public static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain == true)
            {
                player = " ";
                computer = " ";
                answer = " ";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter 'ROCK', 'PAPER', or 'SCISSORS': ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4)) //Computer random number between 1 to 3.
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);


                switch (player)//Logic for all the cases
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It is a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You Win!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It is a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win!!");
                        }
                        else
                        {
                            Console.WriteLine("It is a draw!");
                        }
                        break;
                }

                //Asking the player if they want to play agign.
                Console.WriteLine("Would you like to play again? (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                Console.WriteLine("Thank you for playing!");
            }
           // Console.ReadKey();

        System.Environment.Exit(0);
        }
    }
}