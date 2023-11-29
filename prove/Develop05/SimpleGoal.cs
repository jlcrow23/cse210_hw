public class SimpleGoals : Goals
{
    private bool _isComplete;
    public SimpleGoals(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {

    }
    
    public  override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}