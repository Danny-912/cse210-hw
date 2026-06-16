using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What are three things you are grateful for today?",
        "Who positively influenced your life recently?",
        "What accomplishment are you most proud of?",
        "What made you smile today?"
    };

    public GratitudeActivity()
        : base(
            "Gratitude",
            "This activity helps you focus on gratitude and positive experiences."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine(
            $"\nPrompt: {_prompts[random.Next(_prompts.Count)]}"
        );

        Console.WriteLine("\nReflect on this prompt...");
        ShowSpinner(GetDuration());

        DisplayEndingMessage();
    }
}
