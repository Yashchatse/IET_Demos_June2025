namespace _43Conncted
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            // Buissness Presentation Layer : View / UI Layer

            while (true)
            {
                Console.WriteLine("Enter operation choice:");
                Console.WriteLine("1. Select 2. Insert, 3. Update, 4. Delete");
                int opChoice =  Convert.ToInt32(Console.ReadLine());

                switch (opChoice)
                {
                    case 1:
                        // Select Operation
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string answer = Console.ReadLine().ToLower();
                if(answer == "n")
                {
                    break;
                }
            }
        }
    }

    
}
