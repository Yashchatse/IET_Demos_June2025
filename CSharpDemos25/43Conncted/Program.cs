using _43Conncted.DAL;
using _43Conncted.Models;

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

                IETDbContext dbContext = new IETDbContext();
                int noRowsAffected = 0;

                switch (opChoice)
                {
                    case 1:
                        // Select Operation
                        List<Emp> emps = dbContext.SelectRecords();
                        if(emps.Count > 0)
                        {
                            foreach (Emp emp in emps)
                            {
                                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No records found.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Emp Name to be inserted");
                        string nameToBeInsterted = Console.ReadLine();
                        Console.WriteLine("Enter Emp Address to be inserted");
                        string addressToBeInserted = Console.ReadLine();

                        noRowsAffected =dbContext.InsertRecords(nameToBeInsterted, addressToBeInserted);
                        if (noRowsAffected > 0)
                        {
                            Console.WriteLine($"{noRowsAffected} record(s) inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No records were inserted.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Emp Id to be updated");
                        int idToBeUpdated =Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Emp Name to be updated");
                        string nameToBeUpdated = Console.ReadLine();

                        Console.WriteLine("Enter Emp Address to be updated");
                        string addressToBeUpdated = Console.ReadLine();

                        noRowsAffected = dbContext.UpdateRecords(idToBeUpdated, nameToBeUpdated, addressToBeUpdated);

                        if (noRowsAffected > 0)
                        {
                            Console.WriteLine($"{noRowsAffected} record(s) updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No records were updated.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Emp Id to be deleted");
                        int idToBeDeleted = Convert.ToInt32(Console.ReadLine());

                        noRowsAffected = dbContext.DeleteRecords(idToBeDeleted);

                        if (noRowsAffected > 0)
                        {
                            Console.WriteLine($"{noRowsAffected} record(s) deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No records were deleted.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Operation choice!!");
                        break;
                }

                Console.WriteLine("\nDo you want to continue? y/n");
                string answer = Console.ReadLine().ToLower();
                if(answer == "n")
                {
                    break;
                }
            }
        }
    }

    
}
