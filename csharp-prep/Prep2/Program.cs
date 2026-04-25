using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int gradePercent = int.Parse(valueFromUser);
        string letterGrade = "";
        int signRemainder = gradePercent % 10;
        string plusMinus = "";
        
        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }

        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }

        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (signRemainder >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            plusMinus = "+";
        }
        else if (signRemainder <= 3 && letterGrade != "F")
        {
            plusMinus = "-";
        }

        Console.WriteLine($"Your grade is {letterGrade + plusMinus}!");
        
        if (gradePercent > 70)
        {
            Console.WriteLine("You Pass!");
        }

        else
        {
            Console.WriteLine("Better Luck Next Time!");
        }
    }
}