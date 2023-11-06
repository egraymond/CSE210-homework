class Entry
{
    private static List<string> questions = new List<string>
    {
        "What are three things you're grateful for today, and why?",
        "Describe a time when you overcame a significant challenge. What did you learn from that experience?",
        "Write a letter to your future self, reflecting on your goals and aspirations.",
        "What are your top three priorities in life right now, and how are you working towards them?",
        "Explore a moment in your life when you felt truly happy and content. What contributed to that feeling?",
        "Write about a book, movie, or song that has recently had a significant impact on you, and explain why.",
        "What is a personal weakness or fear you'd like to overcome, and what steps can you take to address it?",
        "Reflect on a recent mistake or failure. What did you learn from it, and how can you use that knowledge for personal growth?",
        "Describe your ideal day from start to finish. What activities and experiences would make it perfect for you?"
    };

    public static void Write()
    {
        Random random = new Random();
        int index = random.Next(0, questions.Count);

        Console.WriteLine("Question: " + questions[index]);
        Console.Write("Your Answer: ");
        string userAnswer = Console.ReadLine();

        Program.generatedResponse.Add(questions[index]);
        Program.writtenResponse.Add(userAnswer);
    }
}