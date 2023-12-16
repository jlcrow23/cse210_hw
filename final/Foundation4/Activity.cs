public abstract class Activity
{
    private string _date;
    private static string _type;
    private double _time;
    private static double _distance;
    
    public string GetDate()
    {
        return _date;
    }
    public static string GetActivityType()
    {
        return _type;
    }
    public double GetActivityTime()
    {
        return _time;
    }
    public static double GetDistance()
    {
        return _distance;
    }
    
    public Activity(string date, string type, double time, double distance)
    {
        _date = date;
        _type = type;
        _time = time;
        _distance = distance;
    }
    public abstract string GetPace();
    public abstract string GetSpeed();
    public abstract string GetSummary();
    public abstract string GetTotalDistance();
    
    
}