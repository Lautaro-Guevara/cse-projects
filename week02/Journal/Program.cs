using System;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program");

        do
        {
            
            PromptGenerator prompt = new PromptGenerator();

            prompt._prompts.Add("What brings me joy today?");
            prompt._prompts.Add("What was the best part of my day?");
            prompt._prompts.Add("If I had one thing I could do over today, what would it be?");
            prompt._prompts.Add("Who was the most interesting person I interacted with today");
            //prompt._prompts.Add("");

            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string response = Console.ReadLine();

            selection = int.Parse(response);

            if (selection == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();


                string randomPrompt = prompt.GetRandomPrompt();

                Console.WriteLine(randomPrompt);

                string answer = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = dateText;
                entry._promptText = randomPrompt;
                entry._entryText = answer;

                journal.AddEntry(entry);
            }
            else if (selection == 2)
            {
                journal.DisplayAll();
            }
            else if (selection == 3)
            {
                Console.WriteLine("What is the file to load");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (selection == 4)
            {
                Console.WriteLine("What is the filename where the journal will be save?");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }else if (selection == 5)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Error: Entry not correct");
            };


        } while (selection != 5);

        
    }
}