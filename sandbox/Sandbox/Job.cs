public class Job
{
    public string _Title;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_Title} ({_company}) {_startYear}-{_endYear}");
    }
}