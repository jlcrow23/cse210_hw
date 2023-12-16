using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("12/17/2023", "Running", 30, 3.0);
        Console.WriteLine(runningActivity.GetTotalDistance());
        Console.WriteLine(runningActivity.GetSpeed());
        Console.WriteLine(runningActivity.GetPace());
        Console.WriteLine(runningActivity.GetSummary());

        StationaryBicycleActivity stationaryBicycleActivity = new StationaryBicycleActivity("12/17/2023", "Biking", 20, 1.5);
        Console.WriteLine(stationaryBicycleActivity.GetTotalDistance());
        Console.WriteLine(stationaryBicycleActivity.GetSpeed());
        Console.WriteLine(stationaryBicycleActivity.GetPace());
        Console.WriteLine(stationaryBicycleActivity.GetSummary());

        SwimmingActivity swimmingActivity = new SwimmingActivity("12/23/2023", "Swimming", 45, 25, SwimmingActivity.GetSwimDistance());
        Console.WriteLine(swimmingActivity.GetTotalDistance());
        Console.WriteLine(swimmingActivity.GetSpeed());
        Console.WriteLine(swimmingActivity.GetPace());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}