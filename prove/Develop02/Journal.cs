class Journal
{
    public static void Save()
    {
        Console.Write("Enter the name of the text file to save (Leave blank for the default file): ");
        string fileName = Console.ReadLine();
        if (fileName == "")
        {
            fileName = "default";
        }


        using (StreamWriter sw = new StreamWriter(fileName))
        {
            for (int i = 0; i < Program.generatedResponse.Count; i++)
            {
                sw.WriteLine("Prompt: " + Program.generatedResponse[i]);
                sw.WriteLine("Your Answer: " + Program.writtenResponse[i]);
            }
        }

        Console.WriteLine("Data saved to the file.");
    }

    public static void Load()
    {
        Console.Write("Enter the name of the text file to load (Leave blank for the default file, Cannot load files that do not exist): ");
        string fileName = Console.ReadLine();
        if (fileName == "")
        {
            fileName = "default";
        }

        Program.generatedResponse.Clear();
        Program.writtenResponse.Clear();
        using (StreamReader sr = new StreamReader(fileName))
        {
            string line;
            string currentGeneratedResponse = "";
            string currentWrittenResponse = "";
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("Prompt: "))
                {
                    currentGeneratedResponse = line.Substring("Prompt: ".Length);
                }
                else if (line.StartsWith("Your Answer: "))
                {
                    currentWrittenResponse = line.Substring("Your Answer: ".Length);
                    Program.generatedResponse.Add(currentGeneratedResponse);
                    Program.writtenResponse.Add(currentWrittenResponse);
                }
            }
        }
        Console.WriteLine("Data loaded from the file.");
    }
}