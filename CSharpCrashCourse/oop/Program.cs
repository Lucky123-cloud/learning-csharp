// using System;


// class Project
// {
//     static void Main(string[] arg)
//     {
//         Person p1 = new()
//         {
//             age = 20,
//             name = "Lucky"
//         };

//         p1.Introduce();
//     }
// }
// class Person
// {
//     public int age;
//     public string? name;

//     public void Introduce()
//     {
//         Console.WriteLine($"Hello, my name is {name} and I am {age} years old");
//     }
// }

//let's work with constructors
using System;

class Project
{
    static void Main(string[] arg)
    {
        Person p1 = new(20, "Lucky");
        p1.Introduce();
    }

}

class Person
{
    public int age;
    public string? name;

    public Person(int age, string name)
    {
        if (age < 0)
        {
            throw new ArgumentException("values cannot be null");
        }
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("name cannot be empty");
        }
        this.age = age;
        this.name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {name} and I am {age} years old");
    }

}
