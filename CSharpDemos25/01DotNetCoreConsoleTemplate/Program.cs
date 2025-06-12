namespace _01DotNetCoreConsoleTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes Demo
            //// Comment ctr + K +C
            //// Uncomment : ctr + K + U
            ////Int32 num1 = 100;
            //int num = 100; // Value Type
            ////Console.WriteLine(num);
            //short num1 = 23; // Value
            //long phno = 8275006278;// Value
            //string str = "Hugh Jackman"; // Reference Type
            //bool b = false; // Value
            //double d = 23.33; // Value
            //string op = $"num = {num}, num1 = {num1}, phno = {phno}, b = {b}";
            ////Console.WriteLine(op);
            ////Console.WriteLine(num +""+ num1 + phno);
            //char[] chArr = new char[] { 'h', 'i' };
            //String str1 = new string(chArr);
            //Console.WriteLine(str1);
            //// Value Types and Reference Types 
            #endregion

            #region Boxing , Unboxing, TypeCasting Demo

            //int num = 100; // Value Type
            //string str = "Hello"; // Refernce Type

            //str = num.ToString(); // Boxing
            //int j = Convert.ToInt32(str); // UnBoxing

            //Object obj = new Object();
            //obj = str; // Type Casting

            //int i = 10;
            //double d = 23.33;

            //i = Convert.ToInt32(d); // Type Casting

            #endregion

            #region Input / Output Demo

            #region int input 

            //Console.WriteLine("Enter a first number : ");
            //int num1Input =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a second number : ");
            //int num2Input = Convert.ToInt32(Console.ReadLine());

            //int addResult = num1Input + num2Input;

            //Console.WriteLine($"Add Result  = {addResult}"); 
            #endregion

            #region double input 
            //Console.WriteLine("Enter a first number : ");
            //double num1Input = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter a second number : ");
            //double num2Input = Convert.ToDouble(Console.ReadLine());

            //double addResult = num1Input + num2Input;

            //Console.WriteLine($"Add Result  = {addResult}"); 
            #endregion


            #region string input
            //Console.WriteLine("Enter a first name : ");
            //string num1Input = Console.ReadLine();

            //Console.WriteLine("Enter a second name : ");
            //string num2Input = Console.ReadLine();

            //string addResult = num1Input + num2Input;

            //Console.WriteLine($"Add Result  = {addResult}"); 
            #endregion


            #endregion

            #region Loops 

            #region if-else condition 
            //Console.WriteLine("Enter a number :");
            //int num =  Convert.ToInt32(Console.ReadLine());

            //if(num > 10)
            //{
            //    Console.WriteLine($"{num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is not greater than 10");
            //} 
            #endregion

            //do
            //{

            //}while (true);

            //while (true)
            //{
            //}

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
        }
    }
}
