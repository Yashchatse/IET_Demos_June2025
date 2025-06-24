using _45EntityFramework.DAL;

namespace _45EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IETDbContext db = new IETDbContext();
            var custs = db.custs.ToList();
            foreach (var cust in custs)
            {
                Console.WriteLine($"Id = {cust.Id}, Name = {cust.Name}, BNo = {cust.BillNo}");
            }
        }
    }
}
