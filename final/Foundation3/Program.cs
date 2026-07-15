using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Events

        // Lecture Event
        Lecture lecture = new Lecture("Dr. Jane Carter", 250, "Lecture", "The Future of Artificial Intelligence", "Learn how AI is changing industries and what the future may hold.",
            new DateTime(2026, 10, 15, 19, 0, 0), new Address("100 University Blvd.", "Rexburg", "ID", "USA"));
        
        // Outdoor Gathering
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering", "Summer Community Picnic", "Bring your family for food, games, and live music in the park.",
            new DateTime(2026, 7, 25, 12, 30, 0), new Address("500 Seagull Street", "Portland", "ME", "USA"), "Sunny with a high of 82°F");
        
        // Reception
        Reception reception = new Reception("Reception", "Johnson Wedding Reception", "Celebrate the marriage of Emily and Michael Johnson with dinner and dancing.",
            new DateTime(2026, 9, 12, 18, 0, 0), new Address("250 Degree Way", "Phoenix", "AZ", "USA"), "rsvp@johnsonwedding.com");
        // For Each:
        // Run Standard Details, Full Details, Short Description
        List<Event> events = new List<Event>(){lecture, outdoorGathering, reception};

        foreach (Event eventObj in events)
        {
            eventObj.ShowStandardDetails();
            Console.WriteLine();
            eventObj.ShowFullDetails();
            Console.WriteLine();
            eventObj.ShowShortDescription();
            Console.WriteLine();
            Console.WriteLine();
        }        
    }
}