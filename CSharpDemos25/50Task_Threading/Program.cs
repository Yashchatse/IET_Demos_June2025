using System.Diagnostics;

namespace _50Task_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Main Thread ID is {0}", Thread.CurrentThread.ManagedThreadId);
            //262147

            #region Use Single Thread To Execute Main, F1, F2 - single cpu 
            //F1();
            //F2();
            #endregion

            #region Use Multiple Thread To Execute Main, F1, F2 - but single CPU on avarage

            //Thread t1 = new Thread(F1);
            //Thread t2 = new Thread(F2);

            //t1.Start();
            //t2.Start();


            //t1.Join();
            //t2.Join();


            #endregion
            #region Use Multiple Thread To Execute Main, F1, F2 - but single CPU on avarage

            //Task t1 = new Task(F1);
            //Task t2 = new Task(F2);

            //t1.Start();
            //t2.Start();


            //t1.Wait();
            //t2.Wait();

            #endregion

            #region Single Thread :  11383168 Milliseconds (1 CPU)

            //for (int i = 0; i < 100; i++)
            //{
            //    DoSomethingComplex();
            //}
            #endregion

            #region Multiple Threads :  14645008  Milliseconds(1 CPU)


            //List<Thread> threads = new List<Thread>();

            //for (int i = 0; i < 100; i++)
            //{
            //    Thread thread = new Thread(DoSomethingComplex);
            //    thread.Start();
            //    threads.Add(thread);
            //}

            //foreach (var thread in threads)
            //{
            //    thread.Join();
            //}
            #endregion

            #region Multiple Tasks :  4526355 Milliseconds (Multiple CPUs)

            //List<Task> tasks = new List<Task>();

            //for (int i = 0; i < 100; i++)
            //{
            //    Task task = new Task(DoSomethingComplex);
            //    task.Start();
            //    tasks.Add(task);
            //}

            //Task.WaitAll(tasks.ToArray());

            #endregion

            #region Sample Emp Collection

            var emps = new List<Emp>()
            {
                new Emp(){  No = 1, Name = "Kishor", Address = "Vashim" },
                new Emp(){  No = 2, Name = "Abhimanyu", Address = "Bhopal" },
                new Emp(){  No = 3, Name = "Rushikesh", Address = "Mumbai" },
                new Emp(){  No = 4, Name = "Omkar", Address = "Kolhapur" },
                new Emp(){  No = 5, Name = "Prateek", Address = "Chennai" },
                new Emp(){  No = 6, Name = "Rahul", Address = "Panji" },
                new Emp(){  No = 7, Name = "Prashant", Address = "Karad" }
            };

            #endregion

            #region Explanation of : Implicit Parallel Programming

            #region Single Thread//69006
            //foreach (var emp in emps)
            //{
            //    Print(emp);
            //}


            #endregion

            //Parallel For Each
            #region Multiple Tasks - Multiple Threads - Multiple CPUS
            //Here automatically tasks will be created
            //Parallel.ForEach(emps, Print);
            #endregion

            #region Single Thread


            //var result = (from emp in emps
            //              where emp.No > 3
            //              select emp.ToString());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            //Parallel LINQ
            #region Multiple Tasks - Multiple Threads - Multiple CPUS

            var result = (from emp in emps.AsParallel()
                          where emp.No > 3
                          select emp.ToString());

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            #endregion

            #endregion

            stopwatch.Stop();

            Console.WriteLine("Time taken  = {0}", stopwatch.ElapsedTicks);
            //Console.WriteLine("Time taken  = {0}", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
        public static void Print(Emp emp)
        {
            Console.WriteLine(emp.No + " - " + emp.Name);
        }

        public static void DoSomethingComplex()
        {
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    //Do nothing..
                }
            }
        }

        public static void F1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread ID executing F1 is {0},  and i= {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }

        public static void F2()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Thread ID executing F2 is {0},  and i= {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
    public class Emp
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return No + " - " + Name;
        }
    }
}
