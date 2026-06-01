using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Indiana Jones", "Archaeology");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Jim McCool", "Calculus", "2.6", "7-18");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Tony Stark", "History of Robotics", "The Pathway to Modern-Day Robots");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}