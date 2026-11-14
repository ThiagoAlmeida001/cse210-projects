//Added a ScriptureLoader class that loads a library of scriptures from an external "Scripture.txt" file and selects one at random at startup, handling both single-verse and multi-verse references.

using System;


class Program
{
    static void Main(string[] args)
    {
        ScriptureLoader loader = new ScriptureLoader("Scripture.txt");
        Scripture scripture = loader.GetRandomScripture();

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood job! Program ended.");
    }
}