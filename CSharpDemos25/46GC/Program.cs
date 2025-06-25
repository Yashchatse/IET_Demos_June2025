namespace _46GC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GC.Collect(2);// Do not call this by explicitly.// This will promot survived objects to next generation.
            //GC.WaitForPendingFinalizers();
            Console.WriteLine(GC.MaxGeneration);
            Console.WriteLine("Hello, World!");
            //Demo obj1 = new Demo();
            //obj1.SayHi();
            //obj1.Dispose();
            using (Demo obj = new Demo())
            {
                Console.WriteLine(GC.GetGeneration(obj)); // Get the generation of the object
                obj.SayHi(); // Call the method on the Demo object
            }
            //con.Dispose()
            //cmd.Dispose();
            // reader.Dispose();

        }
    }
    //public class Demo : IDisposable
    public class Demo : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this); // Suppress finalization for this object
            Console.WriteLine("Dispose method called.");
        }
        //~Demo()
        //{
        // This destructor gets converted into ( void Finalize() ) method by compiler 
        // This Finalize() methods  will be called by garbage collector implicitly.
        //    Console.WriteLine("Finalizer called.");
        //}
        //// This method is just for demonstration purposes

        public void SayHi()
        {
            Console.WriteLine("Hi from Demo class!");
        }
    }
}
