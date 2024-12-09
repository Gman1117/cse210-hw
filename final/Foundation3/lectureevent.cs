public class LectureEvent : Event 
{
    private string speakerName;
    private int capacity;

    public string SpeakerName 
    { 
        get { return speakerName; } 
        set { speakerName = value; } 
    }

    public int Capacity 
    { 
        get { return capacity; } 
        set { capacity = value; } 
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + 
               $"\nEvent Type: Lecture\n" +
               $"Speaker: {speakerName}\n" +
               $"Capacity: {capacity} attendees";
    }

    public string GetShortDescription()
    {
        return $"Lecture: {Title} on {EventDateTime.ToShortDateString()}";
    }
}