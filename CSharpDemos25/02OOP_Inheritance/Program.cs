namespace _02OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHi();
        }
    }

    public class Person
    {
        public void SayHi()
        {
            Console.WriteLine("Hi there!");
        }
    }
}
