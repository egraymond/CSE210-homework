class ChecklistGoal : Goal
{
    public int CompletionValue { get; set; }

    public override void Display()
    {
        Console.WriteLine($"{Name} | Completed ({Completed}/{CompletionValue}) | Value: {Value} | Completion Value: {CompletionValue}");
    }

    public override void Complete(ref int totalPoints)
    {
        Console.WriteLine("Checklist goal completed!");
        Completed++;
        totalPoints += Value;
        if (Completed == CompletionValue)
        {
            Console.WriteLine($"Congratulations! You've completed the entire checklist! Adding {CompletionValue} extra points.");
            totalPoints += CompletionValue;
        }
    }
}