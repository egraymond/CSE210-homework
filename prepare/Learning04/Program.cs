using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Elias Garlitz", "Fractions");
        Console.WriteLine(assignment.getSummary());

        Math assignment2 = new Math("Elias Garlitz", "Algebra", "2-3", "4-5");
        Console.WriteLine(assignment2.getSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Writing assignment3 = new Writing("Elias Garlitz", "History", "War and Peace");
        Console.WriteLine(assignment3.getSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}