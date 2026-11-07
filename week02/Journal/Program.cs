/*
  1 Expanded the data model by tracking and saving the user's current mood (1-5 scale) and weather conditions.
  2 Implemented single-line text serialization using "_" delimiters to safely save and parse all five entry attributes.
  3 Added 'File.Exists()' verification to gracefully handle missing or incorrect filenames during loading.
*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        Console.WriteLine("Welcome to the Jornal Program!");

        int opt = 0;
        while (opt != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do");
            opt = int.Parse(Console.ReadLine());
        
            if (opt == 1)
            {
                Entry newEntry = new Entry();
                newEntry.Display();

                myJournal.AddEntry(newEntry);
            }

            else if(opt == 2)
            {
                myJournal.DisplayAll();
            }

            else if(opt == 3)
            {
                Console.Write("Enter the filename to load(Ex.: MyJournal.txt): ");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    myJournal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully!");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }

            else if (opt == 4)
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();

                myJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully!");
            }


        }

    }
}