using System;
using System.Globalization;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            return number;
        }

        void PromptUserBirthYear(out int year)
        {
            Console.Write("Please Enter your birth year: ");
            string yearString = Console.ReadLine();
            year = int.Parse(yearString);
        }

        int SquareNumber(int number)
        {
            int square = number * number;
            return square; 
        }

        void DisplayResult()
        {
            int year;
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            PromptUserBirthYear(out year);
            int square = SquareNumber(number);
            int currentYear = DateTime.Now.Year;
            int age = currentYear - year;
            Console.WriteLine($"{name}, the square of your number is {square}");
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }
        DisplayResult();
    }
}