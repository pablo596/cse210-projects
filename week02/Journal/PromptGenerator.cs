using System;
using System.Collections.Generic;

namespace JournalProgram
{
    // Class that handles generating random prompts
    public class PromptGenerator
    {
        private List<string> _prompts;
        private Random _random;

        // Constructor: defines a list of example prompts
        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "How are you feeling today?",
                "Describe a happy moment in your life.",
                "What inspired you recently?",
                "Write about a challenge you overcame.",
                "What would you like to achieve tomorrow?"
            };
            _random = new Random();
        }

        // Method to get a random prompt
        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
        public void AddPrompt(string prompt)
        {
            _prompts.Add(prompt);
            Console.WriteLine("New prompt added.");
        }

    }
}
