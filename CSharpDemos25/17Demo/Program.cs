// See https://aka.ms/new-console-template for more information
#region For main() method
Console.WriteLine("Hello, World!");
int i = 100;
Console.WriteLine($"I = {i}");
Person person = new Person("John Doe", 30);
person.DisplayInfo(); 
#endregion

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}