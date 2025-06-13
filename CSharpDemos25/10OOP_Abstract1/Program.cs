namespace _10OOP_Abstract1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new MyClass();
            demo.Display("Hello World!");
            demo.Show();
            demo.Foo();
        }
    }
    public abstract class  Demo
    {
        public abstract void Display(string msg);
        public abstract void Foo();
        public void Show()
        {
            Console.WriteLine("This is a non-abstract method in an abstract class.");
        }
    }

    public abstract class  Test :Demo
    {
        public override void Display(string msg)
        {
            Console.WriteLine($"A Message for You: {msg}"); ;
        }
    }
    public class MyClass : Test
    {
        public override void Foo()
        {
            Console.WriteLine("Foo from MyClass"); ;
        }
    }
}
