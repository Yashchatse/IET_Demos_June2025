namespace _28FileIo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Personal\IETCDAC\June25\CSharpDemos25\28FileIo1\File\EmpData.txt";
            FileStream fs = null;

            #region FileStream Write operation demo

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}


            //StreamWriter writer = new StreamWriter(fs);
            ////writer.WriteLine("Hugh Jackman");
            //Console.WriteLine("Enter some data for txt file: ");

            //string inputData = Console.ReadLine();
            //writer.WriteLine(inputData);

            //writer.Flush();
            //writer.Close();
            //fs.Close();

            //Console.WriteLine("Done");
            #endregion

            #region FileStream Read operation Demo 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not Exist !!!");
            //}
            //StreamReader reader = new StreamReader(fs);
            //string data = reader.ReadToEnd();
            //reader.Close();
            //fs.Close();

            //Console.WriteLine(data);

            #endregion

            #region FileStream Write Emp object operation demo

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }


            StreamWriter writer = new StreamWriter(fs);
           
            Emp emp= new Emp();
            emp.Id = 11;
            emp.Name = "Hugh Jackman";
            emp.Address = "Australia";

            writer.WriteLine(emp);

            writer.Flush();
            writer.Close();
            fs.Close();

            Console.WriteLine("Done");
            #endregion


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

    }
}
