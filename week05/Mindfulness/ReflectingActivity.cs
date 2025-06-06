using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the Following Prompt");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience.\n You may being in: ");
        ShowCountDown(5);
        int elapsed = 0;
        while (elapsed <= _duration)
        {
            DisplayQuestions();
            ShowSpinner(5);
            elapsed += 5;
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}