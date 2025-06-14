namespace _12OOP_Sigleton
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
            //_logger = new Logger();
            _logger = Logger.GetLogger();
        }
        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();

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
    public class SQLServer : Database
    {
        //private Logger _logger = null;
        //public SQLServer()
        //{
        //    _logger = new Logger();
        //}
        public override void Insert()
        {
            //code here....
            Console.WriteLine("Record instered into SQL Server successfully !!");
            _logger.Log("Insert operation happened successfully in Sql Db");
        }
        public override void Update()
        {
            //code here....
            Console.WriteLine("Record updated from SQL Server successfully !!");
            _logger.Log("Update operation happened successfully in Sql Db");

        }
        public override void Delete()
        {
            //code here....
            Console.WriteLine("Record deleted from SQL Server successfully !!");
            _logger.Log("Delete operation happened successfully in Sql Db");

        }
    }

    public class OracleServer : Database
    {
        //private Logger _logger = null;
        //public OracleServer()
        //{
        //    _logger = new Logger();
        //}
        public override void Insert()
        {
            //code here....
            Console.WriteLine("Record instered into Oracle Server successfully !!");
            _logger.Log("Insert operation happened successfully in Oracle Db");
        }
        public override void Update()
        {
            //code here....
            Console.WriteLine("Record updated from Oracle Server successfully !!");
            _logger.Log("Update operation happened successfully in Oracle Db");
        }
        public override void Delete()
        {
            //code here....
            Console.WriteLine("Record deleted from Oracle Server successfully !!");
            _logger.Log("Delete operation happened successfully in Oracle Db");
        }
    }
    public class MySQLServer : Database
    {
        //private Logger _logger = null;
        //public MySQLServer()
        //{
        //    _logger = new Logger();
        //}
        public override void Insert()
        {
            //code here....
            Console.WriteLine("Record instered into MySQL Server successfully !!");
            _logger.Log("Insert operation happened successfully in MySql Db");
        }
        public override void Update()
        {
            //code here....
            Console.WriteLine("Record updated from MySQL Server successfully !!");
            _logger.Log("Update operation happened successfully in MySql Db");

        }
        public override void Delete()
        {
            //code here....
            Console.WriteLine("Record deleted from MySQL Server successfully !!");
            _logger.Log("Delete operation happened successfully in MySql Db");

        }
    }

    public class Logger
    {
        private static Logger _logger = new Logger(); // Singleton Object
        //private static Logger _logger2 = new Logger(); // Singleton Object
        //private static object[] objectPool = new object[] { _logger, _logger2 };// Object Pool for future use
        private Logger()
        {
            Console.WriteLine("Logger Object created for the first time...");
        }

        public static Logger GetLogger()
        {
            return _logger;
        }
        //public static Logger GetLoggersSecondObject()
        //{
        //    return _logger2;
        //}
        //public static object[] GetLoggerObjectPool()
        //{
        //    return objectPool;
        //}

        //Method : Create a txt file for us DebugLog.txt / 
        public void Log(string message)
        {
            // Txt file writting log message ...
            Console.WriteLine($"---Logged msg : {message} at {DateTime.Now.ToString()}");
        }
    }
}
