namespace _09OOP_Interface4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo 1
            //InsertIntoSQLServer();
            //UpdateIntoSQLServer();
            //DeleteIntoSQLServer();  
            #endregion

            while (true)

            {
                Console.WriteLine("Enter your DB Choice : 1. SQL Server , 2. Oracle Server, 3. MySQL DB");
                int dbChoice = Convert.ToInt32(Console.ReadLine());

                #region switch - case demo 1: 
                //switch (dbChoice)
                //{
                //    case 1: 
                //        SQLServer sqlObj = new SQLServer();
                //        Console.WriteLine("Enter your Db Operation Choice: 1. Insert, 2. Update, 3. Delete");
                //        int opChoice = Convert.ToInt32(Console.ReadLine());
                //        switch (opChoice)
                //        {
                //            case 1:
                //                sqlObj.Insert();
                //                break;
                //            case 2:
                //                sqlObj.Update();
                //                break;
                //            case 3:
                //                sqlObj.Delete();
                //                break;
                //            default:
                //                Console.WriteLine("Invalid Operation Choice");
                //                break;
                //        }
                //        break;
                //    case 2:
                //        OracleServer oracleObj = new OracleServer();
                //        Console.WriteLine("Enter your Db Operation Choice: 1. Insert, 2. Update, 3. Delete");
                //        int opChoice1 = Convert.ToInt32(Console.ReadLine());
                //        switch (opChoice1)
                //        {
                //            case 1:
                //                oracleObj.Insert();
                //                break;
                //            case 2:
                //                oracleObj.Update();
                //                break;
                //            case 3:
                //                oracleObj.Delete();
                //                break;
                //            default:
                //                Console.WriteLine("Invalid Operation Choice");
                //                break;
                //        }
                //        break;
                //    default:
                //        Console.WriteLine("Invalid DB Choice");
                //        break;

                //} 
                #endregion

                #region demo 2
                //IDatabase db = null;
                //if (dbChoice == 1)
                //{
                //    db = new SQLServer();
                //}
                //else if (dbChoice == 2)
                //{
                //    db = new OracleServer();
                //}
                //else
                //{
                //    Console.WriteLine("Invalid DB Choice");
                //    continue;
                //} 
                #endregion

                DatabaseFactory dbFactory = new DatabaseFactory();
                IDatabase someDatabaseObject = dbFactory.GetSomeDatabase(dbChoice); // Factory Method call
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
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();

    }
    public class DatabaseFactory // Object producing Factory Class
    {
        public IDatabase GetSomeDatabase(int dbChoice)// Object producing Factory Method
        {
            IDatabase db = null;
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
    public class SQLServer : IDatabase
    {
        public void Insert()
        {
            //code here....
            Console.WriteLine("Record instered into SQL Server successfully !!");
        }
        public void Update()
        {
            //code here....
            Console.WriteLine("Record updated from SQL Server successfully !!");
        }
        public void Delete()
        {
            //code here....
            Console.WriteLine("Record deleted from SQL Server successfully !!");
        }
    }

    public class OracleServer : IDatabase
    {
        public void Insert()
        {
            //code here....
            Console.WriteLine("Record instered into Oracle Server successfully !!");
        }
        public void Update()
        {
            //code here....
            Console.WriteLine("Record updated from Oracle Server successfully !!");
        }
        public void Delete()
        {
            //code here....
            Console.WriteLine("Record deleted from Oracle Server successfully !!");
        }
    }
    public class MySQLServer : IDatabase
    {
        public void Insert()
        {
            //code here....
            Console.WriteLine("Record instered into MySQL Server successfully !!");
        }
        public void Update()
        {
            //code here....
            Console.WriteLine("Record updated from MySQL Server successfully !!");
        }
        public void Delete()
        {
            //code here....
            Console.WriteLine("Record deleted from MySQL Server successfully !!");
        }
    }
}
