using System;
using System.IO;

public class Entry
{   
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public string _weather;

    Prompts prompts1 = new Prompts();

    public void display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        Console.WriteLine("What is the weather like right now?");
        _weather = Console.ReadLine();

        Console.WriteLine("On a scale of 1-5, how is your mood today?");
        _mood = Console.ReadLine();

        _promptText = prompts1.display();

        _entryText = Console.ReadLine();

    }

}