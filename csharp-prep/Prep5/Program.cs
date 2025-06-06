using System;

class Program
{
    static void Main(string[] args)
    {
         DisplayWelcomeMessage();

        string promptUserName = PromptUserName();
        int promptUserNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(promptUserNumber);

        DisplayResult(promptUserName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}. Thanks for using the program! :)");
    }
}