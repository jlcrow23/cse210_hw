public class RunningActivity : Activity
{
    public RunningActivity(string date, string type, double time, double distance) : base(date, type, time, distance)
    {
        Console.WriteLine(Activity.GetActivityType());
    }
    public override string GetPace()
    {
        double pace1 = GetActivityTime() / GetDistance();
        return "Pace: " + pace1 + " minutes per mile, ";
    }
    public override string GetSpeed()
    {
        double speed1 = GetDistance()/GetActivityTime() * 60;
        return "Speed: " + speed1 + " miles per hour, ";
    }
    public override string GetTotalDistance()
    {
        return "Distance: " + GetDistance()+ " miles, ";
    }

    public override string GetSummary()
    {
        return GetDate() + " " + GetActivityType() + " (" + GetActivityTime() + " min)- " + GetTotalDistance() + GetSpeed() + GetPace();
    }
}