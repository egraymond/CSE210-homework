using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = Convert.ToInt32(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int squaredNum)
    {
        return squaredNum * squaredNum;
    }
    static void DisplayResult(string userName, int squaredInt)
    {
        Console.Write($"{userName}, the square of your number is {squaredInt}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNum = PromptUserNumber();
        int squared = SquareNumber(favoriteNum);

        DisplayResult(userName, squared);
    }
}