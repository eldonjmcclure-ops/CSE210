using System;
using System.ComponentModel;
using System.IO.Enumeration;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        string filename = "";
        // Add a while or do while loop to allow the user 
        // to write multiple entries and quit if needed
        bool x = true;
        while (x)
        {
            Console.WriteLine("""
            Please select one of the following choices:
            1. Write
            2. Display
            3. Load
            4. Save
            5. Quit

            (Tip: Load a file first before you Write unless you plan on Saving to a new file, 
            since Load erases your unsaved entries)
            """);
            
            int answer;
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.Write("> ");

                // While answer is not an int, and while answer is either less than 1 or greater than 5.  
                // While one is true, the other is not calculated due to the nature of Logical OR, shown as ||
            } while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 6);
            
            
            // Write
            if (answer == 1)
            {
                Entry entry = new Entry();
                Prompt prompt = new Prompt();
                // Add Entry to Journal
                journal.AddEntry(entry, prompt);
            }


            // Display
            else if (answer == 2)
            {
                Console.WriteLine();
                journal.DisplayEntries();
            }
            
            // Load
            else if (answer == 3)
            {

                Console.WriteLine("Enter filename:");
                Console.Write("> ");
                filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine();
            
            } 

            // Save
            else if (answer == 4)
            {
                Console.WriteLine("Enter filename: ");
                Console.Write("> ");
                filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine($"Journal was successfully saved to {filename}.");
                Console.WriteLine();
                
            }

            // Quit
            else if (answer == 5)
            {
                Console.WriteLine("See you tomorrow!");
                Console.WriteLine();
                x = false;
            }

        }

    }
}