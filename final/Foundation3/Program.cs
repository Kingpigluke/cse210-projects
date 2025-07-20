using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Event Planner! We can help you prepare for your next big occassion! :)");
        Console.WriteLine("Let us begin!");
        string[] listOfEvents = {"Lectures", "Receptions", "Outdoors"};
        Console.WriteLine("");
        Console.WriteLine($"Which event would you like to plan?: 1. {listOfEvents[0]}  2. {listOfEvents[1]}  3. {listOfEvents[2]} (Put in the key phrase please.)");
        string theEvent = Console.ReadLine().ToLower();
        Console.WriteLine("");

        void StandardMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Standard - Event Information: ");
            Console.WriteLine("- - - - - - - - - - - - - - - -");
        }
        void FulldMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Full - Event Information: ");
            Console.WriteLine("- - - - - - - - - - - - - - - -");
        }
        void ShortMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Short - Event Information: ");
            Console.WriteLine("- - - - - - - - - - - - - - - -");
        }

        switch (theEvent)
        {
            case "lectures":
                Lectures lectures = new();
                lectures.BookLectureEvent();

                StandardMessage();
                lectures.DisplayStandardDetails();

                FulldMessage();
                lectures.DisplayFullDetails();

                ShortMessage();
                lectures.DisplayShortDetails();
                break;

            case "receptions":
                Reception reception = new();
                reception.BookReceptionEvent();

                StandardMessage();
                reception.DisplayStandardDetails();

                FulldMessage();
                reception.DisplayFullDetails();

                ShortMessage();
                reception.DisplayShortDetails();
                break;

            case "outdoors":
                Outdoor outdoor = new();
                outdoor.BookEvent();

                StandardMessage();
                outdoor.DisplayStandardDetails();

                FulldMessage();
                outdoor.DisplayFullDetails();

                ShortMessage();
                outdoor.DisplayShortDetails();
                break;

            default:
                Console.WriteLine("Uh oh! That is an invalid event. Please try again, or create a new one to match it!");
                break;
        }
    }
}
