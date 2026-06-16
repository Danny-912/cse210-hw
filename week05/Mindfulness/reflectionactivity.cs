using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
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

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press Enter.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder each of the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        List<string> availableQuestions = new List<string>(_questions);

        while (DateTime.Now < endTime)
        {
            if (availableQuestions.Count == 0)
            {
                availableQuestions = new List<string>(_questions);
            }

            int index = random.Next(availableQuestions.Count);

            Console.WriteLine($"\n> {availableQuestions[index]}");

            availableQuestions.RemoveAt(index);

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
