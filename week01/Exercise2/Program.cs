using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine("You passed! Well done!");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine("You passed! Well done!");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine("You passed! Well done!");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine("You missed the course! Better luck next time!");
        }
        else
        {
            letter = "F";
            Console.WriteLine("You missed the course! Better luck next time!");
        };

        Console.WriteLine($"Your grade is {letter}");
    }
}