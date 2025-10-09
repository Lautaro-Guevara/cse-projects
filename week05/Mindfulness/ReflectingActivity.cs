public class ReflectionActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();
    List<string> _unusedPrompts = new List<string>();
    List<string> _unusedQuestions = new List<string>();

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");


        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        ResetUnusedPrompts();
        ResetUnusedQuestions();
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        DisplayQuestions();
    }

    string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            ResetUnusedPrompts();
        }

        Random random = new Random();
        int index = random.Next(_unusedPrompts.Count);
        string selectedPrompt = _unusedPrompts[index];

        _unusedPrompts.RemoveAt(index);

        return $"--- {selectedPrompt} ---";
    }

    string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            ResetUnusedQuestions();
        }

        Random random = new Random();
        int index = random.Next(_unusedQuestions.Count);
        string selectedQuestion = _unusedQuestions[index];

        _unusedQuestions.RemoveAt(index);

        return selectedQuestion;
    }

    void ResetUnusedPrompts()
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    void ResetUnusedQuestions()
    {
        _unusedQuestions = new List<string>(_questions);
    }

    void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    void DisplayQuestions()
    {
        int cycles = _duration / 10;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(10);
        }
    }
}