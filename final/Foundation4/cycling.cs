public class Cycling : Activity
{
    private double speed;

    public double Speed 
    { 
        get { return speed; } 
        set { speed = value; } 
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * Minutes / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Cycling ({Minutes} min) - Distance {GetDistance():F1} miles, Speed {speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}