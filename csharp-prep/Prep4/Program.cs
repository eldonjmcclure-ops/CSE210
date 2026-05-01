using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //Compute the sum, or total, of the numbers in the list.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string userValue;
        List<int> numbers = new();
        do
        {
            Console.Write("Enter Number: ");
            userValue = Console.ReadLine();
            int number = int.Parse(userValue);
            numbers.Add(number);
            
        } while (userValue != "0");
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        // Find the maximum, or largest, number in the list.

    }
}