namespace _08OOP_Interface3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo 1 
            //IX xObj = new CMath();
            //Console.WriteLine(xObj.Add(10, 20));
            //Console.WriteLine(xObj.Sub(10, 20));

            //IY yObj = new CMath();
            //Console.WriteLine(yObj.Mult(3, 4));
            //Console.WriteLine(yObj.Div(16, 4));
            //Console.WriteLine(yObj.Add(10, 20)); 
            #endregion

            Test testObj = new Test();
            testObj.Greet("Hugh Jackman");
            testObj.Foo();
            //testObj.DebugLog("This is a debug message");

        }
    }
    public interface IX
    {
        public int Add(int x, int y);
        public int Sub(int x, int y);
    }
    public interface IY
    {
        public int Add(int x, int y);
        public int Mult(int x, int y);
        public int Div(int x, int y);
    }

    public interface IDemo
    {
        void Greet(string name);
        void Foo();
        void DebugLog(string message);
    }
    public class Test : IDemo
    {
        void IDemo.DebugLog(string message)
        {
            Console.WriteLine($"Msg : {message} - logged in txtx file");
        }

        public void Foo()
        {
            Console.WriteLine("Foo");
        }

        public void Greet(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }

    #region Demo with IX and IY implicit implementation 
    //public class Demo : IX, IY
    //{
    //    public int Add(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Div(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Mult(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Sub(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }
    //} 
    #endregion

    #region CMath with explict implementation of IX and IY interfaces
    //public class CMath : IX, IY
    //{
    //    int IX.Add(int x, int y)
    //    {
    //        return x + y;
    //    }

    //    int IY.Add(int x, int y)
    //    {
    //        return x + y + 1000;
    //    }

    //    int IY.Div(int x, int y)
    //    {
    //        return x / y;
    //    }

    //    int IY.Mult(int x, int y)
    //    {
    //        return x * y;
    //    }

    //    int IX.Sub(int x, int y)
    //    {
    //        return x - y;
    //    }
    //} 
    #endregion
}
