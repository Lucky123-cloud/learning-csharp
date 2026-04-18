using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string? userName = Console.ReadLine();

        Console.WriteLine("What is your age?");
        string? age = Console.ReadLine();

        int userAge = 0;

        if (!string.IsNullOrEmpty(age) && int.TryParse(age, out int parsedInt))
        {
            userAge = parsedInt;
        }
        else
        {
            Console.WriteLine("You entered invalid age, defaulting to 0 ");
        }

        Console.WriteLine($"Hello {userName}, you are {userAge} years old");
    }
}