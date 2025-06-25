using _45EntityFramework.DAL;
using _45EntityFramework.Models;

namespace _45EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IETDbContext db = new IETDbContext();
            Customer cust = new Customer();


            #region Select Records
            //var custs = db.custs.ToList();

            //foreach (var cust in custs)
            //{
            //    Console.WriteLine($"Id = {cust.Id}, Name = {cust.Name}, BNo = {cust.BillNo}");
            //} 
            #endregion

            #region Insert Record
            //Console.WriteLine("Enter Customer Name :");
            //cust.Name = Console.ReadLine();
            //Console.WriteLine("Enter Customer Bill No :");
            //cust.BillNo = Convert.ToInt32(Console.ReadLine());

            //db.custs.Add(cust);

            //// Save changes to the database
            //db.SaveChanges();
            //Console.WriteLine("Done");

            #endregion

            #region Update Record
            //Console.WriteLine("Enter Customer Id to be updated :");
            //int id = Convert.ToInt32(Console.ReadLine());
            ////cust.Id = Convert.ToInt32(Console.ReadLine());

            //Customer c = db.custs.Find(id);
            //Console.WriteLine($"{c.Id},  {c.Name},  {c.BillNo}");

            //Console.WriteLine("Enter Customer Name to be updated:");
            //c.Name = Console.ReadLine();

            //Console.WriteLine("Enter Customer Bill No to be updated :");
            //c.BillNo = Convert.ToInt32(Console.ReadLine());

            //db.custs.Update(c);

            //// Save changes to the database
            //db.SaveChanges();
            //Console.WriteLine("Done");
            #endregion

            #region Update Record
            //Console.WriteLine("Enter Customer Id to be updated :");
            //cust.Id = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Customer Name to be updated:");
            //cust.Name = Console.ReadLine();

            //Console.WriteLine("Enter Customer Bill No to be updated :");
            //cust.BillNo = Convert.ToInt32(Console.ReadLine());

            //db.custs.Update(cust);

            //// Save changes to the database
            //db.SaveChanges();
            //Console.WriteLine("Done");
            #endregion

            #region Delete Record
            //Console.WriteLine("Enter Customer Id to be deleted :");
            //cust.Id = Convert.ToInt32(Console.ReadLine());

            //Customer c = db.custs.Find(cust.Id);

            //if (c != null)
            //{
            //    db.custs.Remove(c);
            //    Console.WriteLine($"Record with Id = {c.Id} deleted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Customer not found.");
            //}

            //// Save changes to the database
            //db.SaveChanges();
            //Console.WriteLine("Done");
            #endregion

            #region Stored Procedure

            Console.WriteLine("Enter Customer Id to be fetched :");
            int id = Convert.ToInt32(Console.ReadLine());
            Customer customer = db.GetCustomerById(id);
            if (customer != null)
            {
                Console.WriteLine($"Id = {customer.Id}, Name = {customer.Name}, BNo = {customer.BillNo}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
            #endregion
        }
    }
}
