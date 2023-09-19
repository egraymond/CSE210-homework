using System;

class Program
{
    static void Main(string[] args)
    {
        Random magicnumber = new Random();
        int number = magicnumber.Next(0, 21);
            
        Console.Write("Please guess a number: ");
        string guess = Console.ReadLine();
        int magguess = int.Parse(guess);
            
            while (magguess != number)
            {
                
                if (magguess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (magguess > number)
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("Try again!: ");
                guess = Console.ReadLine();
                magguess = int.Parse(guess);
            }
            Console.WriteLine("You guessed it!");
    }
}