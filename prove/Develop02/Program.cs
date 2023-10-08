using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal App!");

        Console.Write("Enter the path of the journal file: ");
        string filePath = Console.ReadLine();

        Journal journal = new Journal(filePath);
        Entry journalEntry = new Entry();
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Create");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option (1-6): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        string randomQuestion = journalEntry.GetRandomEntryPrompt();
                        Console.WriteLine($"Question: {randomQuestion}");

                        Console.Write("Your Answer: ");
                        string userResponse = Console.ReadLine();
                        journalEntry.Save(userResponse);
                        entryCount = entryCount + 1;

                        journal.AddEntry($"{randomQuestion}\n{userResponse}\n");
                        break;

                    case 2:
                        journalEntry.Display();
                        break;

                    case 3:
                        List<string> loadedEntries = journal.LoadEntries();
                        Console.WriteLine("Loaded Journal Entries:");
                        foreach (var entry in loadedEntries)
                        {
                            Console.WriteLine(entry);
                        }
                        break;

                    case 4:
                        //List<string> allEntries = journalEntry.GetUserResponses();
                        //journal.SaveEntries(allEntries);
                        //break;

                    case 5:
                        Console.Write("Enter the name of the new journal file: ");
                        filePath = Console.ReadLine();
                        journal = new Journal(filePath);
                        break;

                    case 6:
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1-6).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number (1-6).");
            }
        }

        Console.WriteLine("Thank you for using the Journal App!");
    }
}