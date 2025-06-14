namespace _15OOP_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp empObj = new Emp();
            empObj.Id = 100;
            Console.WriteLine(empObj.Id);

            empObj.Name = "Hugh Jackman";
            Console.WriteLine(empObj.Name);

            empObj.IsActive = false; // Setting IsActive to true
            Console.WriteLine(empObj.IsActive);

            string[] nms = new string[2];
            nms[0] = "Hugh Jackman";
            nms[1] = "Wolverine";

            empObj.Names = nms;
        }
    }
    public class Emp
    {
        private int _Id;
        private string _Name;
        private bool _IsActive;
        private string[] _Names;

        public string[] Names
        {
            get
            {
                return _Names;
            }
            set
            {
                if(value == null || value.Length == 0)
                {
                    throw new ArgumentException("Names cannot be null or empty");
                }
                _Names = value;
            }
        }

        public bool IsActive
        {
            set
            {
                if(value == true)
                {
                    _IsActive = value;
                }
                else
                {
                    Console.WriteLine("Not allowed");
                }
                    
            }
            get
            {
                return _IsActive;
            }
        }

        // Property
        public int Id
        {
            set 
            {
                _Id = value;
            }
            get
            {
                return _Id;
            }
        }

        public string Name
        {
            set
            {
                _Name = value;
            }
            get
            {
                return _Name;
            }
        }

        #region Normal way to write getters and setters
        //public void set_Id(int id)
        //{
        //    _Id = id;
        //}
        //public int get_Id()
        //{
        //    return _Id;
        //}

        //public void set_Name(string name)
        //{
        //    _Name = name;
        //}
        //public string get_Name()
        //{
        //    return _Name;
        //} 
        #endregion
    }
}
