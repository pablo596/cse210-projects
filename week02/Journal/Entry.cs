using System;

namespace JournalProgram
{
    // Class representing an individual journal entry
    public class Entry
    {
        // Private attributes
        private string _date;
        private string _promptText;
        private string _entryText;

        // Constructor
        public Entry(string date, string promptText, string entryText)
        {
            _date = date;
            _promptText = promptText;
            _entryText = entryText;
        }

        // Method to display the entry
        public void Display()
        {
            Console.WriteLine("Date: " + _date);
            Console.WriteLine("Prompt: " + _promptText);
            Console.WriteLine("Entry: " + _entryText);
            Console.WriteLine("-----------------------------------");
        }

        // Override ToString to convert the entry to a string (for file storage)
        public override string ToString()
        {
            // Using '|' as a delimiter
            return $"\"{_date}\",\"{_promptText}\",\"{_entryText}\"";
        }

        // Static method to create an entry from a string read from a file
        public static Entry FromString(string entryLine)
        {
            string[] parts = entryLine.Split("\",\""); // Divide correctamente los valores entre comillas
            if (parts.Length >= 3)
            {
                return new Entry(parts[0].Trim('"'), parts[1].Trim('"'), parts[2].Trim('"'));
            }
            return null;
        }
    }
}
