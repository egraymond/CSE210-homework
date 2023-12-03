class Goal
{
    public string Name { get; set; }
    public int Completed { get; set; }
    public int Value { get; set; }

    public virtual void Display()
    {
        Console.WriteLine($"{Name} | Completed ({Completed}) | Value: {Value}");
    }

    public virtual void Complete(ref int totalPoints)
    {
        Console.WriteLine("Goal completed!");
        totalPoints += Value;
    }
}
