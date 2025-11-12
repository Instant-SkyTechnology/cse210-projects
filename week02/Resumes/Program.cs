using System;

class Program
{
    static void Main(string[] args)
    {
        Job job0 = new Job();
        job0._companyName = "Sky Technology";
        job0._jobTitle = "CEO";
        job0._startYear = 2021;
        job0._endYear = 2022;

        Job job1 = new Job();
        job1._companyName = "Bell Canada";
        job1._jobTitle = "Professional Engineer";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._companyName = "Blue Sky";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Job job3 = new Job();

        Resume resume1 = new Resume();
        resume1._name = "Steve";
        resume1._lastName = "Kalala";

        resume1._jobs.Add(job0);
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);

        resume1.Display();
    }
}