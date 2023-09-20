using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool zeroCheck = false;
        int numInput;
        int sum = 0;
        int average = 0;
        int bigNum = -999999999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (zeroCheck == false)
        {
            Console.Write("Enter Number: ");
            numInput = Convert.ToInt32(Console.ReadLine());
            if (numInput != 0)
            {
                numbers.Add(numInput);
            }
            else if (numInput == 0)
            {
                zeroCheck = true;
            }
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            average = sum / (i + 1);
            if (numbers[i] > bigNum)
                {
                    bigNum = numbers[i];
                }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The biggest number is: {bigNum}");
    }
}