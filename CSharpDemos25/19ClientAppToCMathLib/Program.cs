using _18MyMathLib;

namespace _19ClientAppToCMathLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cmath = new CMath();

            int addResult = cmath.Add(1, 2); // Public Add

            //Console.WriteLine($"Add  = {addResult}");
            AdvMath advMath = new AdvMath();
            advMath.Add(11, 2);
            int mult = advMath.WrapperMultMethod(11, 2); // Internal Mult
            int div = advMath.WrapperDivisonMethod(11, 2); // Protected - Internal Div

            Console.WriteLine($"Add  = {addResult}, Mult = {mult}, Div = {div}");

            DemoMath demoMath = new DemoMath(); 
            demoMath.Demo(); // Demonstrating access to CMath methods in DemoMath class
        }
    }

    public class AdvMath : CMath
    {
        public int WrapperMultMethod(int x, int y)
        {
            return Mult(x, y); // Internal Mult
        }
        public int WrapperDivisonMethod(int x, int y)
        {
            return Div(x, y); // Protected - Internal Mult
        }
    }
}
