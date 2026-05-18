using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();

        Fraction f2 = new Fraction(5);

        Fraction f3 = new Fraction(1,3);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Random random = new Random();
        Fraction f4 = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1,11);
            int bottomValue = random.Next(1,11);
            f4.SetTop(topValue);
            f4.SetBottom(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f4.GetFractionString()}");
            Console.WriteLine($" Number: {f4.GetDecimalValue()}");
        }
    }
}