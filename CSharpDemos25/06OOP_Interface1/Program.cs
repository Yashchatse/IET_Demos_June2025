namespace _06OOP_Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            IDirink drink = null;
            if (choice == 1)
            {
                drink = new HotDrink();
            }
            else if (choice == 2)
            {
                drink = new ColdDrink();
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
                return;
            }

            Console.WriteLine($"Here is your {drink.GetDrink()} drink ! Enjoy.."); ;

            #region switch - case 
            //switch (choice)
            //{
            //    case 1:
            //        //HotDrink hotDrink = new HotDrink();
            //        //hotDrink.hotDrink();

            //        IDirink hotDrink = new HotDrink();
            //        hotDrink.GetDrink();
            //        break;
            //    case 2:
            //        //ColdDrink coldDrink = new ColdDrink();
            //        //coldDrink.coldDrink();
            //        IDirink coldDrink = new ColdDrink();
            //        coldDrink.GetDrink();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Choice.");
            //        break;
            //} 
            #endregion
        }
    }
    public interface IDirink
    {
        string GetDrink();
    }
    public class HotDrink :IDirink
    {
        public string GetDrink()
        {
            return "Tea";
        }
    }
    public class ColdDrink : IDirink
    {
        public string GetDrink()
        {
            return "Ice - Tea";
        }
    }
}
