public class ReceptionEvent : Event 
{
    private string rsvpEmail;

    public string RsvpEmail 
    { 
        get { return rsvpEmail; } 
        set { rsvpEmail = value; } 
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + 
               $"\nEvent Type: Reception\n" +
               $"RSVP Email: {rsvpEmail}";
    }

    public string GetShortDescription()
    {
        return $"Reception: {Title} on {EventDateTime.ToShortDateString()}";
    }
}