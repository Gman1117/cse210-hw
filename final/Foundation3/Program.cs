using System;

class Program 
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address 
        {
            Street = "123 Learning Lane",
            City = "Knowledge City",
            State = "ED",
            ZipCode = "12345"
        };

        LectureEvent lecture = new LectureEvent 
        {
            Title = "Machine Learning Basics",
            Description = "An introductory course on machine learning concepts",
            EventDateTime = new DateTime(2024, 7, 15, 14, 0, 0),
            EventAddress = lectureAddress,
            SpeakerName = "Dr. Emily Rogers",
            Capacity = 50
        };

        Address receptionAddress = new Address 
        {
            Street = "456 Celebration Street",
            City = "Party Town",
            State = "CE",
            ZipCode = "67890"
        };

        ReceptionEvent reception = new ReceptionEvent 
        {
            Title = "Tech Industry Networking Event",
            Description = "Annual networking mixer for tech professionals",
            EventDateTime = new DateTime(2024, 8, 20, 18, 30, 0),
            EventAddress = receptionAddress,
            RsvpEmail = "rsvp@techevent.com"
        };

        Address outdoorAddress = new Address 
        {
            Street = "789 Green Park",
            City = "Outdoor City",
            State = "NA",
            ZipCode = "54321"
        };

        OutdoorGatheringEvent outdoorGathering = new OutdoorGatheringEvent 
        {
            Title = "Community Picnic",
            Description = "Annual neighborhood picnic and fun day",
            EventDateTime = new DateTime(2024, 9, 5, 11, 0, 0),
            EventAddress = outdoorAddress,
            WeatherForecast = "Sunny with mild temperatures"
        };

        Console.WriteLine("Lecture Event Details:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine("Reception Event Details:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine("Outdoor Gathering Event Details:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}