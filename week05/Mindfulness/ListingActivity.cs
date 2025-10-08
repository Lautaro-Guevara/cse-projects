public class ListingActivity : Activity
{
    int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        ResetUnusedPrompts();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        GetListFromUser();

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPromt()
    {
        if (_unusedPromts.Count == 0)
        {
            ResetUnusedPrompts();
        }

        Random random = new Random();
        int index = random.Next(_unusedPromts.Count);
        string selectedPrompt = _unusedPromts[index];

        _unsedPromts.RemoveAt(index);

        Console.WriteLine($"--- {selectedPrompt} ---");

        return selectedPrompt;
    }

    List<string> GetListFromUser()
    {
        List<string> listStrings = new List<string>();
        _count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            string strings = Console.ReadLine();
            listStrings.Add(strings);
            _count++;
        }

        return listStrings;
    }
}