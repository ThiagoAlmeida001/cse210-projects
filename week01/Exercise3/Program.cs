using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guessNumb = -1;

            do
            {                
                Console.WriteLine("What is your guess? ");
                string secAnswer = Console.ReadLine();
                guessNumb = int.Parse(secAnswer);

                if (guessNumb > number)
                {
                    Console.WriteLine("Lower");
                }

                else if (guessNumb < number)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("Do you want to continue?(yes or no) ");
                    response = Console.ReadLine();

                    if (response == "no")
                    {
                        Console.WriteLine("Thanks to play.");
                    }
                }
            } while (guessNumb != number);

        } 
    }
}