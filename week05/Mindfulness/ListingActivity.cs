class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _userItems = new List<string>(); // Enhancement: store items entered

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        Random rand = new Random();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string selectedPrompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"> {selectedPrompt}");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _userItems.Add(item);
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        // Enhancement: display what was listed
        Console.WriteLine("Here is what you listed:");
        foreach (string item in _userItems)
        {
            Console.WriteLine($"- {item}");
        }
    }
}