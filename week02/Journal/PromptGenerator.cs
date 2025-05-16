public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts.Add("Who stood out the most in your interactions today, and why?");
            _prompts.Add("What was the highlight of your day?");
            _prompts.Add("In what ways did you feel guided or blessed today?");
            _prompts.Add("What emotion impacted you the most today, and what triggered it?");
            _prompts.Add("If you could change one thing about today, what would it be and why?");
        }
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        return prompt;
    }
}