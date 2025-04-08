public class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public Checklist(string goalName, string goalDescription, int points, int targetCount, int currentCount, int bonus): base(goalName, goalDescription, points)
    {
    _targetCount = targetCount;
    _currentCount = currentCount;
    _bonus = bonus;
    }



    public override bool Completed()
    {
        return _currentCount >= _targetCount;
    }

    public int TargetCount()
    {
        return _targetCount;
    }

    public int CurrentCount()
    {
        return _currentCount;
    }

    public int GetBonus()
    {
        return _bonus;
    }


    public override void RecordEvent()
    {
        if (!Completed())
        {
            _currentCount++;
            Console.WriteLine($"Progress: {_currentCount}/{_targetCount}");
            if (Completed())
            {
                _isComplete = true;
                Console.WriteLine($"Checklist goal '{Name()}' completed! Bonus: {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already completed.");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{Name()},{Description()},{GetPoints()},{_targetCount},{_currentCount},{_bonus}";
    }

    public static Checklist CreateFromString(string details)
    {
        string[] parts = details.Split(',');
        return new Checklist(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
    }
}
