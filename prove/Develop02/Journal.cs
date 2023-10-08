using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private string journalFilePath;

    public Journal(string filePath)
    {
        journalFilePath = filePath;
    }

    public List<string> LoadEntries()
    {
        List<string> entries = new List<string>();
        try
        {
            if (File.Exists(journalFilePath))
            {
                string[] lines = File.ReadAllLines(journalFilePath);
                entries.AddRange(lines);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal entries: {ex.Message}");
        }
        return entries;
    }

    public void SaveEntries(List<string> entries)
    {
        try
        {
            File.WriteAllLines(journalFilePath, entries);
            Console.WriteLine("Journal entries saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal entries: {ex.Message}");
        }
    }
    public void AddEntry(string entry)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(journalFilePath))
            {
                sw.WriteLine(entry);
                Console.WriteLine("Journal entry added successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding journal entry: {ex.Message}");
        }
    }
}