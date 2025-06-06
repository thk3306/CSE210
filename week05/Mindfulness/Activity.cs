public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name = "Unknown Activity";
        _description = "Unknown Description";
        _duration = 60;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} \n {_description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        ShowSpinner(3);
        Console.WriteLine($"Well Done! \n You have completed {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}