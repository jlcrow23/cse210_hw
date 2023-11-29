public class ChecklistGoals : Goals
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoals(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
        return "This is a string";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}