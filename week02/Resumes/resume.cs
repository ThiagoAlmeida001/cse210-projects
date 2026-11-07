using System;

public class resume
{
    //Class: Resume
    //Keeps track of the person's name and a list of their jobs.
    //Displays the resume, which shows the name first, followed by displaying each one of the jobs.

    public string _name;
    public List<job> _jobs = new List<job>();


    public void display()
    {        
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (job job in _jobs)
        {
            job.display();
        }
    }
    
}