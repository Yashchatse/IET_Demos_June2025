namespace _40LINQ4
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
            emps.Any
            //Console.WriteLine("Enter first ch of city name :");
            //string city = Console.ReadLine().ToLower();

            //LINQ - Language Integrated Query
            #region LINQ Synatx and Lazy-loading of LINQ 


            //// Lazy -loading / Delayed execution of LINQ query
            //var result  = (from emp in emps
            //               where emp.Address.ToLower() == city
            //               select emp).ToList();

            ////var result1= emps.Where(emp => emp.Address.ToLower() == city).Select(emp => emp).ToList();
            //emps.Add(new Emp() { Id = 10, Name = "Hugh Jackman", Address = "Pune" });

            //foreach (Emp emp in result)
            //{
            //    Console.WriteLine($"Id = {emp.Id}, {emp.Name}, {emp.Address}");
            //} 
            #endregion

            #region LINQ with Anonymous Types
            ////var result = (from emp in emps
            ////              where emp.Address.ToLower().StartsWith(city)
            ////              select new Holder() { HName = emp.Name,HAddress = emp.Address });

            //var result = (from emp in emps
            //              where emp.Address.ToLower().StartsWith(city)
            //              select new { HName = emp.Name, HAddress = emp.Address });

            //foreach (var obj in result)
            //{
            //    Console.WriteLine($"Name = {obj.HName},Address ={obj.HAddress}");
            //} 
            #endregion

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = (from num in arr
                          where num%2 == 0
                          orderby num descending
                          select num).ToList();

            Console.WriteLine(string.Join(",",result));

            //foreach (int no in result)
            //{
            //    Console.WriteLine(no);
            //}
        }
    }
    public class Holder
    {
        public int HId { get; set; }
        public string HName { get; set; }
        public string HAddress { get; set; }
    }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
