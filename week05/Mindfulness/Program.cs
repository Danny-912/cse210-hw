using System;

/*
CREATIVITY AND EXCEEDING REQUIREMENTS

1. Added a fourth activity called Gratitude Activity.
2. Added activity statistics tracking.
3. Reflection questions do not repeat until all questions
   have been used once.
*/

class Program
{
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;
    static int gratitudeCount = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. View Statistics");
            Console.WriteLine("  6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
                gratitudeCount++;
            }
            else if (choice == "5")
            {
                Console.Clear();

                Console.WriteLine("Activity Statistics\n");

                Console.WriteLine($"Breathing Sessions: {breathingCount}");
                Console.WriteLine($"Reflection Sessions: {reflectionCount}");
                Console.WriteLine($"Listing Sessions: {listingCount}");
                Console.WriteLine($"Gratitude Sessions: {gratitudeCount}");

                Console.WriteLine(
                    $"Total Sessions: {breathingCount + reflectionCount + listingCount + gratitudeCount}"
                );

                Console.WriteLine("\nPress Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
