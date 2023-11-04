using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "School Bus Driver";
        job1._company = "SR School District";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "CS Supervisor";
        job2._company = "SkyWest";
        job2._startYear = 2013;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Julie Crowther";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}