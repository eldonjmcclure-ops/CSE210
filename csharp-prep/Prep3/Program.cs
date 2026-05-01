using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        // Ask for and record a guess
        
        // Compare the guess and the magic number
        string loopActive = "true";
        while (loopActive == "true")
        {
            Console.Write("What is your guess? ");
            string userValue = Console.ReadLine();
            int userGuess = int.Parse(userValue);
            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
                loopActive = "false";
            }
        }

        // Give an answer corresponding to the closeness of the guess

    }
} 