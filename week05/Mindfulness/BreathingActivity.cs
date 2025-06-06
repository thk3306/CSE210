using System.Diagnostics.Contracts;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        int inhale = 3;
        int exhale = 7;
        while (elapsed + inhale + exhale <= _duration)
        {
            Console.WriteLine("Breath In...");
            ShowCountDown(inhale);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(exhale);
            elapsed += inhale + exhale;
        }
        DisplayEndingMessage();
    }
}