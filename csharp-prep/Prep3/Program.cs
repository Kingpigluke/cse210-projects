using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mysterynumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != mysterynumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (mysterynumber > guess)
            {
                Console.WriteLine("Gotta go higher!");
            }
            else if (mysterynumber < guess)
            {
                Console.WriteLine("Gotta go lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}