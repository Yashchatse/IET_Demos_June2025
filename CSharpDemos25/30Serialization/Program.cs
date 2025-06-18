using System.Collections;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace _30Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath2 = @"D:\Personal\IETCDAC\June25\CSharpDemos25\30Serialization\File\Data.txt";
           
            string filepath = @"D:\Personal\IETCDAC\June25\CSharpDemos25\30Serialization\File\Data.xml";

            string filepath1 = @"D:\Personal\IETCDAC\June25\CSharpDemos25\30Serialization\File\Data.json";

            Emp emp = new Emp();
            emp.Id = 1;
            emp.Name = "Hugh Jackman";
            emp.Address = "New York";

            FileStream fs = null;

            #region Xml Serialization. Serialize() 
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);

            //}
            ////Type typeOfEmp = emp.GetType();
            ////XmlSerializer xs = new XmlSerializer(typeOfEmp);

            //XmlSerializer xs = new XmlSerializer(typeof(Emp));
            //xs.Serialize(fs, emp);
            //Console.WriteLine("Done"); 
            #endregion

            #region XML Deserialize()
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");

            //}

            //XmlSerializer xs = new XmlSerializer(typeof(Emp));
            //Emp emp2 = xs.Deserialize(fs) as Emp;
            //Console.WriteLine($"Id = {emp2.Id}, Name = {emp2.Name}, Addres = {emp2.Address}");

            #endregion

            #region JSON Serializer

            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filepath1, FileMode.Create, FileAccess.Write);

            //}

            //JsonSerializer.Serialize<Emp>(fs, emp);

            //fs.Close();
            //Console.WriteLine("Done");
            #endregion

            #region JSON Deserializer

            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath1, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");
            //}

            //Emp emp2 = JsonSerializer.Deserialize<Emp>(fs);
            //fs.Close();
            //Console.WriteLine($"Id = {emp2.Id}, Name = {emp2.Name}, Addres = {emp2.Address}");
            #endregion

            #region File class
            //File.WriteAllText(filepath2, "Message for John Corner");
            //string fileData = File.ReadAllText(filepath2);
            //Console.WriteLine(fileData); 
            #endregion

            // Create sample Employee and Book objects
            Emp emp1 = new Emp { Id = 1, Name = "Alice", Address= "New York" };
            Emp emp2 = new Emp { Id = 2, Name = "Bob" , Address = "Pune" };


            Book book1 = new Book { ISBN = "123-456", Title = "C# Fundamentals", Author = "John Doe" };
            Book book2 = new Book { ISBN = "789-012", Title = "Advanced .NET", Author = "Jane Doe" };

            ArrayList arr = new ArrayList();
            arr.Add(emp1);
            arr.Add(emp2);
            arr.Add(book1);
            arr.Add(book2);

            string filepath3 = @"D:\Personal\IETCDAC\June25\CSharpDemos25\30Serialization\File\AllObjectData.json";

            // Serialize the ArrayList to JSON
            string jsonString = JsonSerializer.Serialize<ArrayList>(arr, new JsonSerializerOptions { WriteIndented =true });


            //File.WriteAllText(filepath3, jsonString);
            //Console.WriteLine(jsonString);
            string filedata = File.ReadAllText(filepath3);
            //Console.WriteLine(filedata);

            JsonArray jsonArray = JsonNode.Parse(filedata)?.AsArray() ?? new JsonArray();

            foreach (var jsonNode in jsonArray)
            {
                if (jsonNode["Id"] != null)
                {
                    Emp emp4 = JsonSerializer.Deserialize<Emp>(jsonNode.ToJsonString());
                    Console.WriteLine($"Employee -> Id: {emp4.Id}, Name: {emp4.Name}, Position: {emp4.Address}");
                }
                else if (jsonNode["ISBN"] != null)
                {
                    Book book = JsonSerializer.Deserialize<Book>(jsonNode.ToJsonString());
                    Console.WriteLine($"Book -> ISBN: {book.ISBN}, Title: {book.Title}, Author: {book.Author}");
                }
            }
        }

    }

    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Address;

        //[JsonIgnore] // This will ignore the property during serialization
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        //[XmlIgnore] // This will ignore the property during serialization
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

    public class Book
    {
        private string _ISBN;
        private string _Title;
        private string _Author;

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

    }
}
