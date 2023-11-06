class Program
{
    public static List<string> generatedResponse = new List<string>();
    public static List<string> writtenResponse = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Write");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Display();
                    break;
                case 2:
                    Console.Clear();
                    Entry.Write();
                    break;
                case 3:
                    Console.Clear();
                    Journal.Save();
                    break;
                case 4:
                    Console.Clear();
                    Journal.Load();
                    break;
                case 5:
                    Console.Clear();
                    Quit();
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }
    }

    static void Display()
    {
        for (int i = 0; i < generatedResponse.Count; i++)
        {
            Console.WriteLine($"Prompt: {generatedResponse[i]}");
            Console.WriteLine($"Your Answer: {writtenResponse[i]}\n");
        }
    }

    static void Quit()
    {
        Environment.Exit(0);
    }
}
