using System;

class Method
{
    static void Main(string[] arg)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Square(numbers);
    }
    static void Square(int[] num)
    {  
       foreach (int i in num)
        {
            Console.WriteLine($"The square of {i} is  {i * i}");
        } 
    }
}