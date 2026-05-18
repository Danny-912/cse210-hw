using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Call the welcome function
        DisplayWelcome();

        // Get the user's name
        string userName = PromptUserName();

        // Get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to ask for user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Function to ask for user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();

        int number = int.Parse(input);

        return number;
    }

    // Function to square the number
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    // Function to display the result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
    