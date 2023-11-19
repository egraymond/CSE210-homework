public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the activity program, choose one of the options below:");
            Console.WriteLine("1. Begin Breathing Activity");
            Console.WriteLine("2. Begin Reflecting Activity");
            Console.WriteLine("3. Begin Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Console.Clear();
                    Console.Write("Enter the duration for breathing (in seconds): ");
                    int breathingTimer = int.Parse(Console.ReadLine());
                    breathingActivity.Start(breathingTimer);
                    break;

                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    Console.Clear();
                    Console.Write("Enter the duration for reflection (in seconds): ");
                    int reflectionTimer = int.Parse(Console.ReadLine());
                    reflectionActivity.Reflect(reflectionTimer);
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    Console.Clear();
                    Console.Write("Enter the duration for the listing activity (in seconds): ");
                    int listingTimer = int.Parse(Console.ReadLine());
                    listingActivity.CreateResponseArea(listingTimer);
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}