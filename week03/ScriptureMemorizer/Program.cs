using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of multiple scriptures
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy.")
        };

        // Select one scripture at random
        var random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        // Main loop
        while (!selectedScripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords(3);
        }

        // Final display when all words are hidden
        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Program ended.");
    }
}