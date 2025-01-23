using System;

class Program
{
    static void Main(string[] args)
    {
        //create instance for job1
        Job job1 = new Job();

        //list all the variables for job1
        job1._company = "Microsoft";

        job1._jobTitle = "Software Engineer";

        job1._startYear = 2020;

        job1._endYear = 2022;


        // job2 incantce and vairables
        Job job2 = new Job();

        job2._company = "Apple";

        job2._jobTitle = "Garbage Boy";

        job2._startYear = 1999;

        job2._endYear = 2011;


        //new instance of Resume class
        Resume resume1 = new Resume();

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.DisplayResume();


    }
}