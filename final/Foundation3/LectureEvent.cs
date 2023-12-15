public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;
    public LectureEvent(string type, string title, string speaker, int capacity, string description, string address, string date, string time) : base (type, title, description, address, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    
    public override string FullDetails()
    {
        return "Event Type:\t" + GetEventType() + "\nEvent Title:\t" + GetTitle() + "\nSpeaker:\t" + _speaker +"\nCapacity:\t" + _capacity + "\nWhat:\t"+ GetDescrip() + "\nWhere:\t" + GetAddress() +"\nWhen:\t"+GetDateTime() +" "+GetTime()+"\n";
    }
    
}