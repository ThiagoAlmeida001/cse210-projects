using System;
using System.IO;
using System.Collections.Generic;

public class Prompts
{
    Random random = new Random();
    public List<string> _prompts = new List<string>()
    {
        "What was the most unexpected sound you heard today, and what caused it?",
        "If today was a movie, what would the title of this specific day be?",
        "Did you cross paths with a stranger today who caught your attention? Describe them.",
        "What is something you saw today that made you smile or laugh out loud?",
        "What was the strongest emotion I felt today?",
        "What was the best thing you ate or drank today, and where were you when you had it?",
        "Did you learn a weird, useless, or interesting fact at any point today?",
        "How did I see the hand of the Lord in my life today?",
        "What song or melody got stuck in your head today, if any?",
        "If you could replay one single minute of your day today, which minute would you choose?"
    };

    public string display()
    {
        int i = random.Next(0, _prompts.Count);

        string dailyPrompt = _prompts[i];

        Console.WriteLine("DAILY PROMPT:");
        Console.WriteLine(dailyPrompt);

        return dailyPrompt;
    }
}