public class Eternal : Goal
{
    public Eternal(string goalName, string goalDescription, int points)
        : base(goalName, goalDescription, points) {}

    public override bool Completed()
    {
        return false; // Eternal goals never complete
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal '{Name()}' recorded. Keep it up!");
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal:{Name()},{Description()},{GetPoints()}";
    }

    public static Eternal CreateFromString(string details)
    {
        string[] parts = details.Split(',');
        return new Eternal(parts[0], parts[1], int.Parse(parts[2]));
    }
}
