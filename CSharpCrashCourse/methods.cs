// using System;

// class Method
// {
//     static void Main(string[] arg)
//     {
//         int[] numbers = [1, 2, 3, 4, 5];
//         Square(numbers);
//     }
//     static void Square(int[] num)
//     {  
//        foreach (int i in num)
//         {
//             Console.WriteLine($"The square of {i} is  {i * i}");
//         } 
//     }
// }

//let's try and use list to solve the same issue

using System;
using System.Collections.Generic;

class Method
{
    static void Main(string[] arg)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        Square(numbers);
    }
    static void Square(List<int> numbers)
    {
        foreach (int i in numbers)
        {
            Console.WriteLine($"The sqaure of {i} is {i * i}");
        }
    }
}