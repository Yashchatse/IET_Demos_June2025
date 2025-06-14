namespace _13OOP_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                Console.WriteLine("Enter your DB Choice : 1. SQL Server , 2. Oracle Server, 3. MySQL DB");
                int dbChoice = Convert.ToInt32(Console.ReadLine());

                DatabaseFactory dbFactory = new DatabaseFactory();
                Database someDatabaseObject = dbFactory.GetSomeDatabase(dbChoice); // Factory Method call
                if (someDatabaseObject != null)
                {
                    Console.WriteLine("Enter your Db Operation Choice: 1. Insert, 2. Update, 3. Delete");
                    int opChoice = Convert.ToInt32(Console.ReadLine());
                    switch (opChoice)
                    {
                        case 1:
                            someDatabaseObject.Insert();
                            break;
                        case 2:
                            someDatabaseObject.Update();
                            break;
                        case 3:
                            someDatabaseObject.Delete();
                            break;
                        default:
                            Console.WriteLine("Invalid Operation Choice");
                            break;
                    }
                }
                Console.WriteLine("Do you want to continue? y/ n");
                string ch = Console.ReadLine().ToLower();
                if (ch == "n")
                {
                    break;
                }
            }
        }
    }
    public abstract class Database
    {
        public Logger _logger = null;
        public Database()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract string GetDabaseName();

        public void Insert()
        {
            DoInsert(); // Template Method
            _logger.Log($"Insert operation happened successfully in {GetDabaseName()} Db");
        }
        public void Update()
        {
            DoUpdate(); // Template Method
            _logger.Log($"Update operation happened successfully in {GetDabaseName()}  Db");
        }
        public void Delete()
        {
            DoDelete(); // Template Method
            _logger.Log($"Delete operation happened successfully in {GetDabaseName()} Db");
        }

    }
    public class DatabaseFactory // Object producing Factory Class
    {
        public Database GetSomeDatabase(int dbChoice)// Object producing Factory Method
        {
            Database db = null;
            switch (dbChoice)
            {
                case 1:
                    db = new SQLServer();
                    break;
                case 2:
                    db = new OracleServer();
                    break;
                case 3:
                    db = new MySQLServer();
                    break;
                default:
                    db = null;
                    break;
            }
            return db;
        }
    }
    //Developer : Yash
    public class SQLServer : Database
    {
        protected override string GetDabaseName()
        {
            return "Sql Server";
        }
        protected override void DoInsert()
        {
            //code here....
            Console.WriteLine("Record instered into SQL Server successfully !!");
        }
        protected override void DoUpdate()
        {
            //code here....
            Console.WriteLine("Record updated from SQL Server successfully !!");
        }
        protected override void DoDelete()
        {
            //code here....
            Console.WriteLine("Record deleted from SQL Server successfully !!");
        }
    }

    //Developer : Chetan
    public class OracleServer : Database
    {
        protected override string GetDabaseName()
        {
            return "Oracle Server";
        }
        protected override void DoInsert()
        {
            //code here....
            Console.WriteLine("Record instered into Oracle Server successfully !!");
        }
        protected override void DoUpdate()
        {
            //code here....
            Console.WriteLine("Record updated from Oracle Server successfully !!");
        }
        protected override void DoDelete()
        {
            //code here....
            Console.WriteLine("Record deleted from Oracle Server successfully !!");
        }
    }

    //Developer : Omkar
    public class MySQLServer : Database
    {
        protected override string GetDabaseName()
        {
            return "MySQL Server";
        }
        protected override void DoInsert()
        {
            //code here....
            Console.WriteLine("Record instered into MySQL Server successfully !!");
        }
        protected override void DoUpdate()
        {
            //code here....
            Console.WriteLine("Record updated from MySQL Server successfully !!");
        }
        protected override void DoDelete()
        {
            //code here....
            Console.WriteLine("Record deleted from MySQL Server successfully !!");
        }
    }

    public class Logger
    {
        private static Logger _logger = new Logger(); // Singleton Object
        private Logger()
        {
            Console.WriteLine("Logger Object created for the first time...");
        }

        public static Logger GetLogger()
        {
            return _logger;
        }

        //Method : Create a txt file for us DebugLog.txt / 
        public void Log(string message)
        {
            // Txt file writting log message ...
            Console.WriteLine($"---Logged msg : {message} at {DateTime.Now.ToString()}");
        }
    }
}
