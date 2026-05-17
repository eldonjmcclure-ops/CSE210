using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    // Adds Entry object, nothing more
    public void AddEntry(Entry entry, Prompt prompt)
    {

    // Set Mood
        
        Console.WriteLine("""
        Record your mood on a scale from 1 to 10:
        
        1 = Worst Day Ever
        10 = Best Day Ever

        Or press Enter to skip.
        """);
        string moodInput;
        do
        {
            Console.Write("> ");
            moodInput = Console.ReadLine();
        
        } while (moodInput != "" && !int.TryParse(moodInput, out int moodNum));   
            
        if (moodInput != "")
        {   
            if (int.TryParse(moodInput, out int moodNum))
            {
                if (moodNum > 0 && moodNum < 11)
                {
                    entry._mood = moodNum;
                }
            }
        }
    

    // Set Prompt
        string randPrompt = prompt.GetPrompt();
        entry._prompt = randPrompt;
        Console.WriteLine();
        Console.WriteLine(randPrompt);
        Console.Write("> ");

    // Set Response
        string response = Console.ReadLine();
        entry._response = response;
        
    // Set Date
        DateTime currentTime = DateTime.Now;
        entry._date = currentTime.ToShortDateString();

    // Add entry
        _entries.Add(entry);
        Console.WriteLine();
    }

    public void DisplayEntries()
    {
        int entry_num = _entries.Count();
        if (entry_num != 0)
        {   foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine("There are no entries in the Journal right now.");
            Console.WriteLine();
        }

    }
    
// LoadFromFile, 
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
                Entry entry = new Entry();
                
                string[] parts = line.Split('|');
                
                entry._date = parts[0];
                entry._mood = int.Parse(parts[1]);
                entry._prompt = parts[2];
                entry._response = parts[3];
                _entries.Add(entry);
                Console.WriteLine($"Data from {filename} was successfully loaded.");
        }
            
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"""{entry._date}|{entry._mood}|{entry._prompt}|{entry._response}""");
            }
        }
    }
}