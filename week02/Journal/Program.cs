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

        // Loads default journal if exists
        string defaultFile = "journal.csv";
        if (File.Exists(defaultFile))
        {
            journal.LoadFromFile(defaultFile);
            Console.WriteLine("Journal loaded from previous session.");
        }

        while (!exit)
        {
            // Interactive menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Delete an entry");
            Console.WriteLine("6. Add a custom prompt");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option (0-6): ");
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
                    // Delete journal
                case "5":
                    Console.Write("Enter the entry number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        journal.DeleteEntry(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "7":
                    // Custom prompt
                    Console.Write("Enter a new prompt: ");
                    string newPrompt = Console.ReadLine();
                    promptGen.AddPrompt(newPrompt);
                    break;

                case "0":
                    // Exit the program
                    journal.SaveToFile(defaultFile); // Auto save on exit
                    Console.WriteLine("Journal saved automatically.");
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