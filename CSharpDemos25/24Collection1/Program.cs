using System.Collections;

namespace _24Collection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int [] Demo 
            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[3] = 40;
            //arr[4] = 50;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"index = {i}, value = {arr[i]}");
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

            #region Emp[] arr Demo
            //Emp[] empArr = new Emp[3];
            //empArr[0] = emp1;
            //empArr[1] = emp2;
            //empArr[2] = emp3;


            //for (int i = 0; i < empArr.Length; i++)
            //{
            //    //Console.WriteLine(empArr[i].Id+" " + empArr[i].Name);
            //    Emp empRef = empArr[i];
            //    Console.WriteLine($"Id = {empRef.Id}, Name = {empRef.Name}, Address = {empRef.Address}");
            //} 
            #endregion

            Book book1 = new Book();
            book1.BookName = "The Hobbit";
            book1.Author = "J.R.R. Tolkien";

            #region object [] Demo 

            // Problems with object array
            // Boxing , unboxing , type casting overload for CLR
            // Size is fixed

            //object[] objArr = new object[6];
            //objArr[0] = emp1;// Type Casting
            //objArr[1] = emp2;// Type Casting
            //objArr[2] = book1;// Type Casting
            //objArr[3] = 100; //Boxing
            //objArr[4] = true; // Boxing
            //objArr[5] = "something"; // Type Casting

            ////int num = 20;
            ////Type numType = num.GetType();
            ////Console.WriteLine(numType.ToString());

            ////Console.WriteLine(book1.GetType().ToString());

            //for (int i = 0; i < objArr.Length; i++)
            //{
            //    #region Type Casting option 1 Syntax
            //    //if (objArr[i].GetType().ToString() == "_24Collection1.Emp")
            //    //{
            //    //    Console.WriteLine(objArr[i].GetType().ToString());
            //    //}
            //    //if (objArr[i].GetType().ToString() == "_24Collection1.Book")
            //    //{
            //    //    Console.WriteLine(objArr[i].GetType().ToString());
            //    //} 
            //    #endregion

            //    if (objArr[i] is int)
            //    {
            //        int num = Convert.ToInt32(objArr[i]); // Unboxing
            //        Console.WriteLine($"Integer value = {num}");
            //    }

            //    if (objArr[i] is bool)
            //    {
            //        bool b = Convert.ToBoolean(objArr[i]); // Unboxing
            //        Console.WriteLine($"Boolean value = {b}");
            //    }
            //    if (objArr[i] is string) 
            //    {
            //        Console.WriteLine($"String value = {objArr[i].ToString()}");// Type Casting
            //    }
            //    if (objArr[i] is Emp)
            //    {
            //        //Emp empRef = (Emp)objArr[i];
            //        Emp empRef = objArr[i] as Emp; // Type casting
            //        Console.WriteLine($"Id = {empRef.Id}, Name = {empRef.Name}, Address = {empRef.Address}");
            //    }
            //    if(objArr[i] is Book)
            //    {
            //        Book bookRef = objArr[i] as Book; // Type casting
            //        Console.WriteLine($"Book Name = {bookRef.BookName}, Author = {bookRef.Author}");
            //    }
            //} 
            #endregion

            #region ArrayList Collection Demo 
            //ArrayList arr = new ArrayList(); // Growable Collection of  object types
            //arr.Add(100);
            //arr.Add(true);
            //arr.Add("something");
            //arr.Add(emp1);
            //arr.Add(emp2);
            //arr.Add(emp3);
            //arr.Add(book1);
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    //Console.WriteLine(arr[i].GetType().ToString());
            //    if (arr[i] is int)
            //    {
            //        int num = Convert.ToInt32(arr[i]); // Unboxing
            //        Console.WriteLine($"Integer value = {num}");
            //    }
            //    if (arr[i] is bool)
            //    {
            //        bool b = Convert.ToBoolean(arr[i]); // Unboxing
            //        Console.WriteLine($"Boolean value = {b}");
            //    }
            //    if (arr[i] is string)
            //    {
            //        Console.WriteLine($"String value = {arr[i].ToString()}"); // Type Casting
            //    }
            //    if (arr[i] is Emp)
            //    {
            //        //Emp empRef = (Emp)arr[i];
            //        Emp empRef = arr[i] as Emp; // Type casting
            //        Console.WriteLine($"Id = {empRef.Id}, Name = {empRef.Name}, Address = {empRef.Address}");
            //    }
            //    if (arr[i] is Book)
            //    {
            //        Book bookRef = arr[i] as Book; // Type casting
            //        Console.WriteLine($"Book Name = {bookRef.BookName}, Author = {bookRef.Author}");
            //    }
            //} 
            #endregion

            #region Tuples in .NET Demo 
            ////ArrayList arrRef = Display(101, "John Doe", "123 Elm Street");
            ////object[] objArrRef = Display(101, "John Doe", "123 Elm Street");

            //var data = Display(101, "John Doe", "123 Elm Street");
            //Console.WriteLine($"Id  = {data.Id}, Name= {data.name}, Address = {data.address}");

            //var data2 = Display("Jane Doe", "456 Oak Avenue");
            //Console.WriteLine($"Name = {data2.name}, Address = {data2.address}"); 
            #endregion

            #region Hashtable demo 
            //Hashtable ht = new Hashtable();

            //ht.Add(1, "Hugh Jackman");
            //ht.Add(2, 100);
            //ht.Add(3, emp1);
            //ht.Add(4, book1);

            //foreach (var key in ht.Keys)
            //{
            //    if(ht[key] is int)
            //    {
            //        int num = Convert.ToInt32(ht[key]);
            //        Console.WriteLine(num);
            //    }
            //    if (ht[key] is string)
            //    {
            //        Console.WriteLine(ht[key].ToString());
            //    }
            //    //Console.WriteLine($"Key = {key}, Value  = {ht[key]}");
            //    if (ht[key] is Emp)
            //    {
            //        Emp empRef = ht[key] as Emp;
            //        Console.WriteLine($"Key = {key}, Id = {empRef.Id}, Name = {empRef.Name}, Address = {empRef.Address}");
            //    }
            //    if (ht[key] is Book)
            //    {
            //        Book bookRef = ht[key] as Book;
            //        Console.WriteLine($"Key = {key}, Book Name = {bookRef.BookName}, Author = {bookRef.Author}");
            //    }
            //}

            //#region ht.key and ht.value demo 
            ////ht.Add(1, 100);
            ////ht.Add(2, 200);
            ////ht.Add(3, 300);
            ////ht.Add(4, 400);
            ////ht.Add(5, 500);

            ////foreach (object key in ht.Keys)
            ////{
            ////    Console.WriteLine(key);
            ////}
            ////foreach (var val in ht.Values)
            ////{
            ////    Console.WriteLine(val);
            ////} 
            //#endregion 
            #endregion

            #region Stack Collection Demo 
            //Stack st = new Stack();
            //st.Push(100);
            //st.Push(200);
            //st.Push(300);
            //st.Push(400);
            //st.Pop();

            //foreach (object item in st)
            //{               
            //    if(item is int)
            //    {
            //        int num = Convert.ToInt32(item);
            //        Console.WriteLine($"Integer value = {num}");
            //    }
            //}    
            #endregion

            #region Queue Collection Demo 
            //Queue queue = new Queue();
            //queue.Enqueue(100);
            //queue.Enqueue(200);
            //queue.Enqueue(300);
            //queue.Enqueue(400);
            //queue.Dequeue();
            //foreach (object item in queue)
            //{
            //    if(item is int)
            //    {
            //        int num = Convert.ToInt32(item);
            //        Console.WriteLine($"Integer value = {num}");
            //    }
            //} 
            #endregion
        }

        //public static object[] Display(int id, string nm, string add)
        //public static ArrayList Display(int id, string nm, string add)
        public static (int Id, string name, string address) Display(int id, string nm, string add)
        {
            //object[] arr = new object[3];
            //arr[0] = id;
            //arr[1] = nm;
            //arr[2] = add;
            //ArrayList arr = new ArrayList();
            // arr.Add( id);
            // arr.Add( nm);
            // arr.Add( add);
            int Id = id;
            string name = nm;
            string address = add;
            return (Id, name, address);
        }

        public static (string name, string address) Display(string nm, string add)
        {
            string name = nm;
            string address = add;
            return (name, address);
        }
    }

    public class Emp
    {
        private string _EName;
        private int _EId;
        private string _EAddress;

        //propfull tab tab
        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }
        public int Id
        {
            get { return _EId; }
            set { _EId = value; }
        }

        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
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
