namespace _30LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>() {

                new Emp() { Id = 1, Name = "Ganesh", Address = "Pune" },
                new Emp() { Id = 2, Name = "Mitesh", Address = "Mumbai" },
                new Emp() { Id = 3, Name = "Suresh", Address = "Patna" },
                new Emp() { Id = 4, Name = "Prathmesh", Address = "Pune" },
                new Emp() { Id = 5, Name = "Naresh", Address = "Mumbai" },
                new Emp() { Id = 6, Name = "Jignesh", Address = "Puri" },
                new Emp() { Id = 7, Name = "Suyash", Address = "Nashik" },
                new Emp() { Id = 8, Name = "Durgesh", Address = "Pune" },
                new Emp() { Id = 9, Name = "Pritesh", Address = "Pune" }
            };

            // filter by Address
            #region filtering using normal function 
            //Console.WriteLine("Enter city:");
            //string? city = Console.ReadLine().ToLower();
            //foreach (Emp emp in emps)
            //{
            //    //if(emp.Address.ToLower() == city)
            //    if (FileterCity(emp, city))
            //    {
            //        Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
            //    }
            //} 
            #endregion

            Console.WriteLine("Enter city:");
            string? city = Console.ReadLine().ToLower();

            Func<Emp, bool> func =(emp) => emp.Address.ToLower() == city;

            var filetereCities = emps.Where(func);

            foreach (var emp in filetereCities)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
            }
        }
        public static bool FileterCity(Emp emp, Func<Emp, string, bool> func)
        {
            Console.WriteLine("Enter city:");
            string? city = Console.ReadLine().ToLower();
            //if (emp.Address.ToLower() == city)
            if (func(emp,city))
                return true;
            else
                return false;
        }
    }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
