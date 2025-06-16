namespace _20Delegate1
{
    //Sigle Cast Delegate Example
    //deleagte declaration : available in entire same assembly
    public delegate void MyDelegate ();
    public delegate void MyDelegate1 (string nm);
    internal class Program
    {
        //deleagte declaration : available in entire same class modules
        static void Main(string[] args)
        {
            MyDelegate mydelObj = new MyDelegate(SayHi);
            mydelObj.Invoke(); //invoke the delegate

            MyDelegate1 mydelObj1 = new MyDelegate1(SayHi);
            mydelObj1("Hugh Jackman"); //invoke the delegate


            Demo demoObj = new Demo();
            //demoObj.Greet("Ben Stiller");
            MyDelegate1 del1 = new MyDelegate1(demoObj.Greet);
            del1("Hugh Grant"); //invoke the delegate

            //MyDelegate del2 = new MyDelegate(Demo.Log);
            MyDelegate del2 = Demo.Log;
            del2(); //invoke the delegate
        }
        public static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
    }
    public class Demo
    {
        public void Greet()
        {
            Console.WriteLine("Hello from Demo class!");
        }

        public void Greet(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public static void Log()
        {
            Console.WriteLine("Logging from Demo class!");
        }
    }
}
