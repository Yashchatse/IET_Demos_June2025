namespace _18MyMathLib
{
    public class CMath
    {
        // these modules are available with the same assembly and outside the assembly
        public int Add(int a, int b)
        {
            return a + b;
        }

        // this module is available only within the same class
        private int Sub(int a, int b)
        {
            return a - b;
        }
        // these modules are available with the same assembly but only within hierarchy (inheritance) and outside the assembly but only within hierarchy (inheritance) 
        protected int Mult(int a, int b)
        {
            return a * b;
        }
        // these modules are available only with in the same assembly
        internal int Mod(int a, int b)
        {
            return a % b;
        }
        protected internal int Div(int a, int b)
        {
            return a / b;
        }
    }
    public class DemoMath : CMath
    {
        public void Demo()
        {
            //Add(1, 2); // Public Add
            //Mult(1, 2); // Protected Mult
            //Div(10, 2); // Protected - Internal Div
            //Mod(22, 2); // Internal Mod

            Console.WriteLine($"Demo Add = {Add(1, 2)}, Mult = {Mult(1, 2)}, Div = {Div(1, 2)}, Mod = {Mod(22, 2)}");
        }
    }

}
