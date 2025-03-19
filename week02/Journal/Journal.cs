using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    // Class that manages the journal and stores multiple entries
    public class Journal
    {
        private List<Entry> _entries;

        // Constructor: initializes the list of entries
        public Journal()
        {
            _entries = new List<Entry>();
        }

        // Method to add a new entry
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        // Method to display all entries
        public void DisplayAll()
        {
            Console.WriteLine("Displaying all journal entries:");
            Console.WriteLine("-----------------------------------");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        // Method to save entries to a file
        public void SaveToFile(string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    sw.WriteLine(entry.ToString());
                }
            }
            Console.WriteLine("Journal saved to file: " + file);
        }

        // Method to load entries from a file
        public void LoadFromFile(string file)
        {
            if (!File.Exists(file)) // Verifica si el archivo existe
            {
                Console.WriteLine("Error: The file does not exist. Please check the filename.");
                return;
            }

            _entries.Clear(); // Limpia la lista actual antes de cargar
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Entry entry = Entry.FromString(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded from file: " + file);
        }

        // Method to load delete from a file
        public void DeleteEntry(int index)
        {
            if (index >= 0 && index < _entries.Count)
            {
                _entries.RemoveAt(index);
                Console.WriteLine("Entry deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
    }
}
