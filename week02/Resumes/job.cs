using System;

public class job
{
    //Class: Job
    //Keeps track of the company, job title, start year, and end year.
    //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022"

    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    public void display()
    {        
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    
}