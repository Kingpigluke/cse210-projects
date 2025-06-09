using System;

class Program

{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Moroni", "7", "46");
        Scripture scripture = new Scripture(scriptureReference, "Wherefore, my beloved brethren, if ye have not charity, ye are nothing, for charity never faileth. Wherefore, cleave unto charity, which is the greatest of all, for all things must fail");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput = "";

        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            userInput = Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();
        }
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
        Console.WriteLine();
        Console.WriteLine("Great job!");
    }
}
