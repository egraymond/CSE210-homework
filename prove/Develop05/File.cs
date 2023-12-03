using System;
using System.Collections.Generic;
using System.IO;

class File
{
    private const string FileName = "goals.txt";

    public static void SaveGoals(List<Goal> goals)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach (var goal in goals)
                {
                    string line = $"{goal.GetType().Name},{goal.Name},{goal.Completed},{goal.Value}";

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        line += $",{checklistGoal.CompletionValue}";
                    }

                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Goals saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public static List<Goal> LoadGoals()
    {
        List<Goal> goals = new List<Goal>();

        try
        {
            if (System.IO.File.Exists(FileName))
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] parts = reader.ReadLine().Split(',');

                        if (parts.Length < 4)
                        {
                            Console.WriteLine("Invalid data format in the file.");
                            continue;
                        }

                        string type = parts[0];
                        string name = parts[1];
                        int completed = int.Parse(parts[2]);
                        int value = int.Parse(parts[3]);

                        Goal goal;

                        switch (type)
                        {
                            case nameof(EternalGoal):
                                goal = new EternalGoal { Name = name, Completed = completed, Value = value };
                                break;
                            case nameof(ChecklistGoal):
                                if (parts.Length < 5)
                                {
                                    Console.WriteLine("Invalid data format for ChecklistGoal in the file.");
                                    continue;
                                }

                                int completionValue = int.Parse(parts[4]);
                                goal = new ChecklistGoal { Name = name, Completed = completed, Value = value, CompletionValue = completionValue };
                                break;
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal { Name = name, Completed = completed, Value = value };
                                break;
                            default:
                                Console.WriteLine($"Unknown goal type: {type}");
                                continue;
                        }

                        goals.Add(goal);
                    }
                }

                Console.WriteLine("Goals loaded from file.");
            }
            else
            {
                Console.WriteLine("No saved goals file found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }

        return goals;
    }
}