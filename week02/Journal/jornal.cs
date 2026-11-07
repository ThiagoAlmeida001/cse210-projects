using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Weather: {entry._weather}");
            Console.WriteLine($"'On a scale of 1-5, how is your mood today?': {entry._mood}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine("----------------------------------");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}_{entry._mood}_{entry._weather}_{entry._promptText}_{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("_");

            if (parts.Length == 5)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._mood = parts[1];
                loadedEntry._weather = parts[2];
                loadedEntry._promptText = parts[3];
                loadedEntry._entryText = parts[4];

                _entries.Add(loadedEntry);
            }
        }
    }
}
