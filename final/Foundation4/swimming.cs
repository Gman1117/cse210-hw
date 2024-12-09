public class Swimming : Activity
{
    private int laps;

    public int Laps 
    { 
        get { return laps; } 
        set { laps = value; } 
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({Minutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
