using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        DateTime currentTime = DateTime.Now;
        entry._date = currentTime.ToShortDateString();
        entry._prompt = "<Insert prompt text here>";
        entry._response = "<Insert user response here>";
        entry.Display();

    }
}