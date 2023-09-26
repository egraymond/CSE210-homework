using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Developer";
        job1._startYear = 2009;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Team Lead";
        job2._startYear = 2002;
        job2._endYear = 2008;

        Resume myResume = new Resume();
        myResume._name = "Elias Garlitz";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();


    }
}