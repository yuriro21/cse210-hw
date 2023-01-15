using System;
using System.IO;
using System.Text;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        string[] _promot = {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What lesson did you learn today? ",
        "What would you like to tell your offspring today? "};
        _prompts.AddRange(_promot);
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int _index = random.Next(0, 7);
        return _prompts[_index];
    }
}