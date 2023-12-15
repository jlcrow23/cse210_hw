public class ReceptionEvent : Event
{
    private string _rsvp;
    public string GetRsvp()
    {
        return _rsvp;
    }
    public ReceptionEvent(string type, string title, string rsvp, string description, string address, string date, string time) : base (type, title, description, address, date, time)
    {
        _rsvp = rsvp;
    }
    
    public override string FullDetails()
    {
        return "Event Type:\t" + GetEventType() + "\nEvent Title:\t" + GetTitle() + "\nRSVP:\t" + _rsvp + "\nWhat:\t"+ GetDescrip() + "\nWhere:" + GetAddress() +"\nWhen:\t"+GetDateTime() +" "+GetTime()+"\n";
    }
    
}