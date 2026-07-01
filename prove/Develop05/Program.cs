using System;
using System.Data;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        //Start Loop
        bool running = true;
        int choice;
        bool isValid;
        int totalPoints = 0;
        List<Goal> recordedGoals = new List<Goal>();
        while (running)
        {
            
            // Initial Menu
            Console.WriteLine($"You have {totalPoints} points.\n");

            Console.WriteLine("""
            Menu Options:
                1. Create New Goal
                2. List Goals
                3. Save Goals
                4. Load Goals
                5. Record Event
                6. Quit
            """);
            do
            {
                // Choose Option

                Console.Write("Select a choice from the menu: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out choice);
                if (!isValid)
                    {
                        Console.WriteLine("Invalid input: Enter a number between 1 and 6.");
                    }
                else if (choice > 6 || choice < 1)
                {
                    Console.WriteLine("Invalid Input: Enter a number between 1 and 6.");
                } 
                
            } while (choice > 6 || choice < 1 || !isValid);
            
            // Create New Goal
            if (choice == 1) 
            {
                int goalType;
                Console.WriteLine("""

                Goal Types:
                    1. Simple Goal (This goal is limited to one completion, and you get points upon finishing.)
                    2. Checklist Goal (You set how many times you want to complete this goal, and get extra points for completing them all.)
                    3. Eternal Goal (This goal never ends! You get points upon each completion, and can complete this goal as often as you like.)

                """);
                do
                    {
                    Console.Write("Select a goal type you would like to create: ");
                    string input = Console.ReadLine();
                    isValid = int.TryParse(input, out goalType);
                    if (!isValid)
                        {
                            Console.WriteLine("Invalid input: Enter a number between 1 and 3.");
                        }
                    else if (goalType > 3 || goalType < 1)
                    {
                        Console.WriteLine("Invalid Input: Enter a number between 1 and 3.");
                    } 
                    
                } while (goalType > 3 || goalType < 1 || !isValid);
                
                // 1. Simple Goal

                if (goalType == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string simpleName = Console.ReadLine();
                    
                    Console.Write("Give a description of your goal. ");
                    string simpleDesc = Console.ReadLine();

                    Console.Write("How many points is this goal worth? ");
                    int simplePoints = int.Parse(Console.ReadLine());
                    
                    SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDesc, simplePoints);

                    recordedGoals.Add(simpleGoal);
                    Console.WriteLine();
                }

                // 2. Checklist Goal

                else if (goalType == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string checklistName = Console.ReadLine();
                    
                    Console.Write("Give a description of your goal. ");
                    string checklistDesc = Console.ReadLine();

                    Console.Write("How many points is this goal worth? ");
                    int checklistPoints = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be completed to earn bonus points? ");
                    int bonusRequirement = int.Parse(Console.ReadLine());
                    
                    Console.Write("How many points should be awarded as bonus points? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal =  new ChecklistGoal(checklistName, checklistDesc, checklistPoints, bonusRequirement, bonusPoints);
                    
                    recordedGoals.Add(checklistGoal);
                    Console.WriteLine();
                }
                
            // 3. Eternal Goal

                else if (goalType == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string eternalName = Console.ReadLine();
                    
                    Console.Write("Give a description of your goal. ");
                    string eternalDesc = Console.ReadLine();

                    Console.Write("How many points is this goal worth? ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    
                    EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDesc, eternalPoints);

                    recordedGoals.Add(eternalGoal);
                    Console.WriteLine();
                }
            }

            // List Goals
            else if (choice == 2)
            {
                Goal.ListGoals(recordedGoals);
                
            }

            

            // Save Goals
            else if (choice == 3)
            {
                Goal.SaveGoalsToFile(recordedGoals);
            
            }

            // Load Goals
            else if (choice == 4)
            {   

                recordedGoals = Goal.LoadGoalsFromFile();
                totalPoints = 0;
                // Add up points so they have their saved total back
                foreach (Goal goal in recordedGoals)
                {
                    
                    totalPoints += goal.GetPointTotal();

                }
            }

            
            // Record Event

            else if (choice == 5)
            {
                Console.WriteLine("\nThe goals are:");
                List<Goal> uncompletedGoals = new List<Goal>();
                if (recordedGoals.Count() != 0)
                {
                    foreach (Goal goal in recordedGoals)
                    {
                        
                        if (!goal.GetCompletion())
                        {
                            uncompletedGoals.Add(goal);
                            Console.WriteLine($"{uncompletedGoals.Count()}. {goal.GetName()}");
                        }

                    }
                    if (uncompletedGoals.Count() != 0)
                    {
                        Console.Write("Which goal did you accomplish? (Enter one of the above numbers): ");
                        int updatechoice = int.Parse(Console.ReadLine());
                        int points = uncompletedGoals[updatechoice - 1].RecordEvent();
                        totalPoints += points;
                        Console.WriteLine($"You now have {totalPoints} points.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No uncompleted goals found.");
                    }
                }
                else
                {
                    Console.WriteLine("No goals found.");
                }
                
                
            }

            // Quit
            else if (choice == 6)
            {
                running = false;
            }

        }
    }
}