namespace _03OOP_Inhertance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass(100);
        }
    }
    public class BaseClass
    {
        int _Num;
        public BaseClass()
        {
            
        }
        public BaseClass(int num)
        {
            _Num = num;
        }
    }
    public class DerivedClass :BaseClass
    {
        public DerivedClass(int no):base(no)
        {
            
        }
    }
}
