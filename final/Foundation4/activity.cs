public abstract class Activity
{
    private DateTime date;
    private int minutes;

    public DateTime Date 
    { 
        get { return date; } 
        set { date = value; } 
    }

    public int Minutes 
    { 
        get { return minutes; } 
        set { minutes = value; } 
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return GetDistance() / Minutes * 60;
    }

    public virtual double GetPace()
    {
        return Minutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} Unknown Activity ({minutes} min)";
    }
}