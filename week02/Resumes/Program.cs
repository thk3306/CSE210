using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear =
        2020;
        job1._endYear =
        2022;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Warehouse Worker";
        job2._startYear = 2020;
        job2._endYear = 2023;
        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "John Doe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResumeDetails();



        
        


    }
}