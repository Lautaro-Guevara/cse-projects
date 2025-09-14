using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        

        int numberTyped = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            
            Console.WriteLine("Enter number: ");
            string response = Console.ReadLine();
            numberTyped = int.Parse(response);

            if (numberTyped != 0)
            {
                numbers.Add(numberTyped);
            }
            

        } while (numberTyped != 0);

        int total = 0;
        int largestNumber = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            total = total + numbers[i];

            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        };



        Console.WriteLine($"The sum is: {total}");

        int average = total / numbers.Count;

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}