class Program
{
    static void Main()
    {
        Reference reference = new Reference();

        string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth \nno commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture scripture = new Scripture("1 Nephi 3:7", scriptureText);

        Console.WriteLine("Welcome to the Scripture Hiding Program. Press Enter to start.");
        Console.ReadLine();

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.DisplayText());
            Console.WriteLine("Press Enter to hide 1-3 words or Enter again to quit.");
            Console.ReadLine();

            if (!scripture.IsCompletelyHidden())
            {
                Random random = new Random();
                int count = random.Next(1, 4);
                scripture.HideWords(count);
            }
        }

        Console.WriteLine("All words are hidden. Press Enter to quit.");
        Console.ReadLine();
    }
}