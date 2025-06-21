using System.Runtime.CompilerServices;

namespace _38LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Predicate 
            //Predicate<string> del = s => s == "Hugh Jackman";

            //string name = "Hugh Jackman";
            //if (del(name))
            //{
            //    Console.WriteLine("The name is Hugh Jackman");
            //}
            //else
            //{
            //    Console.WriteLine("The name is not Hugh Jackman");
            //} 
            #endregion

            #region Action Delegate
            //Action del1 = new Action(SayHi);
            //del1();

            //Action del1 = new Action(delegate () 
            //                            {
            //                                Console.WriteLine("Hi There!!");
            //                            });

            //Action del1 = delegate ()
            //{
            //    Console.WriteLine("Hi There!!");
            //};
            //del1();

            //Action del1 = () => Console.WriteLine("Hi There!!");
            ////del1();
            //SayHi(del1); 
            #endregion

            #region Func<in T1, out TResult> 
            //int id = 22;
            //string str = "abcd";

            //Func<int,string,string> del3 = (id, s) => $"{id} Hugh Jackman {s}";
            ////Console.WriteLine(del3(id,str));
            //SayHi(del3, id, str); 
            #endregion


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> numbers = arr.MySelect(); // int[] to List<int>

            //List<int> evennos = numbers.MyWhere();

            //var evennumbers = arr.MySelect().MyWhere();

            //foreach (int num in evennos)
            //{
            //    Console.WriteLine(num);
            //}

            #region Custom extension methods  accepting delegate as parameter
            //Func<int, bool> evenDel = item => item % 2 == 0;
            //Func<int, bool> oddDel = item => item % 2 != 0;
            //Func<int, bool> funcDel = item => item > 6;

            //var result = arr.MySelect().MyWhere(evenDel);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------------------------------");
            //var result1 = arr.MySelect().MyWhere(oddDel);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------------");

            //var result2 = arr.MySelect().MyWhere(funcDel);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //arr.MyWhere(evenDel).MySelect();
            //var result =  arr.Where(funcDel);
        }
        #region A method with delegate as parameter type
        //public static void SayHi(Action actionDel)
        //{
        //    actionDel();
        //}
        //public static void SayHi(Func<int, string, string> func,int id, string str)
        //{
        //    string output = func(id, str);
        //    Console.WriteLine(output);
        //} 
        #endregion

    }

    public static class MyClass
    {
        public static List<T> MySelect<T>(this IEnumerable<T> arr)
        {
            List<T> list = new List<T>();
            foreach (var item in arr)
            {
                list.Add(item);
            }

            return list;
        }

        public static List<T> MyWhere<T> (this IEnumerable<T> arr, Func<int,bool> predicate)
        {
            List<T> numbers = new List<T>();
            foreach (var item in arr)
            {
                if (item is int number ) // Example condition
                {
                    if(predicate(number))
                    {
                        numbers.Add(item);
                    }
                    //if(number % 2 == 0) // Only add even numbers
                    //{
                    //    evennumbers.Add(item);
                    //}
                }
            }
            return numbers;
        }
    }
}
