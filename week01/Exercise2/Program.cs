using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        string letter = "";

        if (number >= 90)
        {
            if (number < 93)
            {
                letter = "A-";
            }

            else
            {                
                letter = "A";
            }
        }

        else if(number >= 80)
        {
            if (number >= 87)
            {
                letter = "B+";
            }
            
            else if (number < 83)
            {
                letter = "B-";
            }

            else
            {                
                letter = "B";
            }            
            
        }

        else if(number >= 70)
        {
            if (number >= 77)
            {
                letter = "C+";
            }
            
            else if (number < 73)
            {
                letter = "C-";
            }

            else
            {                
                letter = "C";
            }            
            
        }

        else if(number >= 60)
        {
            if (number >= 67)
            {
                letter = "D+";
            }
            
            else if (number < 63)
            {
                letter = "D-";
            }

            else
            {                
                letter = "D";
            }            
            
        }

        else
        {
            letter = "F";;
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >= 70)
        {
            Console.WriteLine("Congradulations! You are passed");
        }

        else
        {
            Console.WriteLine("Sorry, better luck next time!");
        }
    }
}