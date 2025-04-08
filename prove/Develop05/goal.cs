public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _points;
    protected bool _isComplete = false;
    

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
        
        
    }

    public string Name()
    {
        return _goalName;
        
    }

    public string Description()
    {
        return _goalDescription;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract bool Completed();

    public abstract void RecordEvent();

    public abstract string GetStringRepresentation();
}