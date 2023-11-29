public class Goals
{
    private static string _shortName;
    private static string _description;
    private static int _points = 0;
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public Goals(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    
    public virtual string GetDetailsString()
    {
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
    public static string GetName()
    {
        return _shortName;
    }
    public void SetName(string name)
    {
        _shortName = name;
    }
    public static string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public static int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
}