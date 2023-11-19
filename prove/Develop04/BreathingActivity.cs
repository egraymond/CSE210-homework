public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        
    }
    public void Start(int maxTime)
    {
        Console.Write($"Get ready to BREATHE in ");
        Countdown();
        Console.Clear();
        for(int i = 0; i < maxTime; i+= 5)
        {
            Breathe();
        }
        Breathe(); 
    }
    public void BreatheIn()
    {
        Console.Write($"Breathe in ");
        Timer();
        Console.Clear();
    }
    public void BreatheOut()
    {
        Console.Write("Breathe out ");
        Timer();
        Console.Clear();
    }
    public void Breathe()
    {
        BreatheIn();
        BreatheOut(); 
    }
}