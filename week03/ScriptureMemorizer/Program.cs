 using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

// W03 Project: Scripture Memorizer
// Author: Odiase Daniella
//
// === Creativity / Exceeds Requirements ===
// Instead of practicing a single hardcoded scripture,
// this program maintains a library of scriptures and
// randomly selects one each time the program runs.
// It also only hides words that are still visible,
// making the memorization process more effective and
// preventing wasted selections of already-hidden words.
    
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),

            new Scripture(
                new Reference("Joshua", 1, 9),
                "Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest."
            ),

            new Scripture(
                new Reference("Psalms", 23, 1, 3),
                "The Lord is my shepherd I shall not want. He maketh me to lie down in green pastures he leadeth me beside the still waters. He restoreth my soul."
            )
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                Console.Clear();
                Console.WriteLine("Goodbye! Keep memorizing!");
                break;
            }

            scripture.HideRandomWords(3);
        }
    }}
    
