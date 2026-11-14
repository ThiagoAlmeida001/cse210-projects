using System;
using System.IO;

public class ScriptureLoader
{
    private string _filePath;

    public ScriptureLoader(string filePath)
    {
        _filePath = filePath;
    }

    public Scripture GetRandomScripture()
    {
        string[] lines = File.ReadAllLines(_filePath);

        Random random = new Random();
        int randomIndex = random.Next(lines.Length);
        string selectedLine = lines[randomIndex];

        string[] parts = selectedLine.Split('_');

        string book = parts[1];
        int chapter = int.Parse(parts[2]);
        int startVerse = int.Parse(parts[3]);

        Reference reference;
        string text;

        if (parts.Length == 5)
        {
            reference = new Reference(book, chapter, startVerse);
            text = parts[4];
        }
        else
        {
            int endVerse = int.Parse(parts[4]);
            reference = new Reference(book, chapter, startVerse, endVerse);
            text = parts[5];
        }

        return new Scripture(reference, text);
    }
}
