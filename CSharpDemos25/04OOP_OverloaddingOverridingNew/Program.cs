namespace _04OOP_OverloaddingOverridingNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cmath = new AdvMath();
            Console.WriteLine($"Add = {cmath.Add(10, 20)}");
            Console.WriteLine($"Sub = {cmath.Sub(50, 20)}");
        }
    }
    public class CMath
    {
        public int Add()
        {
            return 10;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public virtual int Sub(int x, int y)
        {
            return x - y;
        }
    }
    public class AdvMath :CMath
    {
        public int Square(int x)
        {
            return x * x;
        }
        public new int Add(int x, int y)
        {
            return x + y + 1000;
        }
        public override int Sub(int x, int y)
        {
            return (x -y) * 100;
        }
    }
}
