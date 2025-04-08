public class Simple : Goal
{
    public Simple(string goalName, string goalDescription, int points, bool isComplete = false) : base(goalName, goalDescription, points)
{
    _isComplete = isComplete;
}

    public override bool Completed()
    {

        return _isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{Name()} marked as completed!");
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Simple:{Name()},{Description()},{GetPoints()},{Completed()}";
    }

    public static Simple CreateFromString(string details)
    {
        string[] parts = details.Split(',');
        return new Simple(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
    }
}