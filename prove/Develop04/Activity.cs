using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    public Activity()
    {

    }
    public void Timer()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
        }
    }

    public void Countdown()
    {
        for (int i = 5; i > -1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}