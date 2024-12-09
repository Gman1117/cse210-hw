public class Event 
{
    private string title;
    private string description;
    private DateTime eventDateTime;
    private Address eventAddress;

    public string Title 
    { 
        get { return title; } 
        set { title = value; } 
    }

    public string Description 
    { 
        get { return description; } 
        set { description = value; } 
    }

    public DateTime EventDateTime 
    { 
        get { return eventDateTime; } 
        set { eventDateTime = value; } 
    }

    public Address EventAddress 
    { 
        get { return eventAddress; } 
        set { eventAddress = value; } 
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\n" +
               $"Description: {description}\n" +
               $"Date: {eventDateTime.ToShortDateString()}\n" +
               $"Time: {eventDateTime.ToShortTimeString()}\n" +
               $"Address: {eventAddress.GetFullAddress()}";
    }
}