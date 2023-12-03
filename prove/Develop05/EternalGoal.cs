class EternalGoal : Goal
{
    public override void Display()
    {
        Console.WriteLine($"{Name} | Completed (Infinite) | Value: {Value}");
    }

    public override void Complete(ref int totalPoints)
    {
        Console.WriteLine("Eternal goal completed!");
        totalPoints += Value;
    }
}