using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        // Step 1: Grab Reference string using constructors, 
        // store in variable
        string filename = "library.csv";
        List<string> refData = new List<string>();
        List<string> scriptureData = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            refData.Add(parts[0]);
            scriptureData.Add(parts[1]);
        }
        
        int randomIndex = Random.Shared.Next(refData.Count);
        string[] splitRef = refData[randomIndex].Split(',');
        string book = splitRef[0];
        int chapter = int.Parse(splitRef[1]);
        int startVerse = int.Parse(splitRef[2]);
        Reference reference;
        if (splitRef.Length == 4)
        {
            int endVerse = int.Parse(splitRef[3]);
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference(book, chapter, startVerse);
        }


        // Grab Scripture Text, store in variable
           string scriptureText = scriptureData[randomIndex];

        List<Word> words = new List<Word>();
        Scripture scripture = new Scripture(scriptureText, words);
        
        // Split scripture text on each space, 
        // place each word into a Word class instance and 
        // add them to scripture variable _words
        string singleLine = scriptureText.ReplaceLineEndings(string.Empty);
        string[] splitText = singleLine.Split(' ');

        // scriptureText.split() Split on spaces
        // run a For loop that places each word into a Word class object
       
        foreach (string i in splitText)
        {
            Word word = new Word();
            word.SetWord(i);
            word.SetHiddenWord();
            scripture.AddWord(word);
        }

        bool running = true;
        while (running) 
        {
            List<Word> wordList = scripture.GetWords();
            
            // Display Scripture and Passage
            string refText = reference.GetReference();
            Console.Write($"{refText}");
            foreach (Word word in wordList)
            {
                string wordText = word.GetWord();
                Console.Write($"{wordText} ");
            }
            Console.WriteLine();
            Console.Write("Press Enter to start - Type 'quit' to quit: ");
            string input = Console.ReadLine();
            
            if (input == "")
            {
                do
                {
                    bool runProgram = true;
                    while (runProgram)
                    {
                        Console.Clear();
                        // Get Random Words
                        int randIndex1 = scripture.GetRandomIndex();
                        int randIndex2 = scripture.GetRandomIndex();
                        int randIndex3 = scripture.GetRandomIndex();
                        Word word1 = wordList[randIndex1];
                        Word word2 = wordList[randIndex2];
                        Word word3 = wordList[randIndex3];
                        word1.Hide();
                        word2.Hide();
                        word3.Hide();
                        // Print Passage
                        Console.Write($"{refText}");
                        // completelyHidden is primed
                        bool completelyHidden = true;
                        foreach (Word word in wordList)
                        {
                            string text = word.GetWord();
                            Console.Write($"{text} ");
                            
                            // If word.GetHiddenStatus() returns False, 
                            // ! changes it to True and the door opens.
                            // If True, changes to False and door remains closed.
                            if (!word.GetHiddenStatus())
                            {
                                completelyHidden = false;
                            }
                        }

                        Console.WriteLine();

                        if (completelyHidden)
                        {
                            runProgram = false;
                            input = "quit";
                            Console.Clear();
                            break;
                            
                            
                        }

                        Console.Write("Press Enter to proceed - Type 'quit' to quit: ");
                        input = Console.ReadLine();

                        if (input == "quit")
                        {
                            runProgram = false;
                            running = false;
                        }

                    }
                } while (input == "");
            }
                
            else if (input == "quit")
            {
                running = false;
            }
        
            }
        }
}

