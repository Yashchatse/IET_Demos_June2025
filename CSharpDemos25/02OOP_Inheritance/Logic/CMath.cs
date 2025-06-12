namespace _02OOP_Inheritance.Logic
{
    public class CMath
    {
        public virtual int Add(int x, int y)
        {
            return x + y;
        }
    }
    public class AdvMath : CMath
    {
        public override int Add(int x, int y)
        {
            return x + y + 100;
        }
        public int Square(int x)
        {
            return x * x;
        }
    }
}
