class Program
{
    static void Main()
    {
        List<Goal> Goals = new List<Goal>();
        int totalPoints = 0;

        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal(Goals);
                    break;
                case 2:
                    ListGoals(Goals, totalPoints);
                    break;
                case 3:
                    File.SaveGoals(Goals);
                    break;
                case 4:
                    Goals = File.LoadGoals();
                    break;
                case 5:
                    RecordEvent(Goals, ref totalPoints);
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
            }
        }
    }

    static void CreateNewGoal(List<Goal> Goals)
    {
        Console.WriteLine("What kind of goal would you like to create?");
        Console.WriteLine("1. Eternal Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Simple Goal");
        Console.WriteLine("4. Go Back");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter the name of the Eternal Goal: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter the value for the Eternal Goal: ");
                int eternalValue = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal { Name = eternalName, Value = eternalValue };
                Goals.Add(eternalGoal);
                Console.WriteLine("Eternal Goal set!");
                break;
            case 2:
                Console.Write("Enter the name of the Checklist Goal: ");
                string checklistName = Console.ReadLine();
                Console.Write("Enter the value for each completion of the Checklist Goal: ");
                int checklistValue = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of times to complete the Checklist Goal: ");
                int completionValue = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal { Name = checklistName, Value = checklistValue, CompletionValue = completionValue };
                Goals.Add(checklistGoal);
                Console.WriteLine("Checklist Goal set!");
                break;
            case 3:
                Console.Write("Enter the name of the Simple Goal: ");
                string simpleName = Console.ReadLine();
                Console.Write("Enter the value for the Simple Goal: ");
                int simpleValue = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal { Name = simpleName, Value = simpleValue };
                Goals.Add(simpleGoal);
                Console.WriteLine("Simple Goal set!");
                break;
            case 4:
                break; // Go back to main menu
        }
    }

    static void ListGoals(List<Goal> Goals, int totalPoints)
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("You have not created any goals");
        }
        else
        {
            Console.WriteLine("Simple Goals:");
            foreach (var goal in Goals)
            {
                if (goal is SimpleGoal)
                {
                    goal.Display();
                }
            }

            Console.WriteLine("\nChecklist Goals:");
            foreach (var goal in Goals)
            {
                if (goal is ChecklistGoal)
                {
                    goal.Display();
                }
            }

            Console.WriteLine("\nEternal Goals:");
            foreach (var goal in Goals)
            {
                if (goal is EternalGoal)
                {
                    goal.Display();
                }
            }

            Console.WriteLine($"\nTotal Points: {totalPoints}");
        }

        Console.ReadLine();
    }

    static void RecordEvent(List<Goal> Goals, ref int totalPoints)
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("No existing goals to record events for.");
            return;
        }

        Console.WriteLine("Select the goal to record an event for:");

        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].Name}");
        }

        int selectedGoalIndex = int.Parse(Console.ReadLine()) - 1;

        if (selectedGoalIndex < 0 || selectedGoalIndex >= Goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal selectedGoal = Goals[selectedGoalIndex];
        selectedGoal.Complete(ref totalPoints);
    }
}