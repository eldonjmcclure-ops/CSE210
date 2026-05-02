using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //Compute the sum, or total, of the numbers in the list.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string userValue = Console.ReadLine();
            number = int.Parse(userValue);
            numbers.Add(number);
            
        }
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