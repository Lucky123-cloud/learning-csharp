using System;

class Number
{
    static void Main(string[] arg)
    {
        int num;
        while(true)
        {
            Console.WriteLine("put a number between 2 and 50 ");
            string? input = Console.ReadLine();

            if(int.TryParse(input, out num) && num >= 2 && num <= 50)
            {
                break;
            }

            Console.WriteLine("You entered an out of range number, write another number within range");
            
        }

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is EVEN");
        }
        else
        {
            Console.WriteLine($"{num} is ODD");
        }

        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }
    }
}