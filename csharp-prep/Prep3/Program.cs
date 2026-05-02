using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        // Compare the guess and the magic number
        int userGuess = -1;
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userValue = Console.ReadLine();
            userGuess = int.Parse(userValue);
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
            }
        }

        // Give an answer corresponding to the closeness of the guess

    }
} 