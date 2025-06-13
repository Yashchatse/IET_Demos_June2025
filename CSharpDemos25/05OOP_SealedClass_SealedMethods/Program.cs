namespace _05OOP_SealedClass_SealedMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public sealed class CMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

    public class AdvMath //:CMath
    {
        public int WrapperAdd(int x, int y)
        {
            CMath obj = new CMath();
            return obj.Add(x, y);
        }
        public virtual int Square(int x)
        {
            return x * x;
        }
    }

    public class MyMath : AdvMath
    {
        public sealed override int Square(int x)
        {
            return x * x * 10;
        }
    }
    public class MyMath2 : MyMath
    {
        public override int Square(int x)
        {
            return x * x * 100;
        }
    }
}
