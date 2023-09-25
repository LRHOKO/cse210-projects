using System;
using System.Diagnostics.Tracing;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                guessCount++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! Your total number of guesses is {guessCount}");
                }
            }
            Console.Write("Do you want to continue? (yes/no) ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}




