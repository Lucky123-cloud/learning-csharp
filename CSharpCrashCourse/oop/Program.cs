using System;


class Project
{
    static void Main(string[] arg)
    {
        Person p1 = new Person
        {
            age = 20,
            name = "Lucky"
        };

        p1.Introduce();
    }
}
class Person
{
    public int age;
    public string? name;

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {name} and I am {age} years old");
    }
}