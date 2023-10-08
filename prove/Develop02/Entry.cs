using System;
using System.Collections.Generic;

public class Entry
{
    private List<string> journalQuestions;
    private List<string> userResponses;
    private Random random;
    public string GetRandomEntryPrompt()
    {
        journalQuestions = new List<string>
        {
            "What did you accomplish today?",
            "What are your top priorities for tomorrow?",
            "What was the highlight of your day?",
            "What are you grateful for today?",
            "How did you handle a challenging situation today?",
            "What did you learn about yourself today?",
            "What made you smile today?",
            "Describe a moment of personal growth today.",
            "Who did you connect with today, and how did it make you feel?",
            "What is a goal you are working toward, and what progress did you make today?",
            "Write about a decision you made today and its impact.",
            "How did you take care of your physical and mental well-being today?",
            "What creative or innovative ideas came to mind today?",
            "Did you encounter any obstacles, and how did you overcome them?",
            "Write about a book, article, or quote that inspired you today.",
            "How did you make someone else's day better today?",
            "Reflect on a moment of kindness or gratitude you experienced today.",
            "What do you want to remember about today?",
            "How did you spend your leisure time today, and did it recharge you?",
            "What steps are you taking toward achieving your long-term goals?"
        };
        userResponses = new List<string>();
        random = new Random();
        int index = random.Next(journalQuestions.Count);
        return journalQuestions[index];
    }

    public void Save(string response)
    {
        userResponses.Add(response);
    }

    public void Display()
    {
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"Journal Entries for {currentDate.ToShortDateString()}:");
        for (int i = 0; i < Program.entry; i++)
        {
            Console.WriteLine($"Entry {i + 1}: {userResponses[i]}");
        }
    }
}
