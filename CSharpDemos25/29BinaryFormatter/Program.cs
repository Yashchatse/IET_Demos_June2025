using System.Runtime.Serialization.Formatters.Binary;

namespace _29BinaryFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Personal\IETCDAC\June25\CSharpDemos25\29BinaryFormatter\File\EmpData.txt";

            // Create an instance of Emp
            Emp emp = new Emp();
            emp.Id = 101;
            emp.Name = "John Doe";
            emp.Address = "123 Main St, Anytown, USA";

            FileStream fs = null;


            #region Serialize()
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}

            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, emp);

            //fs.Close();

            //Console.WriteLine("Done");
            #endregion

            #region Deserialize()
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");
            //}

            //BinaryFormatter bf = new BinaryFormatter();
            //object obj = bf.Deserialize(fs);

            //Emp emp1 = obj as Emp;
            //Console.WriteLine($"Id = {emp1.Id}, Name = {emp1.Name}, Address = {emp1.Address}");

            //fs.Close();

            #endregion

        }
        // serializable attribute : CLR you have my permission to persist this class object data on disk in txt file 
        [Serializable] // Attributes 
        public class Emp
        {
            private int _Id;

            [NonSerialized] // This field will not be serialized and will not be persisted on drive
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
        }
    }
}
