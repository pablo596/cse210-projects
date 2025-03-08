using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Collect a list of numbers from the user
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num == 0)
                    break;
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        // Step 2: Core Requirements
        // Compute the sum
        int totalSum = numbers.Sum();

        // Compute the average
        double average = numbers.Count > 0 ? (double)totalSum / numbers.Count : 0;

        // Find the maximum number
        int? maxNumber = numbers.Count > 0 ? numbers.Max() : (int?)null;

        // Display results for core requirements
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Step 3: Stretch Challenges
        // Find the smallest positive number
        var positiveNumbers = numbers.Where(num => num > 0).ToList();
        int? smallestPositive = positiveNumbers.Count > 0 ? positiveNumbers.Min() : (int?)null;

        // Sort the list
        List<int> sortedNumbers = numbers.OrderBy(num => num).ToList();

        // Display results for stretch challenges
        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        Console.WriteLine("The sorted list is:");
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}