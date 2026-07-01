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
        List<int> thresholds = new List<int>() {50,110,180,260,350,450,565,695,840,1000,1175,1365,1575,
    1805,2055,2325,2615,2930,3270,3635,4025,4445,4895,5375,5885,6430,7010,7625,8275,8965,9695,10465,11275,
    12130,13030,13975,14970,16015,17110,18260,19465,20730,22055,23445,24900,26425,28020,29690,31440,33270,
    35185,37190,39290,41490,43795,46210,48740,51390,54165,57070,60110,63290,66615,70090,73720,77510,81465,
    85590,89890,94370,99035,103890,108940,114190,119645,125310,131190,137290,143615,150170,156960,163990,
    171265,178790,186570,194610,202915,211490,220340,229470,238885,248590,258590,268890,279495,290410,
    301640,313190};

        Level levelManager = new Level(1, 99, thresholds);

        int oldLevel = levelManager.GetMinLevel();
        while (running)
        {
            
            // Initial Menu
            Console.WriteLine($"You have {totalPoints} points.\n");
            
            int currentLevel = levelManager.CheckLevel(totalPoints);
            if (currentLevel > levelManager.GetCurrentLevel())
            {
                levelManager.SetCurrentLevel(currentLevel);
                levelManager.LevelUpAnimation();
            }
            Console.WriteLine($"Level {currentLevel}");


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
                    
                    int simplePoints;
                    do
                    {
                        Console.Write("How many points is this goal worth? Max 50: ");
                        string input = Console.ReadLine();
                        isValid = int.TryParse(input, out simplePoints);
                        if (!isValid)
                            {
                                Console.WriteLine("Invalid input: Enter a number between 1 and 50.");
                            }
                        else if (simplePoints > 50 || simplePoints < 1)
                        {
                            Console.WriteLine("Invalid Input: Enter a number between 1 and 50.");
                        } 
                    
                    } while (simplePoints > 50 || simplePoints < 1 || !isValid);

                    
                    
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

                    int checklistPoints;
                    do
                    {
                        Console.Write("How many points is this goal worth? Be reasonable about it. Max 30: ");
                        string input = Console.ReadLine();
                        isValid = int.TryParse(input, out checklistPoints);
                        if (!isValid)
                            {
                                Console.WriteLine("Invalid input: Enter a number between 1 and 30.");
                            }
                        else if (checklistPoints > 30 || checklistPoints < 1)
                        {
                            Console.WriteLine("Invalid Input: Enter a number between 1 and 30.");
                        } 
                    
                    } while (checklistPoints > 30 || checklistPoints < 1 || !isValid);
                    

                    Console.Write("How many times does this goal need to be completed to earn bonus points? ");
                    int bonusRequirement = int.Parse(Console.ReadLine());

                    int bonusPoints;
                    do
                    {
                        Console.Write("How many points should be awarded as bonus points? Be reasonable about it. Max 200: ");
                        string input = Console.ReadLine();
                        isValid = int.TryParse(input, out bonusPoints);
                        if (!isValid)
                            {
                                Console.WriteLine("Invalid input: Enter a number between 1 and 200.");
                            }
                        else if (bonusPoints > 200 || bonusPoints < 1)
                        {
                            Console.WriteLine("Invalid Input: Enter a number between 1 and 500.");
                        } 
                    
                    } while (bonusPoints > 200 || bonusPoints < 1 || !isValid);

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

                    int eternalPoints;
                    do
                    {
                        Console.Write("How many points is this goal worth? Be reasonable about it. Max 50: ");
                        string input = Console.ReadLine();
                        isValid = int.TryParse(input, out eternalPoints);
                        if (!isValid)
                            {
                                Console.WriteLine("Invalid input: Enter a number between 1 and 50.");
                            }
                        else if (eternalPoints > 50 || eternalPoints < 1)
                        {
                            Console.WriteLine("Invalid Input: Enter a number between 1 and 50.");
                        } 
                    
                    } while (eternalPoints > 50 || eternalPoints < 1 || !isValid);
                    
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