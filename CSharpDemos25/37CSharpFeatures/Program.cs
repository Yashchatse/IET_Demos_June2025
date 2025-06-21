using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace _37CSharpFeatures
{
    public delegate bool CheckDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Classes
            //CMath obj  = new CMath();
            //Console.WriteLine(obj.Add(10, 20));
            //Console.WriteLine(obj.Sub(120, 20));
            //Console.WriteLine(obj.Add(120,30,20)); 
            #endregion

            #region Nullable Types

            //int? i = null;
            //Nullable<int> j = null;
            //Nullable<double> d = null;
            //double? d2 = null;

            ////if(j == null)
            ////{
            ////    Console.WriteLine("j is null");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("j is not null");
            ////}
            //Console.WriteLine("Enter value : ");
            //j = Convert.ToInt32(Console.ReadLine());

            //if (j.HasValue)
            //{
            //    Console.WriteLine("j is not null");
            //    Console.WriteLine(j.Value);
            //}
            //else
            //{
            //    Console.WriteLine("j is null");
            //}

            #endregion

            #region Object Initializer 
            //// Based on properties mentioned in {} syntax , csharp compiler generates overloaded constructors internally.

            //Emp emp1 = new Emp() { Name = "Hugh Jackman"};
            //Console.WriteLine(emp1.Name);
            //Emp emp2 = new Emp() { Id = 1001, Name = "Hugh Jackman"};
            //Emp emp3 = new Emp() { Id = 1001, Name = "Hugh Jackman",Address="Pune"};

            #endregion

            #region Collection Initializer
            //List<int> lstArr = new List<int>() { 10,20,30,40};
            ////lstArr.Add(10);
            ////lstArr.Add(20);
            //foreach (int ele in lstArr)
            //{
            //    Console.WriteLine(ele);
            //}

            //int[] arr = new int[] { 10, 20, 30, 40, 50 };
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Auto - Properties

            //Emp emp4 = new Emp() { Id = 101, Address = "NYC", isMax = true, Name = "Hugh Jackman"};
            //Console.WriteLine($"{emp4.Id} {emp4.Name}");

            #endregion

            #region Implicit Type - var 
            // var is local scoped.
            // var can only be used when the type is known at compile time. var gets defination at compile time.
            // var can not be used for fields, properties, or method parameters or method return types.

            //int? x = null;
            //int x = 10;
            //var v = new Emp() { Id = 101, Name = "Hugh Jackman", Address = "NYC", isMax = true };
            //var v2 = 100; 

            // //object result = GetSomeValues(3); // returns int
            //var result = GetSomeValues(3); // returns object
            //if(result is int val)
            //{
            //     val = Convert.ToInt32(result);
            //    Console.WriteLine(val);
            //}
            //else if (result is string)
            //{
            //    Console.WriteLine(result.ToString());
            //}
            //else if (result is Emp emp)
            //{
            //    Console.WriteLine($"{emp.Id} {emp.Name}");
            //}

            #endregion

            #region Anonymous Types

            ////Emp emp5 = new Emp() { isMax = false, Name = "Jack Black"};

            ////var emp6 = new Emp() { isMax = false, Name = "Jack Black"};

            //var v1 = new { isMax = false, Name = "Jack Black"};
            //Console.WriteLine(v1.GetType().ToString());

            //var v2 = new { isMax = true, Name = 12 };
            //Console.WriteLine(v2.GetType().ToString());

            //var v3 = new { Name = "Wolvarine", isMax = true };
            //Console.WriteLine(v3.GetType().ToString());

            ////var v4 = { }; // this is not allowed, anonymous type must have at least one property.

            //#region assigning values to anonymous properties 
            ////var v4 = new { id = 500 };
            ////Console.WriteLine("Enter value for id");
            ////v4.id = Convert.ToInt32(Console.ReadLine()); // this is not allowed, anonymous type properties are read-only.
            ////v4.id = 200; // this is not allowed, anonymous type properties are read-only.
            ////Console.WriteLine(v4.id); 
            //#endregion


            //Console.WriteLine("Enter value for id");
            //int num = Convert.ToInt32(Console.ReadLine());
            //var v4 = new { id = num };
            ////v4.id = 200; // this is not allowed, anonymous type properties are read-only.
            //Console.WriteLine(v4.id);

            #endregion

            #region Anonymous Method

            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            #region Normal function call 
            //if(Check(num))
            //{
            //    Console.WriteLine($"{num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less than 10");
            //} 
            #endregion

            #region Calling check with delegate
            //CheckDelegate del = new CheckDelegate(Check);
            ////del(num);
            //if (del(num))
            //{
            //    Console.WriteLine($"{num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less than 10");
            //} 
            #endregion

            //CheckDelegate del = new CheckDelegate(delegate(int x)
            //                                        {
            //                                            return x > 15;
            //                                        });
            //var check = delegate(int x)
            //            {
            //                    return x > 10;
            //                };
            ////del(num);
            //if (check(num))
            //{
            //    Console.WriteLine($"{num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less than 10");
            //}

            #endregion

            #region Lambda Expression : => goes to operator
            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            ////CheckDelegate del = Check; // new CheckDelegate(Check);
            //CheckDelegate del = num => {
            //                                return num > 10;
            //                            };
            //if(del(num))
            //    Console.WriteLine($"{num} is greater than 10");

            //CheckDelegate del2 = num => num > 20;
            //if (del2(num))
            //    Console.WriteLine($"{num} is greater than 20");

            #endregion

            #region Predicate Delegate
            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Predicate<int> predicate = x => x > 10;

            //if(predicate(num))
            //    Console.WriteLine($"{num} is greater than 10");

            #endregion

            #region Extension Methods
            //int[] arr = { 1, 2, 3, 4, 5 };
            //var nums = arr.ConvertToList(11111);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            ////Console.WriteLine(arr.Max());
            ////Console.WriteLine(arr.Sum());

            //Console.WriteLine("Enter your email");
            //string? email = Console.ReadLine();

            //////if(CheckForValidEmail(email))
            ////MyClass obj = new MyClass();
            ////if (obj.CheckForValidEmail(email))
            //if (email.CheckForValidEmail())
            //    Console.WriteLine("Valid Email");

            //ArrayList lst = new ArrayList() { 11, 12, 13 };


            #endregion

            #region Iterator

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = "somedata";
            //foreach (char ch in str)
            //{
            //    Console.WriteLine(ch);
            //}
            //ArrayList arrlst = new ArrayList();
            //foreach (var item in arrlst)
            //{

            //}

            //// My Class is behaving like a in-built arrayList class, whos object behavies like a collection

            //MyCollection daysCollection = new MyCollection();

            //foreach (var day in daysCollection)
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Named and optional Parameters

            //Display(101, "Hugh Jackman", "NYC");
            //Display(101,"Hugh Grant");
            //Display(101);
            //Display(101,"Pune");// This is logically wrong

            //Display(201, add: "Pune"); // Named Parameter
            //Display(201, add: "Pune", nm:"Jack Black"); // Named Parameter
            //Display(add: "Pune",id:300, nm:"Jack Black"); // Named Parameter

            #endregion
        }

        public static void Display(int id, string nm = "Jude Law", string add ="NYC")
        {
            Console.WriteLine($"Id = {id}, Name = {nm}, Address = {add}");
        }

        public static bool Check(int x)
        {
            return x > 10;
        }
        public static object GetSomeValues(int choice)
        {
            if (choice == 1)
            {
                return 100;
            }
            else if (choice == 2)
            {
                return "Hugh Jackman";
            }
            else
            {
                return new Emp() { Id = 101, Name = "Hugh Jackman", Address = "NYC", isMax = true };
            }
        }
    }

    public class MyCollection : IEnumerable
    {
        private string[] days = new string[] { "Monday", "Tuesday", "Wedensday", "Thrusday", "Firday", "Saturday", "Sunday"};

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string day = days[i];
                yield return day; // yield keyword is used to return the value from the iterator method. And it maintains last index value.
            }
        }

        //public string[] Days
        //{
        //    get { return days; }
        //}
    }
    public static class MyClass
    {
        public static List<int> ConvertToList(this int[] arr, int somepara)
        {
            Console.WriteLine(somepara);
            List<int> lst = new List<int>();
            foreach (int ele in arr)
            {
                lst.Add(ele);
            }
            return lst;
        }
        public static bool CheckForValidEmail(this string email)
        {
            // code 
            if (email.Contains("@"))
                return true;
            else
                return false;
        }
    }
    public class Emp
    {
        //public static void Demo<T>(T del)
        //{
        //    T()
        //}
        //private int _Hugh; // private member

        //public int EId // public property
        //{
        //    get { return _Hugh; }
        //    set { _Hugh = value; }
        //}


        #region Auto - Properties
        //Compiler has generated internally - getter and setter methods for the properties below. and also private member of type int.
        public int Id { set; get; }
        public string? Name { set; get; }
        public string? Address { set; get; }
        public bool isMax { get; set; }

        #endregion

        #region overloadded Ctors 
        //public int Id;
        //public string Name;
        //public string Address;
        //public int Age;
        //public string Designation;
        //public Emp()
        //{
        //    Id = 1001;
        //    Name = "John Doe";
        //    Address = "123 Main St";
        //    Age = 30;
        //    Designation = "Software Engineer";
        //}
        //public Emp(string nm, string add)
        //{
        //    Name = nm;
        //    Address = add;
        //}
        //public Emp(string nm, int ag)
        //{
        //    Name = nm;
        //    Age = ag;
        //} 
        #endregion
    }
    public class MyMath
    {
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
