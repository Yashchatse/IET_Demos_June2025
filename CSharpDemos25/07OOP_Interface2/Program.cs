namespace _07OOP_Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit way 
            ////CMath cMath = new CMath();
            //IX xObj = new CMath();
            //Console.WriteLine($"Add from IX  = {xObj.Add(10, 20)}"); // 30
            //Console.WriteLine($"Sub from IX  = {xObj.Sub(100, 20)}"); // 80
            //IY yObj = new CMath();
            //Console.WriteLine($"Mult from IY  = {yObj.Mult(10, 20)}"); //200
            //Console.WriteLine($"Div from IY  = {yObj.Div(100, 20)}"); // 5 
            #endregion

            Console.WriteLine("Enter your ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id == 10)
            {
                IX xObj = new CMath();
                Console.WriteLine($"Add from IX  = {xObj.Add(10, 20)}"); // 30
                Console.WriteLine($"Sub from IX  = {xObj.Sub(100, 20)}"); // 80
            }
            else if (id == 20)
            {
                IY yObj = new CMath();
                Console.WriteLine($"Mult from IY  = {yObj.Mult(10, 20)}"); //200
                Console.WriteLine($"Div from IY  = {yObj.Div(100, 20)}"); // 5 
            }
            else if (id == 30) 
            {
                IPlatinum pObj = new CMath();
                Console.WriteLine($"Add from IPlatinum  = {pObj.Add(10, 20)}"); // 30
                Console.WriteLine($"Sub from IPlatinum  = {pObj.Sub(100, 20)}"); // 80
                Console.WriteLine($"Mult from IPlatinum  = {pObj.Mult(10, 20)}"); //200
                Console.WriteLine($"Div from IPlatinum  = {pObj.Div(100, 20)}"); // 5 
            }
            else
            {
                Console.WriteLine("Invalid Id !!");
            }
        }
    }

    //Task for Developer : Chetan
    public interface IX
    {
        int Add(int x, int y);
        int Sub(int x, int y);
    }

    //Task for Developer : Yash
    public interface IY
    {
        int Mult(int x, int y);
        int Div(int x, int y);
    }

    public interface IPlatinum
    {
        int Add(int x, int y);
        int Sub(int x, int y);
        int Mult(int x, int y);
        int Div(int x, int y);
    }

    public class CMath : IX, IY, IPlatinum
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
