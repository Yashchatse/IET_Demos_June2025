using System.Collections;

namespace _26DemoGeneric2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 11;
            numbers[1] = 12;
            numbers[2] = 13;
            Demo demo = new Demo();
            //demo.Add(numbers);

            string nm = "Hugh Jackman";
            string add = "New York";
            string str = string.Format("Name  = {0}, Address = {1}, Name = {0}",nm,add);
            //Console.WriteLine("Name  = {0}, Address = {1}, Name = {0}", nm, add);

            ArrayList arr = demo.PlayerNames(111,"Ronaldo", "Messy", "Neymar","Virat", "Dhoni");
            foreach (var name in arr)
            {
                Console.WriteLine(name);
            }
        }
    }
    public class Demo
    {
        public void Add(int[] arr)
        {
            int addResult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                addResult += arr[i];
            }
            Console.WriteLine("Addresult  = {0}", addResult);
        }

        //public void PlayerNames(int x, string nm1, string m2, string nm3)
        public ArrayList PlayerNames(int x, params string[] names)
        {
            Console.WriteLine($"X = {x}");
            ArrayList arr = new ArrayList();
            foreach (var name in names)
            {
                //Console.WriteLine(name);
                arr.Add(name);
            }
            return arr;
        }

    }
}
