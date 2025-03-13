using System;

namespace JournalProgram
{

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
            PromptGenerator promptGen = new PromptGenerator();
            bool exit = false;

            while (!exit)
            {
                // Interactive menu
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display all entries");
                Console.WriteLine("3. Save journal to a file");
                Console.WriteLine("4. Load journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        // Create a new entry
                        string prompt = promptGen.GetRandomPrompt();
                        Console.WriteLine("Prompt: " + prompt);
                        Console.Write("Write your entry: ");
                        string entryText = Console.ReadLine();
                        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        Entry newEntry = new Entry(date, prompt, entryText);
                        journal.AddEntry(newEntry);
                        Console.WriteLine("Entry added.\n");
                        break;

                    case "2":
                        // Display all entries
                        journal.DisplayAll();
                        break;

                    case "3":
                        // Save journal to a file
                        Console.Write("Enter the filename to save: ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;

                    case "4":
                        // Load journal from a file
                        Console.Write("Enter the filename to load: ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;

                    case "5":
                        // Exit the program
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        break;
                }
            }

            Console.WriteLine("Program terminated.");

    }
}
}