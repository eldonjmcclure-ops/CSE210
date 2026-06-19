using System;

class Program
{
    static void Main(string[] args)
    {
        // Mindfulness Project
        bool running = true;
        int choice;
        bool isValid;
        // Start with displaying  the menu
        while (running)
        {
        Console.WriteLine(
            """
            Menu Options:
                1. Start Breathing Activity
                2. Start Reflecting Activity
                3. Start Listing Activity
                4. Quit
            """
            );
            do
            {
                Console.Write("Enter Choice: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out choice);
                if (!isValid)
                    {
                        Console.WriteLine("Invalid input: Enter a number between 1 and 4.");
                    }
                else if (choice > 4 || choice < 1)
                {
                    Console.WriteLine("Invalid Input: Enter a number between 1 and 4.");
                } 
                
            } while (choice > 4 || choice < 1 || !isValid);
        // Set up If Else conditions for each activity
            // If Breathing
            if (choice == 1)
            {

                BreathingActivity breathing = new BreathingActivity(4, 4, 6);
                Console.WriteLine();
                Console.WriteLine($"Welcome to the {breathing.GetActivityName()}.");
                Console.WriteLine(breathing.GetDescription());
                int seconds;
                // Ask for Duration, use setter to set duration
                do
                {
                    Console.Write("How long, in seconds, would you like your session? ");
                    string input = Console.ReadLine();
                    isValid = int.TryParse(input, out seconds);
                    if (!isValid)
                    {
                        Console.WriteLine("Invalid input: Enter a number.");
                    }
                    else if (seconds < 10)
                    {
                        Console.WriteLine("Come on, let's try for a bit longer, shall we?");
                    } 
                
                } while (seconds < 10 || !isValid);
                breathing.SetDuration(seconds);
                Console.Clear();
                Console.WriteLine("Get Ready...");
                breathing.DisplaySpinner(3);
                Console.WriteLine();
                    
                breathing.StartBreathingActivity();
                
                

                // 
            
            }
                // 
                
                // Use Constructor to create class object

                // Start Activity
                    // Start breathing loop, inhale for 4, hold for 5, and exhale for 7, for _duration
                    // Use console animation to create countdown each time
                    // End when _duration in seconds is reached.

            // If Reflecting
                //
                // Use Constructor to create class object
                // Ask for Duration, use setter to set duration
                // Start Activity

            // If Listing 
        }
    }
}