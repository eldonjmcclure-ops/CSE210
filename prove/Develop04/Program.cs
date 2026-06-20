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

            }
                
                // If Reflecting
            else if (choice == 2)
            {
                string[] questions = ["What challenge did you have to overcome during this experience?",
                "What personal strength did you rely on the most?",
                "Who, if anyone, influenced or supported you during this experience?",
                "What obstacles almost prevented you from succeeding?",
                "What would you tell someone else facing a similar situation?",
                "How has this experience changed the way you see yourself?",
                "What emotions did you experience throughout this event?",
                "Why was this experience meaningful to you?",
                "What skills or qualities did you discover or strengthen through this experience?", 
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
                "If you could relive this experience, is there anything you would do differently?"];
                ReflectingActivity reflecting = new ReflectingActivity(questions, 5);
                string[] refPrompts = ["Think of a time when you overcame a fear.",
                "Think of a time when you kept going even though you wanted to give up.",
                "Think of a time when you learned from a major mistake.",
                "Think of a time when you adapted to an unexpected change.",
                "Think of a time when you remained calm during a stressful situation.",
                "Think of a time when you achieved a goal through persistence.",
                "Think of a time when you forgave someone or let go of a grudge.",
                "Think of a time when you took responsibility for your actions.",
                "Think of a time when you encouraged someone who was struggling.",
                "Think of a time when you stepped outside of your comfort zone.",
                "Think of a time when you solved a difficult problem through patience and determination."];
                reflecting.SetPromptList(refPrompts);
                Console.WriteLine();
                Console.WriteLine($"Welcome to the {reflecting.GetActivityName()}.");
                Console.WriteLine(reflecting.GetDescription());
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
                reflecting.SetDuration(seconds);
                Console.Clear();
                Console.WriteLine();
                reflecting.StartReflectingActivity();
            }
            else if (choice ==  3)
            {
                List<string> responses = new List<string>();
                ListingActivity listing = new ListingActivity(responses);
                string[] listPrompts = ["What is something that made you smile recently?","What is a happy memory that you enjoy revisiting?",
                "What is a goal that you have made progress toward?","What is a simple comfort that improves your daily life?","What is something kind that someone has done for you recently?",
                "What is a place where you feel peaceful or happy?","What is a tradition or habit that brings you joy?",
                "What is something about nature that you appreciate?","What is a recent accomplishment that you are proud of?",
                "What is a relationship that enriches your life?","What is something you are looking forward to?", "When have you felt the Holy Ghost this month?","What is something kind you have done for someone lately?"];
                listing.SetPromptList(listPrompts);
                Console.WriteLine();
                Console.WriteLine($"Welcome to the {listing.GetActivityName()}.");
                Console.WriteLine(listing.GetDescription());
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
                listing.SetDuration(seconds);
                Console.Clear();
                Console.WriteLine();
                listing.StartListingActivity();
                
            }
            else
            {
                running = false;
            }

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