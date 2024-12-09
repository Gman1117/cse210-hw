public class Running : Activity
{
    private double distance;

    public double Distance 
    { 
        get { return distance; } 
        set { distance = value; } 
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Running ({Minutes} min) - Distance {distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}