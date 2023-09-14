using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string percent = Console.ReadLine();
        int percentage = int.Parse(percent);

        string grade;

        if (percentage < 0 || percentage > 100)
        {
            Console.WriteLine("The current number is out of bounds. Try again");
            Environment.Exit(0);
            
        }

        if (percentage <= 100)
        {
            if (percentage >= 90)
            {
                grade = "A";
            }
            else if (percentage >= 80)
            {  
                grade = "B";
            }
            else if (percentage >= 70)
            {  
                grade = "C";
            }
            else if (percentage >= 60)
            {  
                grade = "D";
            }
            else
            {
                grade = "F";
            }

        if (percentage > 70 && percentage <= 100)
        {
            Console.WriteLine($"Your current grade is {grade}");
            Console.WriteLine("You Pass the Class!");
        }
        else
        {
            Console.WriteLine("You Failed the Class");
        }
        }
    }
}