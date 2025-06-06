public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can you the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may being in:");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine(randomPrompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                userList.Add(userInput);
                _count++;
            }
        }
        return userList;
    }

}