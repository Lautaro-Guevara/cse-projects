using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),

            new Scripture(new Reference("Ether", 12, 12),"For if there be no faith among the children of men God can do no miracle among them; wherefore, he showed not himself until after their faith."),

            new Scripture(new Reference("D&C", 11, 22), "Seek not to declare my word, but first seek to obtain my word, and then shall your tongue be loosed; then, if you desire, you shall have my Spirit and my word, yea, the power of God unto the convincing of men."),

            new Scripture(new Reference("James", 1, 5, 6), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.")
        };

        Random random = new Random();

        int randomnumber = random.Next(0, library.Count);

        library[randomnumber].GetDisplayText();

        Console.WriteLine(library[randomnumber].GetDisplayText());

        Console.WriteLine("Press Enter to continue or type 'quit' to exit:");

        string response = Console.ReadLine();

        if (response.ToLower() == "quit")
        {
            return;
        }

        do
        {
            library[randomnumber].HideRandomWords(3);
            Console.WriteLine(library[randomnumber].GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");

            response = Console.ReadLine();

            if (library[randomnumber].IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Exiting the program.");
                break;
            }
        } while (response.ToLower() != "quit");


        
    }
}