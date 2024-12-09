public class OutdoorGatheringEvent : Event 
{
    private string weatherForecast;

    public string WeatherForecast 
    { 
        get { return weatherForecast; } 
        set { weatherForecast = value; } 
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + 
               $"\nEvent Type: Outdoor Gathering\n" +
               $"Weather Forecast: {weatherForecast}";
    }

    public string GetShortDescription()
    {
        return $"Outdoor Gathering: {Title} on {EventDateTime.ToShortDateString()}";
    }
}