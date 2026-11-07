using System;

class Program
{
    static void Main(string[] args)
    {
        //Class: Job
        //Keeps track of the company, job title, start year, and end year.
        //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".

        //Class: Resume
        //Keeps track of the person's name and a list of their jobs.
        //Displays the resume, which shows the name first, followed by displaying each one of the jobs.

        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job job2 = new job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;


        resume resume1 = new resume();
        resume1._name = "Allison Rose";
        resume1._jobs = [job1,job2];

        resume1.display();

    }
}