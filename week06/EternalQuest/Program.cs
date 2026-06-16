using System;

// EXCEEDING REQUIREMENTS:
// Added a player leveling system.
// Users gain levels as they accumulate points.
// This provides additional gamification beyond the assignment requirements.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
