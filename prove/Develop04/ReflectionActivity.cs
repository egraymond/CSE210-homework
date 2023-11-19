public class ReflectionActivity : Activity
{
    private List<string> _reflectQuestionList;

    public ReflectionActivity()
    {
        _reflectQuestionList = new List<string>();
        GetReflectQuestion();
    }

    public void GetReflectQuestion()
    {
        _reflectQuestionList.Add("What did you learn today?");
        _reflectQuestionList.Add("Describe a moment that challenged you.");
        _reflectQuestionList.Add("What does success mean to you, and how does it align with your values and purpose?");
        _reflectQuestionList.Add("If you could have a conversation with your future self, what advice would you give to your present self?");
        _reflectQuestionList.Add("In what ways do your beliefs limit or empower you, and how might shifting perspectives impact your life?");
        _reflectQuestionList.Add("If you could choose one skill or knowledge to master in the next year, what would it be, and how might it transform your life?");
    }

    public void Reflect(int timer)
    {
        Console.Write($"Starting in: ");
        Countdown();

        foreach (var question in _reflectQuestionList)
        {
            DisplayQuestionForSeconds(question);
            Console.Clear();
        }

        Console.WriteLine("You have completed the Reflection Activity.");
        Console.WriteLine("Press Enter to return to the main menu...");
        Console.ReadLine();
    }

    private void DisplayQuestionForSeconds(string question)
    {
        Console.Write(question);
        Timer();
    }
}