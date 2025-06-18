namespace _27GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<int>
            //List<int> numbers = new List<int>();
            //numbers.Add(100);
            //numbers.Add(200);
            //numbers.Add(300);
            //numbers.Add(400);
            //numbers.Add(500);

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            Emp emp1 = new Emp();
            emp1.Id = 11;
            emp1.Name = "Hugh Jackman";
            emp1.Address = "Sydney, Australia";

            Emp emp2 = new Emp();
            emp2.Id = 12;
            emp2.Name = "Tom Cruise";
            emp2.Address = "Los Angeles, USA";

            Emp emp3 = new Emp();
            emp3.Id = 13;
            emp3.Name = "Robert Downey Jr.";
            emp3.Address = "New York, USA";

            Book book1 = new Book();
            book1.BookName = "The Hobbit";
            book1.Author = "J.R.R. Tolkien";

            #region List<Emp> 
            //List<Emp> empList = new List<Emp>();
            //empList.Add(emp1);
            //empList.Add(emp2);
            //empList.Add(emp3);

            //foreach (Emp emp in empList)
            //{
            //    emp.GetDetails();
            //} 
            #endregion

            Dictionary<int,Emp> dt = new Dictionary<int, Emp>();
            dt.Add(1,emp1);
            dt.Add(2,emp2);
            dt.Add(3,emp3);

            foreach (int key in dt.Keys)
            {
                Console.WriteLine($"\nKey = {key}, Value = \n");
                Emp emp = dt[key];
                emp.GetDetails();
            }

            Stack<Book> bookStack = new Stack<Book>();
            Stack<int> nums = new Stack<int>();
        }
    }

    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Address: {Address}");
        }

    }

    public class Book
    {
        private string _Author;
        private string _BookName;

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }


        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

    }
}
