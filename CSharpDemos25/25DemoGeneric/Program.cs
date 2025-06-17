using System.ComponentModel;

namespace _25DemoGeneric
{
    public delegate void MyDelegate<T>(T value); // Generic delegate declaration


    public delegate R MyDelegate2<P, Q, R>(P p1, Q p2, R p3); // Generic delegate with multiple parameters
    // public R Display<P, Q, R>(P p1, Q p2, R p3)


    public delegate void MyDelegate3<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4);
    // public void Test<T1,T2,T3,T4>(T1 p, T2 q, T3 r, T4 s, out bool result)
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath obj = new CMath();
            #region Swap Calling Demo : Genric Swap and Non-Generic Swap
            //// Swapping integers
            //int p = 100, q = 200;
            //Console.WriteLine($"Before Calling : P= {p}, Q = {q}");
            ////obj.Swap(ref p,ref q);
            //obj.Swap<int>(ref p, ref q); // Using generic method
            //Console.WriteLine($"After Calling : P= {p}, Q = {q}");

            //// Swapping strings
            //string str1 = "Hugh Jackman", str2 = "Hugh Grant";
            //Console.WriteLine($"Before Calling : Str1= {str1}, Str2 = {str2}");
            ////obj.Swap(ref str1, ref str2);
            //obj.Swap<string>(ref str1, ref str2); // Using generic method
            //Console.WriteLine($"After Calling : Str1= {str1}, Str2 = {str2}"); 
            #endregion

            #region Generic Add with dynamic type 
            //int x = 10, y = 20;

            //Console.WriteLine(obj.Add<int>(ref x, ref y));

            //double d1 = 23.33, d2 = 44.56;
            //Console.WriteLine(obj.Add<double>(ref d1, ref d2)); 
            #endregion

            #region out parameter 
            //Console.WriteLine("Enter radius");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //double a, c;
            //obj.CalculateCircleArea(radius, out a,out c);
            //Console.WriteLine($"Area  = {a}, Circumference = {c}"); 
            #endregion

            #region Generic Class with non-generic and generic methods

            //Demo<string> demo=new Demo<string>();
            //demo.SayHi();
            #endregion

            MyClass myClass = new MyClass();
            //double d = myClass.Display<int, string, double>(100, "Hello", 99.99);

            //Console.WriteLine(d);

            MyDelegate<string> del = new MyDelegate<string>(myClass.SayHello);
            del("IET");
        }
    }
    public class CMath
    {
        //This is a no generic class containing generic as well as non generic methods

        public void SayHi()
        {
            Console.WriteLine("Hi there!!!");
        }
        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public T Add<T>(ref T x, ref T y)
        {
            dynamic n1 = x;
            dynamic n2 = y;
            T addResult = n1 + n2;
            return addResult;
        }

        public void CalculateCircleArea(double radius, out double area, out double circumference)
        {
            area = 3.14 * radius * radius;
            circumference = 2 * 3.14 * radius;
        }

        #region Swap Overloaded Method Syntax
        //public void Swap(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //} 
        #endregion
    }

    public class Demo<T>
    {
        public void SayHi() // Non - generic method inside generic class
        {
            Console.WriteLine("Hi there !!!!");
        }
        public void SayHi(T name)// generic method inside generic class
        {
            Console.WriteLine($"Hi,{name} !!!!");
        }
    }

    public class MyClass
    {
        public void SayHello<T>(T name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        public R Display<P, Q, R>(P p1, Q p2, R p3)
        {
            Console.WriteLine(p1.GetType().ToString());
            return p3;
        }

        public void Test<T1,T2,T3,T4>(T1 p, T2 q, T3 r, T4 s, out bool result)
        {
            result = true;
        }
    }
}
