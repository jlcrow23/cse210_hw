public class OutdoorEvent : Event
{
    private string _weather;
    public string GetWeather()
    {
        return _weather;
    }
    public OutdoorEvent(string type, string title, string weather, string description, string address, string date, string time) : base (type, title, description, address, date, time)
    {
        _weather = weather;
    }
    
    public override string FullDetails()
    {
        return "Event Type:\t" + GetEventType() + "\nEvent Title:\t" + GetTitle() + "\nWeather Oulook:\t" + _weather + "\nWhat:\t"+ GetDescrip() + "\nWhere: " + GetAddress() +"\nWhen:\t"+GetDateTime() +" "+GetTime();
    }
}
   