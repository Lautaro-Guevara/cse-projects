using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int selectionNumber = 0;

        BreathingActivity breathingActivity = new BreathingActivity();

        ReflectionActivity reflectingActivity = new ReflectionActivity();

        ListingActivity listingActivity = new ListingActivity();

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            int number;

            while (true)
            {
                string selection = Console.ReadLine();

                if (int.TryParse(selection, out number))
                {
                    selectionNumber = number;
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a number from the menu: ");
                }
            }

            if (selectionNumber == 1)
            {
                breathingActivity.Run();
            }
            else if (selectionNumber == 2)
            {
                reflectingActivity.Run();
            }
            else if (selectionNumber == 3)
            {
                listingActivity.Run();
            }
        } while (selectionNumber != 4);

        Console.WriteLine("Goodbye!");
    }
}