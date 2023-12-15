public abstract class Event
{
    private static string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescrip()
    {
        return _description;
    }
    public string GetDateTime()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetAddress()
    {
        return _address;
    }
    public static string GetEventType()
    {
        return _type;
    }
    public Event(string type, string title, string description, string address, string date, string time)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string StandardDetails()
    {
        return "Title:\t" + _title + "\nWhat:\t" + _description + "\nWhere:" + _address + "\nWhen:\t" + _date +" "+ _time;
    }
    
    public abstract string FullDetails();
    
    public string ShortDescrip()
    {
        return "What:\t" + _type + "\nAbout:\t" + _title + "\nWhen:\t" + _date;
    }
    
}