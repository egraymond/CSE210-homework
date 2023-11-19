public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _userStorage;
    private int _sum;

    public ListingActivity()
    {
        _prompts = new List<string>();
        _userStorage = new List<string>();
        GetPrompt();
    }

    public void GetPrompt()
    {
        _prompts.Add("What made you smile today?");
        _prompts.Add("Describe a challenge you overcame recently.");
        _prompts.Add("What are three things you are grateful for today?");
        _prompts.Add("Reflect on a recent challenge you faced. How did you handle it, and what did you learn from the experience?");
        _prompts.Add("What are three short-term goals you want to accomplish this week? How can you break them down into smaller, actionable steps?");
        _prompts.Add("Take a moment to observe your surroundings. What sounds, sights, or sensations are you currently experiencing? How does it make you feel?");
        _prompts.Add("In what ways have you grown or changed over the past year? What lessons have you learned about yourself?");
        _prompts.Add("Describe a moment from today that brought you joy or made you smile. What made it special?");
        _prompts.Add("Identify a current challenge you're facing. What steps can you take to overcome this challenge, and what resources or support can you tap into?");
        _prompts.Add("How have you practiced self-care today? If you haven't, what small act of self-care can you incorporate into your day?");
        _prompts.Add("Imagine yourself a year from now. What goals do you hope to have achieved, and what positive changes do you envision in your life?");
        _prompts.Add("On a scale of 1 to 10, how would you rate your current mood, and why?");
        _prompts.Add("What is one thing you learned or discovered recently?");
        _prompts.Add("Describe a small act of kindness you either gave or received today.");
        _prompts.Add("What is one thing you are looking forward to achieving or experiencing in the near future?");

    }

    public void CreateResponseArea(int timer)
    {
        Console.Clear();
        Console.Write($"Get Ready in ");
        Countdown();
        

        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            _userStorage.Add(response);
            _sum++;
            Console.Clear();
        }

        Console.WriteLine($"You answered {_sum} questions. Press Enter to continue...");
        Console.ReadLine();
    }
}