public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int cicles = _duration / 10;

        for (int i = cicles; i > 0; i--)
        {
            Console.Write("Breathe in...");
            ShowSpinner(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}