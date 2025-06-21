namespace _41ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a first number : ");
                int firstNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number : ");
                int secondNo = Convert.ToInt32(Console.ReadLine());
                if (secondNo == 0)
                {
                    throw new MyException("Second number cannot be zero.");
                }

                int divResult = firstNo / secondNo;
                
                Console.WriteLine($"Div = {divResult}");
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
