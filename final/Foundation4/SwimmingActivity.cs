public class SwimmingActivity : Activity
{
    private static int _laps;
    public SwimmingActivity(string date, string type, double time, int laps, double distance) : base(date, type, time, distance)
    {
        _laps = laps;
        Console.WriteLine(Activity.GetActivityType());
    }
    public static double GetSwimDistance()
    {
        double swimDistance = _laps * 50 / 1000 * 0.62;
        return swimDistance;
    }
    public override string GetPace()
    {
        double pace1 = GetActivityTime() / _laps;
        return "Pace: " + pace1 + " minutes per lap, ";
    }
    public override string GetSpeed()
    {
        double speed1 = _laps/GetActivityTime() * 60;
        return "Speed: " + speed1 + " laps per hour, ";
    }
    public override string GetTotalDistance()
    {
        return "Distance: " + GetSwimDistance() + " miles, ";
        
    }
    public override string GetSummary()
    {
        return GetDate() + " " + GetActivityType()  + " Laps: " + _laps + " (" + GetActivityTime() + " min) " + "-"+ GetTotalDistance() + GetSpeed() + GetPace();
    }
}