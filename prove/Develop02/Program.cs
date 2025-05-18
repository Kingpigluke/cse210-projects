using System;
using System.Dynamic;
using System.Xml.Serialization;
namespace JournalWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "What was something good that happened today?",
                "How did you help someone today?",
                "What did you learn today?",
                "Can you think of a way to improve?",
                "How do you see yourself in the future?",
                "What is the name of the song sung by the nomads in Avatar the Last Airbender? (Hint: https://www.youtube.com/watch?v=4-GiYP_4qc0)",
                "What do you do when you are sad?",
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to Your Journal");
                Console.WriteLine("Please select one of these options:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display an entry");
                Console.WriteLine("3. Save your entry");
                Console.WriteLine("4. Load a file");
                Console.WriteLine("5. Quit the program");
                Console.WriteLine("6. Play the Number Guessing Game");

                Console.WriteLine("\nWhat is your choice? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    case "6":
                        PlayNumberGuessingGame(); // Call the game
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
        }
        static void PlayNumberGuessingGame()
            {
            Random rand = new Random();
            int numberToGuess = rand.Next(1, 101); // 1 to 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("\nWelcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (guess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    if (guess < numberToGuess)
                        Console.WriteLine("Too low!");
                    else if (guess > numberToGuess)
                        Console.WriteLine("Too high!");
                    else
                        Console.WriteLine($"Correct! You guessed it in {attempts} attempts.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
    }    
        static string GetPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}