using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        while (number != 0)
        {               
            Console.WriteLine("Enter number: ");

            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {                
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;            
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int large = numbers[0];

        int small = 199999999;


        foreach (int numb in numbers)
        {
            if (numb > large)
            {
                large = numb;
            }

            if (small > numb && numb > 0)
            {
                small = numb;
            }
        }


        
        Console.WriteLine($"The largest number is: {large}");
        Console.WriteLine($"The smallest positive number is: {small}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();
        foreach (int numb in numbers)
        {
            Console.WriteLine(numb);
        }

    }
}