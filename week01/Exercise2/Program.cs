using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===============================");
        Console.WriteLine("* Grade Calculator Program *");
        Console.WriteLine("===============================");

        Console.WriteLine("Enter your grade percentage: ");
        double percentage = double.Parse(Console.ReadLine());

        string letterGrade = "";
        string sign = "";

        double lastDigit = percentage % 10;

        // Stretch Challenge
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit > 0 && lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Core Requirements
        if (percentage >= 90)
        {
            if (lastDigit > 0 && lastDigit <= 3)
            {
                letterGrade = "A" + sign;
            }
            else
            {
                letterGrade = "A";
            }

        }
        else if (percentage >= 80)
        {
            letterGrade = "B" + sign;

        }
        else if (percentage >= 70)
        {
            letterGrade = "C" + sign;

        }
        else if (percentage >= 60)
        {
            letterGrade = "D" + sign;

        }
        else
        {
            letterGrade = "F";

        }

        Console.WriteLine("");
        Console.WriteLine("=========================================");
        Console.WriteLine($" *      Your letter grade is: {letterGrade}      *");
        Console.WriteLine("=========================================");
        Console.WriteLine("");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the coursed!");
        }
        else
        {
            Console.WriteLine("Sorry, keep trying, you can do better next time.");
        }

    }
}